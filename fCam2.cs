using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testform.models;
using System.Diagnostics;

namespace testform
{
    public partial class fCam2 : Form
    {
        public fCam2()
        {
            InitializeComponent();
        }

        string serverpathCamera = Path.Combine("..\\..\\..\\testform\\", "json", "camara2.json");

        private void btnRecord_Click_1(object sender, EventArgs e)
        {
            string DateAndTime = DateTime.Now.ToString("MM-dd-yyyy H.mm.ss");

            string folderVideo = @"C:\Mariscope\Camara2\Videos\";

            if (!Directory.Exists(folderVideo))
            {
                DirectoryInfo di = Directory.CreateDirectory(folderVideo);
            }

            string formato = ".asf";

            string dir = folderVideo + DateAndTime + formato;

            AMCfcam2.StartRecordMedia(dir, 8, "0");
            btnRecord.Enabled = false;
            btnStop.Enabled = true;
            label1.ForeColor = Color.Red;
            label1.Visible = true;
            label1.Text = "Grabando ... ";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            AMCfcam2.StopRecordMedia();
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
            if (btnStop.Enabled == false)
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Video Guardado";
            }
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Mariscope\Camara2\Imagenes\";
            string formato = ".jpg";
            string DateAndTime = DateTime.Now.ToString("MM-dd-yyyy H.mm.ss");

            string rutaDef = ruta + DateAndTime.ToString() + formato;
            if (!Directory.Exists(ruta))
            {
                DirectoryInfo di = Directory.CreateDirectory(ruta);
            }
            else
            {
                AMCfcam2.SaveCurrentImage(0, rutaDef);

                if (File.Exists(rutaDef))
                {
                    AMCfcam2.SaveCurrentImage(0, rutaDef);
                }
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = $"Captura Guardada : \n{DateAndTime + formato}";
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            AMCfcam2.FullScreen = true;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Mariscope\Camara2\");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fSetCam2 f = new fSetCam2();
            f.Show();
        }

        private void fCam2_Load(object sender, EventArgs e)
        {
            cargar_camara2();
        }

        public void cargar_camara2()
        {
            string lastip;

            var sIniFile = File.ReadAllText(serverpathCamera);
            var jsonObj = JsonConvert.DeserializeObject<List<set_cam>>(sIniFile);
            var LastRegister = jsonObj.OrderByDescending(x => x.nombre_camara)
                                      .LastOrDefault().ip_camara;
            lastip = LastRegister.ToString();

            AMCfcam2.Stop();
            //Inicio de camara al iniciar modulo setting camara   ||
            string url = "/axis-cgi/mjpg/video.cgi";
            string urlDef = $"http://{lastip}{url}";
            AMCfcam2.MediaURL = urlDef;
            AMCfcam2.MediaType = "MJPEG";
            AMCfcam2.Play();
        }
    }
}
