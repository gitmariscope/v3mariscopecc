using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testform.models;

namespace testform
{
    public partial class fSetCam1 : Form
    {
        camera cam1 = new camera();
        
        public fSetCam1()
        {
            InitializeComponent();
            cam1.ip_server= "http://192.168.2.251";
            cam1.user     = "root";
            cam1.password = "admin";
            
        }

        private void btnSaveOverCam1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveStrCam1_Click(object sender, EventArgs e)
        {
            //Creacion de Objeto Form fCam1
            fCam1 fc1 = new fCam1();
            fc1.AMCfcam1.Stop();
            cam1.resolucion = txtcam1resolution.Text;
            cam1.compression = lblCompression.Text;
            string url_cam1= cam1.ip_server + "/axis-cgi/mjpg/video.cgi?resolution=" + txtcam1resolution.Text + 
                              "&compression=" + lblCompression.Text + "&camera=1";
            fc1.AMCfcam1.MediaURL = url_cam1;
            fc1.AMCfcam1.MediaType = "MJPG";

            fc1.AMCfcam1.Play();
        }

        private void trkbcam1Compression_Scroll(object sender, EventArgs e)
        {
            lblCompression.Text = trkbcam1Compression.Value.ToString();
        }
    }
}
