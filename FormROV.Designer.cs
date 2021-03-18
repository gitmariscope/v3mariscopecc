
namespace testform
{
    partial class FormROV
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
            this.components = new System.ComponentModel.Container();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.lblPortsOk = new System.Windows.Forms.Label();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusCOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLuces = new System.Windows.Forms.Label();
            this.gbPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.lblPortsOk);
            this.gbPortSettings.Controls.Add(this.cbxBaudrate);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cbxPorts);
            this.gbPortSettings.Controls.Add(this.btnConectar);
            this.gbPortSettings.Location = new System.Drawing.Point(12, 12);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(514, 55);
            this.gbPortSettings.TabIndex = 33;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "Serial Port &Settings";
            // 
            // lblPortsOk
            // 
            this.lblPortsOk.AutoSize = true;
            this.lblPortsOk.Location = new System.Drawing.Point(11, 19);
            this.lblPortsOk.Name = "lblPortsOk";
            this.lblPortsOk.Size = new System.Drawing.Size(55, 13);
            this.lblPortsOk.TabIndex = 37;
            this.lblPortsOk.Text = "lblPortsOk";
            this.lblPortsOk.Visible = false;
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudrate.Location = new System.Drawing.Point(159, 22);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(86, 21);
            this.cbxBaudrate.TabIndex = 36;
            this.cbxBaudrate.Text = "115200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Baud Rate:";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(251, 27);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // cbxPorts
            // 
            this.cbxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(310, 22);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(86, 21);
            this.cbxPorts.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConectar.Location = new System.Drawing.Point(402, 21);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(101, 24);
            this.btnConectar.TabIndex = 31;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLuces);
            this.groupBox1.Controls.Add(this.lblPosicion);
            this.groupBox1.Controls.Add(this.lbltest);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 395);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recepción de datos";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(11, 28);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(35, 13);
            this.lblPosicion.TabIndex = 37;
            this.lblPosicion.Text = "label2";
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(11, 55);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(35, 13);
            this.lbltest.TabIndex = 36;
            this.lbltest.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(14, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(820, 303);
            this.listBox1.TabIndex = 35;
            // 
            // SpPuertos
            // 
            this.SpPuertos.BaudRate = 115200;
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SpPuertos_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusCOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusCOM
            // 
            this.tsStatusCOM.Name = "tsStatusCOM";
            this.tsStatusCOM.Size = new System.Drawing.Size(76, 17);
            this.tsStatusCOM.Text = "tsStatusCOM";
            this.tsStatusCOM.Visible = false;
            // 
            // lblLuces
            // 
            this.lblLuces.AutoSize = true;
            this.lblLuces.Location = new System.Drawing.Point(118, 28);
            this.lblLuces.Name = "lblLuces";
            this.lblLuces.Size = new System.Drawing.Size(32, 13);
            this.lblLuces.TabIndex = 38;
            this.lblLuces.Text = "luces";
            // 
            // FormROV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPortSettings);
            this.Name = "FormROV";
            this.Text = "Settings ROV ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormROV_FormClosing);
            this.Load += new System.EventHandler(this.FormROV_Load);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.Label lblPortsOk;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusCOM;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblLuces;
    }
}