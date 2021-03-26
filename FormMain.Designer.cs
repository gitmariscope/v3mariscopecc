
namespace testform
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cámara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cámara3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupIPCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camara3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupROVControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.camaraToolStripMenuItem,
            this.comunicacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCarpetaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // crearCarpetaToolStripMenuItem
            // 
            this.crearCarpetaToolStripMenuItem.Name = "crearCarpetaToolStripMenuItem";
            this.crearCarpetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearCarpetaToolStripMenuItem.Text = "Crear carpeta";
            this.crearCarpetaToolStripMenuItem.Click += new System.EventHandler(this.crearCarpetaToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ediciónToolStripMenuItem.Text = "Edición ";
            // 
            // camaraToolStripMenuItem
            // 
            this.camaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camara1ToolStripMenuItem1,
            this.cámara2ToolStripMenuItem,
            this.cámara3ToolStripMenuItem});
            this.camaraToolStripMenuItem.Name = "camaraToolStripMenuItem";
            this.camaraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.camaraToolStripMenuItem.Text = "Camara";
            this.camaraToolStripMenuItem.Click += new System.EventHandler(this.camaraToolStripMenuItem_Click);
            // 
            // camara1ToolStripMenuItem1
            // 
            this.camara1ToolStripMenuItem1.Name = "camara1ToolStripMenuItem1";
            this.camara1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.camara1ToolStripMenuItem1.Text = "Cámara 1";
            this.camara1ToolStripMenuItem1.Click += new System.EventHandler(this.camara1ToolStripMenuItem1_Click);
            // 
            // cámara2ToolStripMenuItem
            // 
            this.cámara2ToolStripMenuItem.Name = "cámara2ToolStripMenuItem";
            this.cámara2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cámara2ToolStripMenuItem.Text = "Cámara 2";
            this.cámara2ToolStripMenuItem.Click += new System.EventHandler(this.cámara2ToolStripMenuItem_Click);
            // 
            // cámara3ToolStripMenuItem
            // 
            this.cámara3ToolStripMenuItem.Name = "cámara3ToolStripMenuItem";
            this.cámara3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cámara3ToolStripMenuItem.Text = "Cámara 3";
            this.cámara3ToolStripMenuItem.Click += new System.EventHandler(this.cámara3ToolStripMenuItem_Click);
            // 
            // comunicacionesToolStripMenuItem
            // 
            this.comunicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupIPCamToolStripMenuItem,
            this.setupROVControlToolStripMenuItem});
            this.comunicacionesToolStripMenuItem.Name = "comunicacionesToolStripMenuItem";
            this.comunicacionesToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.comunicacionesToolStripMenuItem.Text = "Comunicaciones";
            // 
            // setupIPCamToolStripMenuItem
            // 
            this.setupIPCamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camara1ToolStripMenuItem,
            this.camara2ToolStripMenuItem,
            this.camara3ToolStripMenuItem});
            this.setupIPCamToolStripMenuItem.Name = "setupIPCamToolStripMenuItem";
            this.setupIPCamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setupIPCamToolStripMenuItem.Text = "Setup IP Cam";
            // 
            // camara1ToolStripMenuItem
            // 
            this.camara1ToolStripMenuItem.Name = "camara1ToolStripMenuItem";
            this.camara1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.camara1ToolStripMenuItem.Text = "Camera 1 ";
            this.camara1ToolStripMenuItem.Click += new System.EventHandler(this.camara1ToolStripMenuItem_Click);
            // 
            // camara2ToolStripMenuItem
            // 
            this.camara2ToolStripMenuItem.Name = "camara2ToolStripMenuItem";
            this.camara2ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.camara2ToolStripMenuItem.Text = "Camera 2";
            this.camara2ToolStripMenuItem.Click += new System.EventHandler(this.camara2ToolStripMenuItem_Click);
            // 
            // camara3ToolStripMenuItem
            // 
            this.camara3ToolStripMenuItem.Name = "camara3ToolStripMenuItem";
            this.camara3ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.camara3ToolStripMenuItem.Text = "Camera 3";
            this.camara3ToolStripMenuItem.Click += new System.EventHandler(this.camara3ToolStripMenuItem_Click);
            // 
            // setupROVControlToolStripMenuItem
            // 
            this.setupROVControlToolStripMenuItem.Name = "setupROVControlToolStripMenuItem";
            this.setupROVControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setupROVControlToolStripMenuItem.Text = "Setup ROV control";
            this.setupROVControlToolStripMenuItem.Click += new System.EventHandler(this.setupROVControlToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeMCCToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeMCCToolStripMenuItem
            // 
            this.acercaDeMCCToolStripMenuItem.Name = "acercaDeMCCToolStripMenuItem";
            this.acercaDeMCCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeMCCToolStripMenuItem.Text = "Acerca de MCC";
            this.acercaDeMCCToolStripMenuItem.Click += new System.EventHandler(this.acercaDeMCCToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 492);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCC (test)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupIPCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupROVControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camara1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cámara2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cámara3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

