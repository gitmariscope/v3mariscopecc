using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testform
{
    public partial class FormMain : Form
    {

        private FormROV formrov;
        private fSetCam1 fcs1; 
        private fSetCam2 fcs2;
        private fSetCam3 fcs3;
        private fCam1 fc1;
        private fCam2 fc2;
        private fCam3 fc3;


        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeMCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MCC Mariscope Command Center \n, MCC Mariscope Command Center", "Ayuda Mariscope Ingeniería");
        }
        private void setupROVControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formrov == null)
            {
                formrov = new FormROV();
                formrov.MdiParent = this;
                formrov.FormClosed += new FormClosedEventHandler(CloseForm);
                formrov.Show();
            }
            else
            {
                formrov.Activate(); 
            }

        }
        void CloseForm(object sender, FormClosedEventArgs e)
        {
            formrov = null;
            fc1 = null;
            fc2 = null;
            fc3 = null;
            fcs1 = null;
            fcs2 = null;
            fcs3 = null;
        }

        private void camara1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fcs1 == null)
            {
                fcs1 = new fSetCam1();
                fcs1.MdiParent = this;
                fcs1.FormClosed += new FormClosedEventHandler(CloseForm);
                fcs1.Show();
            }
            else {
                fcs1.Activate();
            }
        }

        private void camara2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fcs2 == null)
            {
                fcs2 = new fSetCam2();
                fcs2.MdiParent = this;
                fcs2.FormClosed += new FormClosedEventHandler(CloseForm);
                fcs2.Show();
            }
            else
            {
                fcs2.Activate();
            }
        }

        private void camara3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fcs3 == null)
            {
                fcs3 = new fSetCam3();
                fcs3.MdiParent = this;
                fcs3.FormClosed += new FormClosedEventHandler(CloseForm);
                fcs3.Show();
            }
            else
            {
                fcs3.Activate();
            }
        }

        private void camara1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fc1 == null)
            {
                fc1 = new fCam1();
                fc1.MdiParent = this;
                fc1.FormClosed += new FormClosedEventHandler(CloseForm);
                fc1.Show();
            }
            else
            {
                fc1.Activate();
            }
        }

        private void camaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cámara2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fc2 == null)
            {
                fc2 = new fCam2();
                fc2.MdiParent = this;
                fc2.FormClosed += new FormClosedEventHandler(CloseForm);
                fc2.Show();
            }
            else
            {
                fc2.Activate();
            }
        }

        private void cámara3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fc3 == null)
            {
                fc3 = new fCam3();
                fc3.MdiParent = this;
                fc3.FormClosed += new FormClosedEventHandler(CloseForm);
                fc3.Show();
            }
            else
            {
                fc3.Activate();
            }
        }

        private void comunicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        //private void abrirForms(string camera)
        //{
        //    if (camera == null)
        //    {
        //        camera = new fCamera1();
        //        camera.MdiParent = this;
        //        camera.FormClosed += new FormClosedEventHandler(CloseForm);
        //        camera.Show();
        //    }
        //    else
        //    {
        //        camera.Activate();
        //    }
        //}
    }
}
