﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using LoLCameraSharp.MemoryFunctions;
using LoLCameraSharp.IniHandler;
using LoLCameraSharp.Keyboard;

namespace LoLCameraSharp
{
    public partial class LoLCamera : Form
    {
        //Memory Functions:
        MemoryEditor m = new MemoryEditor("League of Legends");
        Pattern p = new Pattern();

        //Address Cache:
        IntPtr YawAddress;
        IntPtr PitchAddress;
        IntPtr CameraHeightAddress;
        IntPtr FoVAddress;
        IntPtr XPositionAddress;
        IntPtr YPositionAddress;
        IntPtr ZoomAddress;
        IntPtr DrawDistanceAddress;
        IntPtr CameraModeAddress;
        IntPtr MaxZoomAddress;

        IntPtr PointerAddress;

        //Timer Ticks:
        Timer UpdateCamera = new Timer();
        Timer SearchForGame = new Timer();

        //General Global Vars
        bool PatternsFound = false;
        float defaultPitch, pitch = 0f;
        float defaultYaw, yaw = 0f;
        float defaultCameraHeight, cameraHeight = 0f;
        float defaultDrawDistance, drawDistance = 0f;
        float defaultFoVDegree, fovDegree = 0f;
        float defaultZoom, zoom = 0f;
        float speed = 25.0f;
        byte defaultCameraMode, cameraMode = 0;
        Stopwatch deltaTime = new Stopwatch();
        string IniFile;

        enum HudCameraMode 
        { 
            Default = 0x0, 
            FPSCamera = 0x1, 
            ThirdPersonCamera = 0x2, 
            FocusCamera = 0x3, 
        };

        public LoLCamera()
        {
            InitializeComponent();
        }

        private void FindGameTick(object sender, EventArgs e)
        {
            if (m.gameFound)
            {
                if(!PatternsFound)
                    PatternsFound = GetCameraOffsets();
            }
            else
            {
                PatternsFound = false;
                if (m.FindGame("League of Legends"))
                    PatternsFound = GetCameraOffsets();
            }

            if (m.gameFound && PatternsFound)
            {
                GetDefaultValues();
                SearchForGame.Enabled = false;
                deltaTime.Restart();
                UpdateCamera.Enabled = true;
            }
        }

        private void UpdateCameraTick(object sender, EventArgs e)
        {
            if (m.gameFound)
            {
                if (tabControlView.SelectedTab == tabDebug)
                    addressView.Lines = DisplayAddresses();

                float dt = (float)(deltaTime.Elapsed.TotalMilliseconds / 1000f);
                deltaTime.Restart();
                HandleCamera(dt);  
            }
            else
            {
                addressView.Clear();
                UpdateCamera.Enabled = false;
                SearchForGame.Enabled = true;
            }
        }

        private void HandleCamera(float deltaTime)
        {
            //m.WriteBytes(CameraModeAddress, new Byte[] {0x00});
            m.WriteFloat(MaxZoomAddress, 4000.0f); //Override Max Zoom
            //m.WriteFloat(ZoomAddress, 3000.0f); //Desired Zoom
            //m.WriteFloat(ZoomAddress - 0x04, 3000); //Current Zoom

            // Check Hotkeys for key presses and adjust camera accordingly, get mouse location etc!
            if (((Hotkeys)pitchIncreaseHotkey.Tag).IsTriggered())
            {
                pitch += speed * deltaTime;
                m.WriteFloat(PitchAddress, pitch);
            }
            else if (((Hotkeys)pitchDecreaseHotkey.Tag).IsTriggered())
            {
                pitch -= speed * deltaTime;
                m.WriteFloat(PitchAddress, pitch);
            }

            if (((Hotkeys)yawIncreaseHotkey.Tag).IsTriggered())
            {
                yaw += speed * deltaTime;
                m.WriteFloat(YawAddress, yaw);
            }
            else if (((Hotkeys)yawDecreaseHotkey.Tag).IsTriggered())
            {
                yaw -= speed * deltaTime;
                m.WriteFloat(YawAddress, yaw);
            }

            if (((Hotkeys)cameraHeightIncreaseHotkey.Tag).IsTriggered())
            {
                cameraHeight += (10*speed) * deltaTime;
                m.WriteFloat(CameraHeightAddress, cameraHeight);
            }
            else if (((Hotkeys)cameraHeightDecreaseHotkey.Tag).IsTriggered())
            {
                cameraHeight -= (10*speed) * deltaTime;
                m.WriteFloat(CameraHeightAddress, cameraHeight);
            }

            if (((Hotkeys)drawDistanceIncreaseHotkey.Tag).IsTriggered())
            {
                drawDistance += 15.0f * speed * deltaTime;
                m.WriteFloat(DrawDistanceAddress, drawDistance);
            }
            else if (((Hotkeys)drawDistanceDecreaseHotkey.Tag).IsTriggered())
            {
                drawDistance -= 15.0f * speed * deltaTime;
                m.WriteFloat(DrawDistanceAddress, drawDistance);
            }

            if (((Hotkeys)speedIncreaseHotkey.Tag).IsTriggered())
                speed += 0.1f;
            else if (((Hotkeys)speedDecreaseHotkey.Tag).IsTriggered())
                speed -= 0.1f;

            if (((Hotkeys)restoreDefaultsHotkey.Tag).IsTriggered())
                RestoreDefaults();

            // fov addition
            if (((Hotkeys)fovIncreaseHotkey.Tag).IsTriggered())
            {
                fovDegree += speed * deltaTime;
                m.WriteFloat(FoVAddress, fovDegree);
            }
            else if (((Hotkeys)fovDecreaseHotkey.Tag).IsTriggered())
            {
                fovDegree -= speed * deltaTime;
                m.WriteFloat(FoVAddress, fovDegree);
            }
            
        }

