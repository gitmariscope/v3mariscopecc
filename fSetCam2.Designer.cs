﻿
namespace testform
{
    partial class fSetCam2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSetCam2));
            this.tabControlSetCam2 = new System.Windows.Forms.TabControl();
            this.Stream = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxResolution = new System.Windows.Forms.ComboBox();
            this.lblCompression = new System.Windows.Forms.Label();
            this.trkbcam1Compression = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblExposureValue = new System.Windows.Forms.Label();
            this.cbxMaxGain = new System.Windows.Forms.ComboBox();
            this.cbxMaxShutter = new System.Windows.Forms.ComboBox();
            this.cbxExposureZone = new System.Windows.Forms.ComboBox();
            this.cbxExposureControl = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tkbExposureValue = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxWhiteBalance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSharpness = new System.Windows.Forms.Label();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.lblContrast = new System.Windows.Forms.Label();
            this.lblBright = new System.Windows.Forms.Label();
            this.tkbSharpness = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tkbSaturation = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tkbContrast = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tkbBrightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Overlay = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxColorText = new System.Windows.Forms.ComboBox();
            this.cbxPlaceText = new System.Windows.Forms.ComboBox();
            this.cbxBkgColor = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOverlay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AMCfcam2 = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.tabControlSetCam2.SuspendLayout();
            this.Stream.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbcam1Compression)).BeginInit();
            this.Image.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbExposureValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).BeginInit();
            this.Overlay.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AMCfcam2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSetCam2
            // 
            this.tabControlSetCam2.Controls.Add(this.Stream);
            this.tabControlSetCam2.Controls.Add(this.Image);
            this.tabControlSetCam2.Controls.Add(this.Overlay);
            this.tabControlSetCam2.Location = new System.Drawing.Point(12, 12);
            this.tabControlSetCam2.Name = "tabControlSetCam2";
            this.tabControlSetCam2.SelectedIndex = 0;
            this.tabControlSetCam2.Size = new System.Drawing.Size(302, 379);
            this.tabControlSetCam2.TabIndex = 2;
            // 
            // Stream
            // 
            this.Stream.Controls.Add(this.groupBox1);
            this.Stream.Location = new System.Drawing.Point(4, 22);
            this.Stream.Name = "Stream";
            this.Stream.Padding = new System.Windows.Forms.Padding(3);
            this.Stream.Size = new System.Drawing.Size(294, 353);
            this.Stream.TabIndex = 0;
            this.Stream.Text = "Stream";
            this.Stream.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxResolution);
            this.groupBox1.Controls.Add(this.lblCompression);
            this.groupBox1.Controls.Add(this.trkbcam1Compression);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings Stream Camera 1";
            // 
            // cbxResolution
            // 
            this.cbxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolution.FormattingEnabled = true;
            this.cbxResolution.Location = new System.Drawing.Point(79, 92);
            this.cbxResolution.Name = "cbxResolution";
            this.cbxResolution.Size = new System.Drawing.Size(162, 21);
            this.cbxResolution.TabIndex = 5;
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Location = new System.Drawing.Point(247, 38);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(13, 13);
            this.lblCompression.TabIndex = 4;
            this.lblCompression.Text = "0";
            // 
            // trkbcam1Compression
            // 
            this.trkbcam1Compression.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trkbcam1Compression.Location = new System.Drawing.Point(78, 38);
            this.trkbcam1Compression.Maximum = 100;
            this.trkbcam1Compression.Name = "trkbcam1Compression";
            this.trkbcam1Compression.Size = new System.Drawing.Size(163, 45);
            this.trkbcam1Compression.TabIndex = 1;
            this.trkbcam1Compression.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkbcam1Compression.Scroll += new System.EventHandler(this.trkbcam1Compression_Scroll_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resolution";
            // 
            // Image
            // 
            this.Image.Controls.Add(this.groupBox4);
            this.Image.Controls.Add(this.groupBox3);
            this.Image.Controls.Add(this.groupBox2);
            this.Image.Location = new System.Drawing.Point(4, 22);
            this.Image.Name = "Image";
            this.Image.Padding = new System.Windows.Forms.Padding(3);
            this.Image.Size = new System.Drawing.Size(294, 353);
            this.Image.TabIndex = 1;
            this.Image.Text = "Image";
            this.Image.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblExposureValue);
            this.groupBox4.Controls.Add(this.cbxMaxGain);
            this.groupBox4.Controls.Add(this.cbxMaxShutter);
            this.groupBox4.Controls.Add(this.cbxExposureZone);
            this.groupBox4.Controls.Add(this.cbxExposureControl);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tkbExposureValue);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 157);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exposure Settings";
            // 
            // lblExposureValue
            // 
            this.lblExposureValue.AutoSize = true;
            this.lblExposureValue.Location = new System.Drawing.Point(247, 71);
            this.lblExposureValue.Name = "lblExposureValue";
            this.lblExposureValue.Size = new System.Drawing.Size(13, 13);
            this.lblExposureValue.TabIndex = 15;
            this.lblExposureValue.Text = "0";
            // 
            // cbxMaxGain
            // 
            this.cbxMaxGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaxGain.FormattingEnabled = true;
            this.cbxMaxGain.Location = new System.Drawing.Point(106, 127);
            this.cbxMaxGain.Name = "cbxMaxGain";
            this.cbxMaxGain.Size = new System.Drawing.Size(69, 21);
            this.cbxMaxGain.TabIndex = 24;
            // 
            // cbxMaxShutter
            // 
            this.cbxMaxShutter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaxShutter.FormattingEnabled = true;
            this.cbxMaxShutter.Location = new System.Drawing.Point(106, 103);
            this.cbxMaxShutter.Name = "cbxMaxShutter";
            this.cbxMaxShutter.Size = new System.Drawing.Size(69, 21);
            this.cbxMaxShutter.TabIndex = 23;
            // 
            // cbxExposureZone
            // 
            this.cbxExposureZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExposureZone.FormattingEnabled = true;
            this.cbxExposureZone.Location = new System.Drawing.Point(106, 44);
            this.cbxExposureZone.Name = "cbxExposureZone";
            this.cbxExposureZone.Size = new System.Drawing.Size(142, 21);
            this.cbxExposureZone.TabIndex = 22;
            // 
            // cbxExposureControl
            // 
            this.cbxExposureControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExposureControl.FormattingEnabled = true;
            this.cbxExposureControl.Location = new System.Drawing.Point(106, 19);
            this.cbxExposureControl.Name = "cbxExposureControl";
            this.cbxExposureControl.Size = new System.Drawing.Size(142, 21);
            this.cbxExposureControl.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Max Gain";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Max Shutter";
            // 
            // tkbExposureValue
            // 
            this.tkbExposureValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tkbExposureValue.Location = new System.Drawing.Point(85, 71);
            this.tkbExposureValue.Maximum = 100;
            this.tkbExposureValue.Name = "tkbExposureValue";
            this.tkbExposureValue.Size = new System.Drawing.Size(163, 45);
            this.tkbExposureValue.TabIndex = 11;
            this.tkbExposureValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbExposureValue.Scroll += new System.EventHandler(this.tkbExposureValue_Scroll_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Exposure Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Exposure Zone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Exposure Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxWhiteBalance);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 43);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "White Balance";
            // 
            // cbxWhiteBalance
            // 
            this.cbxWhiteBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWhiteBalance.FormattingEnabled = true;
            this.cbxWhiteBalance.Location = new System.Drawing.Point(106, 16);
            this.cbxWhiteBalance.Name = "cbxWhiteBalance";
            this.cbxWhiteBalance.Size = new System.Drawing.Size(142, 21);
            this.cbxWhiteBalance.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "White Balance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSharpness);
            this.groupBox2.Controls.Add(this.lblSaturation);
            this.groupBox2.Controls.Add(this.lblContrast);
            this.groupBox2.Controls.Add(this.lblBright);
            this.groupBox2.Controls.Add(this.tkbSharpness);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tkbSaturation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tkbContrast);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tkbBrightness);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Settings";
            // 
            // lblSharpness
            // 
            this.lblSharpness.AutoSize = true;
            this.lblSharpness.Location = new System.Drawing.Point(247, 94);
            this.lblSharpness.Name = "lblSharpness";
            this.lblSharpness.Size = new System.Drawing.Size(13, 13);
            this.lblSharpness.TabIndex = 14;
            this.lblSharpness.Text = "0";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.Location = new System.Drawing.Point(247, 70);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(13, 13);
            this.lblSaturation.TabIndex = 13;
            this.lblSaturation.Text = "0";
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Location = new System.Drawing.Point(247, 43);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(13, 13);
            this.lblContrast.TabIndex = 12;
            this.lblContrast.Text = "0";
            // 
            // lblBright
            // 
            this.lblBright.AutoSize = true;
            this.lblBright.Location = new System.Drawing.Point(247, 19);
            this.lblBright.Name = "lblBright";
            this.lblBright.Size = new System.Drawing.Size(13, 13);
            this.lblBright.TabIndex = 11;
            this.lblBright.Text = "0";
            // 
            // tkbSharpness
            // 
            this.tkbSharpness.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tkbSharpness.Location = new System.Drawing.Point(85, 94);
            this.tkbSharpness.Maximum = 100;
            this.tkbSharpness.Name = "tkbSharpness";
            this.tkbSharpness.Size = new System.Drawing.Size(163, 45);
            this.tkbSharpness.TabIndex = 9;
            this.tkbSharpness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbSharpness.Scroll += new System.EventHandler(this.tkbSharpness_Scroll_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sharpness";
            // 
            // tkbSaturation
            // 
            this.tkbSaturation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tkbSaturation.Location = new System.Drawing.Point(85, 70);
            this.tkbSaturation.Maximum = 100;
            this.tkbSaturation.Name = "tkbSaturation";
            this.tkbSaturation.Size = new System.Drawing.Size(163, 45);
            this.tkbSaturation.TabIndex = 7;
            this.tkbSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbSaturation.Scroll += new System.EventHandler(this.tkbSaturation_Scroll_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saturation";
            // 
            // tkbContrast
            // 
            this.tkbContrast.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tkbContrast.Location = new System.Drawing.Point(85, 43);
            this.tkbContrast.Maximum = 100;
            this.tkbContrast.Name = "tkbContrast";
            this.tkbContrast.Size = new System.Drawing.Size(163, 45);
            this.tkbContrast.TabIndex = 5;
            this.tkbContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbContrast.Scroll += new System.EventHandler(this.tkbContrast_Scroll_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contrast";
            // 
            // tkbBrightness
            // 
            this.tkbBrightness.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tkbBrightness.Location = new System.Drawing.Point(85, 19);
            this.tkbBrightness.Maximum = 100;
            this.tkbBrightness.Name = "tkbBrightness";
            this.tkbBrightness.Size = new System.Drawing.Size(163, 45);
            this.tkbBrightness.TabIndex = 3;
            this.tkbBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbBrightness.Scroll += new System.EventHandler(this.tkbBrightness_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brightness";
            // 
            // Overlay
            // 
            this.Overlay.Controls.Add(this.groupBox5);
            this.Overlay.Location = new System.Drawing.Point(4, 22);
            this.Overlay.Name = "Overlay";
            this.Overlay.Padding = new System.Windows.Forms.Padding(3);
            this.Overlay.Size = new System.Drawing.Size(294, 353);
            this.Overlay.TabIndex = 2;
            this.Overlay.Text = "Overlay";
            this.Overlay.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.cbxColorText);
            this.groupBox5.Controls.Add(this.cbxPlaceText);
            this.groupBox5.Controls.Add(this.cbxBkgColor);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.chkTime);
            this.groupBox5.Controls.Add(this.chkDate);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtOverlay);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 202);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Overlay Settings";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbxColorText
            // 
            this.cbxColorText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColorText.FormattingEnabled = true;
            this.cbxColorText.Items.AddRange(new object[] {
            "white",
            "black"});
            this.cbxColorText.Location = new System.Drawing.Point(100, 98);
            this.cbxColorText.Name = "cbxColorText";
            this.cbxColorText.Size = new System.Drawing.Size(113, 21);
            this.cbxColorText.TabIndex = 27;
            // 
            // cbxPlaceText
            // 
            this.cbxPlaceText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlaceText.FormattingEnabled = true;
            this.cbxPlaceText.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
            this.cbxPlaceText.Location = new System.Drawing.Point(100, 71);
            this.cbxPlaceText.Name = "cbxPlaceText";
            this.cbxPlaceText.Size = new System.Drawing.Size(113, 21);
            this.cbxPlaceText.TabIndex = 26;
            // 
            // cbxBkgColor
            // 
            this.cbxBkgColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBkgColor.FormattingEnabled = true;
            this.cbxBkgColor.Items.AddRange(new object[] {
            "white",
            "black",
            "transparent",
            "semitransparent"});
            this.cbxBkgColor.Location = new System.Drawing.Point(100, 45);
            this.cbxBkgColor.Name = "cbxBkgColor";
            this.cbxBkgColor.Size = new System.Drawing.Size(113, 21);
            this.cbxBkgColor.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Date and Time";
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(100, 146);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(87, 17);
            this.chkTime.TabIndex = 24;
            this.chkTime.Text = "Include Time";
            this.chkTime.UseVisualStyleBackColor = true;
            this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged_1);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(100, 123);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(87, 17);
            this.chkDate.TabIndex = 23;
            this.chkDate.Text = "Include Date";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Color Text";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Place Text";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Background Color";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Text";
            // 
            // txtOverlay
            // 
            this.txtOverlay.Location = new System.Drawing.Point(100, 19);
            this.txtOverlay.Name = "txtOverlay";
            this.txtOverlay.Size = new System.Drawing.Size(176, 20);
            this.txtOverlay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pantalla Completa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Valores Default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(16, 401);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(95, 37);
            this.btnSaveSetting.TabIndex = 8;
            this.btnSaveSetting.Text = "Guardar Cambios";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AMCfcam2);
            this.groupBox6.Location = new System.Drawing.Point(320, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(474, 426);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cámara 2";
            // 
            // AMCfcam2
            // 
            this.AMCfcam2.Enabled = true;
            this.AMCfcam2.Location = new System.Drawing.Point(6, 22);
            this.AMCfcam2.Name = "AMCfcam2";
            this.AMCfcam2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AMCfcam2.OcxState")));
            this.AMCfcam2.Size = new System.Drawing.Size(462, 398);
            this.AMCfcam2.TabIndex = 0;
            // 
            // fSetCam2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveSetting);
            this.Controls.Add(this.tabControlSetCam2);
            this.Name = "fSetCam2";
            this.Text = "Settings Camera 2";
            this.Load += new System.EventHandler(this.fSetCam2_Load);
            this.tabControlSetCam2.ResumeLayout(false);
            this.Stream.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbcam1Compression)).EndInit();
            this.Image.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbExposureValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).EndInit();
            this.Overlay.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AMCfcam2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSetCam2;
        private System.Windows.Forms.TabPage Stream;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbxResolution;
        public System.Windows.Forms.Label lblCompression;
        public System.Windows.Forms.TrackBar trkbcam1Compression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Image;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label lblExposureValue;
        public System.Windows.Forms.ComboBox cbxMaxGain;
        public System.Windows.Forms.ComboBox cbxMaxShutter;
        public System.Windows.Forms.ComboBox cbxExposureZone;
        public System.Windows.Forms.ComboBox cbxExposureControl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TrackBar tkbExposureValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cbxWhiteBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblSharpness;
        public System.Windows.Forms.Label lblSaturation;
        public System.Windows.Forms.Label lblContrast;
        public System.Windows.Forms.Label lblBright;
        public System.Windows.Forms.TrackBar tkbSharpness;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar tkbSaturation;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TrackBar tkbContrast;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TrackBar tkbBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Overlay;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox cbxColorText;
        public System.Windows.Forms.ComboBox cbxPlaceText;
        public System.Windows.Forms.ComboBox cbxBkgColor;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.CheckBox chkTime;
        public System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtOverlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.GroupBox groupBox6;
        public AxAXISMEDIACONTROLLib.AxAxisMediaControl AMCfcam2;
    }
}