﻿namespace LoLCameraSharp
{
    partial class LoLCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoLCamera));
            this.tabControlView = new System.Windows.Forms.TabControl();
            this.tabHotkeys = new System.Windows.Forms.TabPage();
            this.drawDistanceDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.drawDistanceIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.speedDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.speedIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cameraHeightDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.cameraHeightIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yawDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.yawIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.pitchDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.pitchIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPitchIncrease = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblHotkeys = new System.Windows.Forms.Label();
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.addressView = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.restoreDefaultsHotkey = new System.Windows.Forms.TextBox();
            this.tabControlView.SuspendLayout();
            this.tabHotkeys.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlView
            // 
            this.tabControlView.Controls.Add(this.tabHotkeys);
            this.tabControlView.Controls.Add(this.tabDebug);
            this.tabControlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlView.Location = new System.Drawing.Point(0, 0);
            this.tabControlView.Name = "tabControlView";
            this.tabControlView.SelectedIndex = 0;
            this.tabControlView.Size = new System.Drawing.Size(424, 381);
            this.tabControlView.TabIndex = 0;
            // 
            // tabHotkeys
            // 
            this.tabHotkeys.Controls.Add(this.restoreDefaultsHotkey);
            this.tabHotkeys.Controls.Add(this.label14);
            this.tabHotkeys.Controls.Add(this.drawDistanceDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.drawDistanceIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.label10);
            this.tabHotkeys.Controls.Add(this.label11);
            this.tabHotkeys.Controls.Add(this.label12);
            this.tabHotkeys.Controls.Add(this.speedDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.speedIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.label7);
            this.tabHotkeys.Controls.Add(this.label8);
            this.tabHotkeys.Controls.Add(this.label9);
            this.tabHotkeys.Controls.Add(this.cameraHeightDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.cameraHeightIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.label4);
            this.tabHotkeys.Controls.Add(this.label5);
            this.tabHotkeys.Controls.Add(this.label6);
            this.tabHotkeys.Controls.Add(this.yawDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.yawIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.label2);
            this.tabHotkeys.Controls.Add(this.label3);
            this.tabHotkeys.Controls.Add(this.lblYaw);
            this.tabHotkeys.Controls.Add(this.pitchDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.pitchIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.label1);
            this.tabHotkeys.Controls.Add(this.lblPitchIncrease);
            this.tabHotkeys.Controls.Add(this.lblPitch);
            this.tabHotkeys.Controls.Add(this.lblHotkeys);
            this.tabHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabHotkeys.Name = "tabHotkeys";
            this.tabHotkeys.Size = new System.Drawing.Size(416, 355);
            this.tabHotkeys.TabIndex = 0;
            this.tabHotkeys.Text = "Hotkeys";
            this.tabHotkeys.UseVisualStyleBackColor = true;

            int rolling = 0;

            // 
            // pitchDecreaseHotkey
            // 
            this.pitchDecreaseHotkey.Location = new System.Drawing.Point(291, 50);
            this.pitchDecreaseHotkey.Name = "pitchDecreaseHotkey";
            this.pitchDecreaseHotkey.ReadOnly = true;
            this.pitchDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.pitchDecreaseHotkey.TabIndex = 6;
            this.pitchDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // pitchIncreaseHotkey
            // 
            this.pitchIncreaseHotkey.Location = new System.Drawing.Point(93, 50);
            this.pitchIncreaseHotkey.Name = "pitchIncreaseHotkey";
            this.pitchIncreaseHotkey.ReadOnly = true;
            this.pitchIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.pitchIncreaseHotkey.TabIndex = 5;
            this.pitchIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Decrease Key:";
            // 
            // lblPitchIncrease
            // 
            this.lblPitchIncrease.AutoSize = true;
            this.lblPitchIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitchIncrease.Location = new System.Drawing.Point(12, 50);
            this.lblPitchIncrease.Name = "lblPitchIncrease";
            this.lblPitchIncrease.Size = new System.Drawing.Size(80, 15);
            this.lblPitchIncrease.TabIndex = 3;
            this.lblPitchIncrease.Text = "Increase Key:";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitch.Location = new System.Drawing.Point(11, 30);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(48, 20);
            this.lblPitch.TabIndex = 2;
            this.lblPitch.Text = "Pitch:";
            ///
            rolling += 45;

            // 
            // yawDecreaseHotkey
            // 
            this.yawDecreaseHotkey.Location = new System.Drawing.Point(291, 50+rolling);
            this.yawDecreaseHotkey.Name = "yawDecreaseHotkey";
            this.yawDecreaseHotkey.ReadOnly = true;
            this.yawDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.yawDecreaseHotkey.TabIndex = 11;
            this.yawDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // yawIncreaseHotkey
            // 
            this.yawIncreaseHotkey.Location = new System.Drawing.Point(93, 50+rolling);
            this.yawIncreaseHotkey.Name = "yawIncreaseHotkey";
            this.yawIncreaseHotkey.ReadOnly = true;
            this.yawIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.yawIncreaseHotkey.TabIndex = 10;
            this.yawIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 50+rolling);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Decrease Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50+rolling);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Increase Key:";
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaw.Location = new System.Drawing.Point(11, 30+rolling);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(44, 20);
            this.lblYaw.TabIndex = 7;
            this.lblYaw.Text = "Yaw:";

            rolling += 45;

            // 
            // cameraHeightDecreaseHotkey
            // 
            this.cameraHeightDecreaseHotkey.Location = new System.Drawing.Point(291, 50+rolling);
            this.cameraHeightDecreaseHotkey.Name = "cameraHeightDecreaseHotkey";
            this.cameraHeightDecreaseHotkey.ReadOnly = true;
            this.cameraHeightDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.cameraHeightDecreaseHotkey.TabIndex = 16;
            this.cameraHeightDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // cameraHeightIncreaseHotkey
            // 
            this.cameraHeightIncreaseHotkey.Location = new System.Drawing.Point(93, 50+rolling);
            this.cameraHeightIncreaseHotkey.Name = "cameraHeightIncreaseHotkey";
            this.cameraHeightIncreaseHotkey.ReadOnly = true;
            this.cameraHeightIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.cameraHeightIncreaseHotkey.TabIndex = 15;
            this.cameraHeightIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 50+rolling);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Decrease Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 50+rolling);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Increase Key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 30+rolling);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Camera Height:";

            rolling += 45;

            // 
            // speedDecreaseHotkey
            // 
            this.speedDecreaseHotkey.Location = new System.Drawing.Point(292, 50+rolling);
            this.speedDecreaseHotkey.Name = "speedDecreaseHotkey";
            this.speedDecreaseHotkey.ReadOnly = true;
            this.speedDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.speedDecreaseHotkey.TabIndex = 21;
            this.speedDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // speedIncreaseHotkey
            // 
            this.speedIncreaseHotkey.Location = new System.Drawing.Point(94, 50+rolling);
            this.speedIncreaseHotkey.Name = "speedIncreaseHotkey";
            this.speedIncreaseHotkey.ReadOnly = true;
            this.speedIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.speedIncreaseHotkey.TabIndex = 20;
            this.speedIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 50+rolling);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Decrease Key:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 50+rolling);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Increase Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 30+rolling);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Speed:";

            rolling += 45;

            // 
            // drawDistanceDecreaseHotkey
            // 
            this.drawDistanceDecreaseHotkey.Location = new System.Drawing.Point(291, 50+rolling);
            this.drawDistanceDecreaseHotkey.Name = "drawDistanceDecreaseHotkey";
            this.drawDistanceDecreaseHotkey.ReadOnly = true;
            this.drawDistanceDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.drawDistanceDecreaseHotkey.TabIndex = 26;
            this.drawDistanceDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            this.restoreDefaultsHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // drawDistanceIncreaseHotkey
            // 
            this.drawDistanceIncreaseHotkey.Location = new System.Drawing.Point(93, 50+rolling);
            this.drawDistanceIncreaseHotkey.Name = "drawDistanceIncreaseHotkey";
            this.drawDistanceIncreaseHotkey.ReadOnly = true;
            this.drawDistanceIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.drawDistanceIncreaseHotkey.TabIndex = 25;
            this.drawDistanceIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(199, 50+rolling);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Decrease Key:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 50+rolling);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Increase Key:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 30+rolling);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Draw Distance:";

            rolling += 45;

            /// --- fov --- ///
            this.fovDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.fovIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.fovIncLabel       = new System.Windows.Forms.Label();
            this.fovDecLabel       = new System.Windows.Forms.Label();
            this.fovTitleLabel     = new System.Windows.Forms.Label();

            this.tabHotkeys.Controls.Add(this.fovDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.fovIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.fovIncLabel);
            this.tabHotkeys.Controls.Add(this.fovDecLabel);
            this.tabHotkeys.Controls.Add(this.fovTitleLabel);
            // fov decrease hotkey
            //
            this.fovDecreaseHotkey.Location = new System.Drawing.Point(291, 50+rolling);
            this.fovDecreaseHotkey.Name = "fovDecreaseHotkey";
            this.fovDecreaseHotkey.ReadOnly = true;
            this.fovDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.fovDecreaseHotkey.TabIndex = 26;
            this.fovDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            this.restoreDefaultsHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // fov increase hotkey
            //
            this.fovIncreaseHotkey.Location = new System.Drawing.Point(93, 50+rolling);
            this.fovIncreaseHotkey.Name = "fovIncreaseHotkey";
            this.fovIncreaseHotkey.ReadOnly = true;
            this.fovIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.fovIncreaseHotkey.TabIndex = 25;
            this.fovIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // fovDecLabel
            // 
            this.fovDecLabel.AutoSize = true;
            this.fovDecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovDecLabel.Location = new System.Drawing.Point(199, 50+rolling);
            this.fovDecLabel.Name = "fovDecLabel";
            this.fovDecLabel.Size = new System.Drawing.Size(86, 15);
            this.fovDecLabel.TabIndex = 24;
            this.fovDecLabel.Text = "Decrease Key:";
            // 
            // fovIncLabel
            // 
            this.fovIncLabel.AutoSize = true;
            this.fovIncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovIncLabel.Location = new System.Drawing.Point(12, 50+rolling);
            this.fovIncLabel.Name = "fovIncLabel";
            this.fovIncLabel.Size = new System.Drawing.Size(80, 15);
            this.fovIncLabel.TabIndex = 23;
            this.fovIncLabel.Text = "Increase Key:";
            // 
            // fovTitleLabel
            // 
            this.fovTitleLabel.AutoSize = true;
            this.fovTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovTitleLabel.Location = new System.Drawing.Point(11, 30+rolling);
            this.fovTitleLabel.Name = "fovTitleLabel";
            this.fovTitleLabel.Size = new System.Drawing.Size(117, 20);
            this.fovTitleLabel.TabIndex = 22;
            this.fovTitleLabel.Text = "Field of View:";
            /// --- end fov --- ///

            rolling += 45;
            /*
            /// --- zoom --- ///
            this.zoomDecreaseHotkey = new System.Windows.Forms.TextBox();
            this.zoomIncreaseHotkey = new System.Windows.Forms.TextBox();
            this.zoomIncLabel       = new System.Windows.Forms.Label();
            this.zoomDecLabel       = new System.Windows.Forms.Label();
            this.zoomTitleLabel     = new System.Windows.Forms.Label();
            
            this.tabHotkeys.Controls.Add(this.zoomDecreaseHotkey);
            this.tabHotkeys.Controls.Add(this.zoomIncreaseHotkey);
            this.tabHotkeys.Controls.Add(this.zoomIncLabel);
            this.tabHotkeys.Controls.Add(this.zoomDecLabel);
            this.tabHotkeys.Controls.Add(this.zoomTitleLabel);
            // zoom decrease hotkey
            //
            this.zoomDecreaseHotkey.Location = new System.Drawing.Point(291, 50+rolling);
            this.zoomDecreaseHotkey.Name = "zoomDecreaseHotkey";
            this.zoomDecreaseHotkey.ReadOnly = true;
            this.zoomDecreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.zoomDecreaseHotkey.TabIndex = 26;
            this.zoomDecreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            this.restoreDefaultsHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // zoom increase hotkey
            //
            this.zoomIncreaseHotkey.Location = new System.Drawing.Point(93, 50+rolling);
            this.zoomIncreaseHotkey.Name = "zoomIncreaseHotkey";
            this.zoomIncreaseHotkey.ReadOnly = true;
            this.zoomIncreaseHotkey.Size = new System.Drawing.Size(100, 20);
            this.zoomIncreaseHotkey.TabIndex = 25;
            this.zoomIncreaseHotkey.DoubleClick += new System.EventHandler(this.HandleHotkey);
            // 
            // zoomDecLabel
            // 
            this.zoomDecLabel.AutoSize = true;
            this.zoomDecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomDecLabel.Location = new System.Drawing.Point(199, 50+rolling);
            this.zoomDecLabel.Name = "zoomDecLabel";
            this.zoomDecLabel.Size = new System.Drawing.Size(86, 15);
            this.zoomDecLabel.TabIndex = 24;
            this.zoomDecLabel.Text = "Decrease Key:";
            // 
            // zoomIncLabel
            // 
            this.zoomIncLabel.AutoSize = true;
            this.zoomIncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomIncLabel.Location = new System.Drawing.Point(12, 50+rolling);
            this.zoomIncLabel.Name = "zoomIncLabel";
            this.zoomIncLabel.Size = new System.Drawing.Size(80, 15);
            this.zoomIncLabel.TabIndex = 23;
            this.zoomIncLabel.Text = "Increase Key:";
            // 
            // zoomTitleLabel
            // 
            this.zoomTitleLabel.AutoSize = true;
            this.zoomTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomTitleLabel.Location = new System.Drawing.Point(11, 30+rolling);
            this.zoomTitleLabel.Name = "zoomTitleLabel";
            this.zoomTitleLabel.Size = new System.Drawing.Size(117, 20);
            this.zoomTitleLabel.TabIndex = 22;
            this.zoomTitleLabel.Text = "Zoom:";
            /// --- end zoom --- ///
            rolling += 45;
            */

            // 
            // lblHotkeys
            // 
            this.lblHotkeys.AutoSize = true;
            this.lblHotkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeys.Location = new System.Drawing.Point(8, 0);
            this.lblHotkeys.Name = "lblHotkeys";
            this.lblHotkeys.Size = new System.Drawing.Size(84, 24);
            this.lblHotkeys.TabIndex = 1;
            this.lblHotkeys.Text = "Hotkeys";
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add(this.addressView);
            this.tabDebug.Location = new System.Drawing.Point(4, 22);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Size = new System.Drawing.Size(416, 297);
            this.tabDebug.TabIndex = 0;
            this.tabDebug.Text = "Debug Information";
            this.tabDebug.UseVisualStyleBackColor = true;
            // 
            // addressView
            // 
            this.addressView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressView.Enabled = false;
            this.addressView.Location = new System.Drawing.Point(0, 0);
            this.addressView.Multiline = true;
            this.addressView.Name = "addressView";
            this.addressView.ReadOnly = true;
            this.addressView.Size = new System.Drawing.Size(416, 297);
            this.addressView.TabIndex = 3;
            this.addressView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(185, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Restore Defaults:";
            // 
            // restoreDefaultsHotkey
            // 
            this.restoreDefaultsHotkey.Location = new System.Drawing.Point(291, 4);
            this.restoreDefaultsHotkey.Name = "restoreDefaultsHotkey";
            this.restoreDefaultsHotkey.ReadOnly = true;
            this.restoreDefaultsHotkey.Size = new System.Drawing.Size(100, 20);
            this.restoreDefaultsHotkey.TabIndex = 29;
            // 
            // LoLCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // size resolution blah blah
            this.ClientSize = new System.Drawing.Size(424, 66+rolling);
            this.Controls.Add(this.tabControlView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoLCamera";
            this.Text = "SkinSpotlights LoL Camera";
            this.Load += new System.EventHandler(this.LoLCamera_Load);
            this.tabControlView.ResumeLayout(false);
            this.tabHotkeys.ResumeLayout(false);
            this.tabHotkeys.PerformLayout();
            this.tabDebug.ResumeLayout(false);
            this.tabDebug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlView;
        private System.Windows.Forms.TabPage tabHotkeys;
        private System.Windows.Forms.TabPage tabDebug;
        private System.Windows.Forms.TextBox addressView;
        private System.Windows.Forms.Label lblHotkeys;
        private System.Windows.Forms.TextBox pitchDecreaseHotkey;
        private System.Windows.Forms.TextBox pitchIncreaseHotkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPitchIncrease;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.TextBox drawDistanceDecreaseHotkey;
        private System.Windows.Forms.TextBox drawDistanceIncreaseHotkey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox speedDecreaseHotkey;
        private System.Windows.Forms.TextBox speedIncreaseHotkey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cameraHeightDecreaseHotkey;
        private System.Windows.Forms.TextBox cameraHeightIncreaseHotkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yawDecreaseHotkey;
        private System.Windows.Forms.TextBox yawIncreaseHotkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYaw;
        private System.Windows.Forms.TextBox restoreDefaultsHotkey;
        private System.Windows.Forms.Label label14;
        // fov
        private System.Windows.Forms.TextBox fovDecreaseHotkey;
        private System.Windows.Forms.TextBox fovIncreaseHotkey;
        private System.Windows.Forms.Label fovIncLabel;
        private System.Windows.Forms.Label fovDecLabel;
        private System.Windows.Forms.Label fovTitleLabel;
        // zoom
        /*
        private System.Windows.Forms.TextBox zoomDecreaseHotkey;
        private System.Windows.Forms.TextBox zoomIncreaseHotkey;
        private System.Windows.Forms.Label zoomIncLabel;
        private System.Windows.Forms.Label zoomDecLabel;
        private System.Windows.Forms.Label zoomTitleLabel;
        */

    }
}