        private bool GetCameraOffsets()
        {
            //Sanity Check
            if (m.gameFound)
            {
                uint patternAddr = p.FindPattern("\\xA1\\x00\\x00\\x00\\x00\\x83\\xC4\\x14\\x8B\\x00\\x8B\\x0D\\x00\\x00\\x00\\x00\\xD9\\x80\\x00\\x00\\x00\\x00", "x????xxxxxxx????xx????", ref m);

                if (patternAddr == 0)
                    return false; //Pattern is out of date

                //Increment Addr by one to get to the location where the pointer is
                patternAddr++;

                uint pointerAddr = m.ReadUInt((IntPtr)patternAddr);
                pointerAddr = m.ReadUInt((IntPtr)pointerAddr);
                pointerAddr = m.ReadUInt((IntPtr)pointerAddr);

                if (pointerAddr == 0)
                    return false; //Pointer hasn't been setup yet

                FoVAddress = (IntPtr)(pointerAddr + 0x130);
                YawAddress = (IntPtr)(pointerAddr + 0x124);
                PitchAddress = (IntPtr)(pointerAddr + 0x120);
                YPositionAddress = (IntPtr)(pointerAddr + 0x10C);
                XPositionAddress = (IntPtr)(pointerAddr + 0x104);
                ZoomAddress = (IntPtr)(pointerAddr + 0x1BC); //Desired Zoom, Current Zoom - 0x04
                CameraModeAddress = (IntPtr)(pointerAddr + 0x1C0);

                PointerAddress = (IntPtr)(pointerAddr);

                patternAddr = p.FindPattern("\\xC7\\x87\\x00\\x00\\x00\\x00\\x00\\x00\\x00\\x00\\xE8\\x00\\x00\\x00\\x00\\x8B\\x87\\x00\\x00\\x00\\x00\\x8D\\x8F\\x00\\x00\\x00\\x00\\x89\\x45\\xCC", "xx????????x????xx????xx????xxx", ref m);
                
                if (patternAddr == 0)
                    return false; //Pattern is out of date

                CameraHeightAddress = (IntPtr)(patternAddr + 0x06);

                patternAddr = p.FindPattern("\\xF3\\x0F\\x58\\x15\\x00\\x00\\x00\\x00\\xF3\\x0F\\x11\\x45\\xB8", "xxxx????xxxxx", ref m);

                if (patternAddr == 0)
                    return false; //Pattern is out of date

                patternAddr += 0x4;
                pointerAddr = m.ReadUInt((IntPtr)patternAddr);

                DrawDistanceAddress = (IntPtr)(pointerAddr + 0x10);
    
                //Max Zoom Out
                patternAddr = p.FindPattern("\\xF3\\x0F\\x10\\x0D\\x00\\x00\\x00\\x00\\x0F\\x2F\\xC1\\x77\\x0D\\xF3\\x0F\\x10\\x0D\\x00\\x00\\x00\\x00", "xxxx????xxxxxxxxx????", ref m);

                if (patternAddr == 0)
                    return false; //Pattern is out of date
                MaxZoomAddress = (IntPtr)m.ReadUInt((IntPtr)patternAddr + 0x04);
                //Unprotect the MaxZoom Address
                m.WriteProtectedMemory(MaxZoomAddress, 0x04, (uint)MemoryEditor.Protection.PAGE_EXECUTE_READWRITE, (uint)MemoryEditor.Protection.PAGE_READONLY);

                addressView.Lines = DisplayAddresses();
                return true;
            }
            return false;
        }

