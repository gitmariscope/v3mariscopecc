
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusCOM = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.gbPortSettings.Size = new System.Drawing.Size(382, 86);
            this.gbPortSettings.TabIndex = 33;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "Serial Port &Settings";
            // 
            // lblPortsOk
            // 
            this.lblPortsOk.AutoSize = true;
            this.lblPortsOk.Location = new System.Drawing.Point(6, 27);
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
            this.cbxBaudrate.Location = new System.Drawing.Point(172, 51);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(86, 21);
            this.cbxBaudrate.TabIndex = 36;
            this.cbxBaudrate.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Baudrate:";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(110, 27);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // cbxPorts
            // 
            this.cbxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(175, 24);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(83, 21);
            this.cbxPorts.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(264, 21);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(101, 24);
            this.btnConectar.TabIndex = 31;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 306);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recepción de datos";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 277);
            this.listBox1.TabIndex = 35;
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SpPuertos_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusCOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusCOM
            // 
            this.tsStatusCOM.Name = "tsStatusCOM";
            this.tsStatusCOM.Size = new System.Drawing.Size(76, 17);
            this.tsStatusCOM.Text = "tsStatusCOM";
            this.tsStatusCOM.Visible = false;
            this.tsStatusCOM.Click += new System.EventHandler(this.tsStatusCOM_Click);
            // 
            // FormROV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 447);
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
    }
}