        private string[] DisplayAddresses()
        {

            List<string>  AddressDisplay = new List<string>();
            AddressDisplay.Add(string.Concat(new object[] { "Yaw Address: ", YawAddress.ToString("X"), ",  Pitch Address: ", PitchAddress.ToString("X") }));
            AddressDisplay.Add(string.Concat(new object[] { "Yaw: ", m.ReadFloat(YawAddress).ToString(), ",  Pitch: ", m.ReadFloat(PitchAddress).ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "X Position Address: ", XPositionAddress.ToString("X"), ",  Y Position Address: ", YPositionAddress.ToString("X") }));
            AddressDisplay.Add(string.Concat(new object[] { "X: ", m.ReadFloat(XPositionAddress).ToString(), ",  Y: ", m.ReadFloat(YPositionAddress).ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "Camera Height Address: ", CameraHeightAddress.ToString("X"), ",  FoV Address: ", FoVAddress.ToString("X") }));
            AddressDisplay.Add(string.Concat(new object[] { "Camera Height: ", m.ReadFloat(CameraHeightAddress).ToString(), ",  Field of View: ", m.ReadFloat(FoVAddress).ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "Zoom Address: ", ZoomAddress.ToString("X"), ",  Value: ", m.ReadFloat(ZoomAddress).ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "View Distance Address: ", DrawDistanceAddress.ToString("X"), ",  Value: ", m.ReadFloat(DrawDistanceAddress).ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "Camera Rotation Speed: ", speed.ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "Camera Mode: ", cameraMode.ToString("X") }));
            AddressDisplay.Add(string.Concat(new object[] { "Max Zoom Address: ", MaxZoomAddress.ToString("X"), ",  Value: ", m.ReadFloat(MaxZoomAddress).ToString() }));
            AddressDisplay.Add(string.Concat(new object[] { "Pointer Address: ", PointerAddress.ToString("X")} ));

            return AddressDisplay.ToArray();
        }

        private void GetDefaultValues()
        {
            defaultPitch = pitch = m.ReadFloat(PitchAddress);
            defaultYaw = yaw = m.ReadFloat(YawAddress);
            defaultCameraHeight = cameraHeight = m.ReadFloat(CameraHeightAddress);
            defaultDrawDistance = drawDistance = m.ReadFloat(DrawDistanceAddress);
            defaultCameraMode = cameraMode = m.ReadBytes(CameraModeAddress, 1)[0];
            // fov addition
            defaultFoVDegree = fovDegree = m.ReadFloat(FoVAddress);
            // zoom addition
            defaultZoom = zoom = m.ReadFloat(ZoomAddress);
            speed = 25.0f;
        }

        private void RestoreDefaults()
        {
            pitch = defaultPitch;
            yaw = defaultYaw;
            cameraHeight = defaultCameraHeight;
            drawDistance = defaultDrawDistance;
            fovDegree = defaultFoVDegree;

            m.WriteFloat(PitchAddress, defaultPitch);
            m.WriteFloat(YawAddress, defaultYaw);
            m.WriteFloat(CameraHeightAddress, defaultCameraHeight);
            m.WriteFloat(DrawDistanceAddress, defaultDrawDistance);
            m.WriteBytes(CameraModeAddress, BitConverter.GetBytes(defaultCameraMode));

            m.WriteFloat(FoVAddress, defaultFoVDegree);
            m.WriteFloat(ZoomAddress, defaultZoom);
        }

        private void LoLCamera_Load(object sender, EventArgs e)
        {
            IniFile = Directory.GetCurrentDirectory() + "\\cameraHotkeys.cfg";

            if(!File.Exists(IniFile))
                File.Create(IniFile).Dispose();

            LoadHotkeys();

            //Search for game every second
            SearchForGame.Interval = 1000;
            SearchForGame.Tick += new EventHandler(this.FindGameTick);
            SearchForGame.Enabled = true;

            UpdateCamera.Interval = 1;
            UpdateCamera.Tick += new EventHandler(this.UpdateCameraTick);
        }

        //Hotkey Handling:
        //Note: Saving & Loading, use ToString() and use Keys key = (Keys)Enum.Parse(typeof(Keys), key2.ToString());
        private void HandleHotkey(object sender, EventArgs e)
        {
            HotkeyBinding form = new HotkeyBinding(this, (TextBox)sender);
            form.Visible = true;
            this.Visible = false;
        }

        #region INIHandling
        private void SaveHotkeys()
        {
            IniParser parser = new IniParser(IniFile);

            parser.AddSetting("Pitch", "IncreaseHotkey", pitchIncreaseHotkey.Text);
            parser.AddSetting("Pitch", "DecreaseHotkey", pitchDecreaseHotkey.Text);

            parser.AddSetting("Yaw", "IncreaseHotkey", yawIncreaseHotkey.Text);
            parser.AddSetting("Yaw", "DecreaseHotkey", yawDecreaseHotkey.Text);

            parser.AddSetting("Height", "IncreaseHotkey", cameraHeightIncreaseHotkey.Text);
            parser.AddSetting("Height", "DecreaseHotkey", cameraHeightDecreaseHotkey.Text);

            parser.AddSetting("Speed", "IncreaseHotkey", speedIncreaseHotkey.Text);
            parser.AddSetting("Speed", "DecreaseHotkey", speedDecreaseHotkey.Text);

            parser.AddSetting("ViewDistance", "IncreaseHotkey", drawDistanceIncreaseHotkey.Text);
            parser.AddSetting("ViewDistance", "DecreaseHotkey", drawDistanceDecreaseHotkey.Text);
            // fov addition
            parser.AddSetting("FoV", "IncreaseHotkey", fovIncreaseHotkey.Text);
            parser.AddSetting("FoV", "DecreaseHotkey", fovDecreaseHotkey.Text);
            // zoom addition
            //parser.AddSetting("Zoom", "IncreaseHotkey", zoomIncreaseHotkey.Text);
            //parser.AddSetting("Zoom", "DecreaseHotkey", zoomDecreaseHotkey.Text);

            parser.AddSetting("RestoreDefaults", "Hotkey", restoreDefaultsHotkey.Text);

            parser.SaveSettings();
        }

        private void LoadHotkeys()
        {
            IniParser parser = new IniParser(IniFile);

            string hotkey;

            hotkey = parser.GetSetting("Pitch", "IncreaseHotkey");
            pitchIncreaseHotkey.Text = hotkey;
            pitchIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("Pitch", "DecreaseHotkey");
            pitchDecreaseHotkey.Text = hotkey;
            pitchDecreaseHotkey.Tag = parseSetting(hotkey);

            hotkey = parser.GetSetting("Yaw", "IncreaseHotkey");
            yawIncreaseHotkey.Text = hotkey;
            yawIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("Yaw", "DecreaseHotkey");
            yawDecreaseHotkey.Text = hotkey;
            yawDecreaseHotkey.Tag = parseSetting(hotkey);

            hotkey = parser.GetSetting("Height", "IncreaseHotkey");
            cameraHeightIncreaseHotkey.Text = hotkey;
            cameraHeightIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("Height", "DecreaseHotkey");
            cameraHeightDecreaseHotkey.Text = hotkey;
            cameraHeightDecreaseHotkey.Tag = parseSetting(hotkey);

            hotkey = parser.GetSetting("Speed", "IncreaseHotkey");
            speedIncreaseHotkey.Text = hotkey;
            speedIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("Speed", "DecreaseHotkey");
            speedDecreaseHotkey.Text = hotkey;
            speedDecreaseHotkey.Tag = parseSetting(hotkey);

            hotkey = parser.GetSetting("ViewDistance", "IncreaseHotkey");
            drawDistanceIncreaseHotkey.Text = hotkey;
            drawDistanceIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("ViewDistance", "DecreaseHotkey");
            drawDistanceDecreaseHotkey.Text = hotkey;
            drawDistanceDecreaseHotkey.Tag = parseSetting(hotkey);

            // fov addition
            hotkey = parser.GetSetting("FoV", "IncreaseHotkey");
            fovIncreaseHotkey.Text = hotkey;
            fovIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("FoV", "DecreaseHotkey");
            fovDecreaseHotkey.Text = hotkey;
            fovDecreaseHotkey.Tag = parseSetting(hotkey);

            // zoom addition
            /*
            hotkey = parser.GetSetting("Zoom", "IncreaseHotkey");
            zoomIncreaseHotkey.Text = hotkey;
            zoomIncreaseHotkey.Tag = parseSetting(hotkey);
            hotkey = parser.GetSetting("Zoom", "DecreaseHotkey");
            zoomDecreaseHotkey.Text = hotkey;
            zoomDecreaseHotkey.Tag = parseSetting(hotkey);
            */
            

            hotkey = parser.GetSetting("RestoreDefaults", "Hotkey");
            restoreDefaultsHotkey.Text = hotkey;
            restoreDefaultsHotkey.Tag = parseSetting(hotkey);
        }
        #endregion

        private Hotkeys parseSetting(string setting)
        {
            try
            {
                string[] keys = setting.Split(',');
                return new Hotkeys((Keys)Enum.Parse(typeof(Keys), keys[0]), (Keys)Enum.Parse(typeof(Keys), keys[1]));
            }catch{
                return new Hotkeys();
            }
        }

        public void ProcessHotkey(Hotkeys hotkey, HotkeyBinding form, TextBox textBox)
        {
            form.Close();
            textBox.Text = hotkey.subKey.ToString() + "," + hotkey.mainKey.ToString();
            textBox.Tag = hotkey;
            SaveHotkeys();
            this.Visible = true;
        }
        public void CancelHotkey(HotkeyBinding form)
        {
            form.Close();
            this.Visible = true;
        }
    }
}
