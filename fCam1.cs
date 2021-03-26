﻿using System;
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
    public partial class fCam1 : Form
    {
        camera c = new camera();
        string serverpathCamera = Path.Combine("..\\..\\..\\testform\\", "json", "camara1.json");

        public fCam1()
        {
            InitializeComponent();
        }
        public void cargar_camara1()
        {
            string lastip;

            var sIniFile = File.ReadAllText(serverpathCamera);
            var jsonObj = JsonConvert.DeserializeObject<List<set_cam>>(sIniFile);
            var LastRegister = jsonObj.OrderByDescending(x => x.nombre_camara)
                                      .LastOrDefault().ip_camara;
            lastip = LastRegister.ToString();

            AMC1c1.Stop();
            //Inicio de camara al iniciar modulo setting camara   ||
            string url = "/axis-cgi/mjpg/video.cgi";
            string urlDef = $"http://{lastip}{url}";
            AMC1c1.MediaURL = urlDef;
            AMC1c1.MediaType = "MJPEG";
            AMC1c1.Play();
        }
        private void fCam1_Load(object sender, EventArgs e)
        {
            cargar_camara1();
        }


        private void btnRecord_Click(object sender, EventArgs e)
        {
            string DateAndTime = DateTime.Now.ToString("MM-dd-yyyy H.mm.ss");

            string folderVideo = @"C:\Mariscope\Camara1\Videos\";

            if (!Directory.Exists(folderVideo))
            {
                DirectoryInfo di = Directory.CreateDirectory(folderVideo);
            }

            string formato = ".asf";

            string dir = folderVideo + DateAndTime + formato;

            AMC1c1.StartRecordMedia(dir, 8, "0");
            btnRecord.Enabled = false;
            btnStop.Enabled = true;
            label1.ForeColor = Color.Red;
            label1.Visible = true;
            label1.Text = "Grabando ... ";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            AMC1c1.StopRecordMedia();
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
            if (btnStop.Enabled==false)
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Video Guardado";
            }
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Mariscope\Camara1\Imagenes\";
            string formato = ".jpg";
            string DateAndTime = DateTime.Now.ToString("MM-dd-yyyy H.mm.ss");

            string rutaDef = ruta + DateAndTime.ToString() + formato;
            if (!Directory.Exists(ruta))
            {
                DirectoryInfo di = Directory.CreateDirectory(ruta);
            }
            else
            {
                AMC1c1.SaveCurrentImage(0, rutaDef);

                if (File.Exists(rutaDef))
                {
                    AMC1c1.SaveCurrentImage(0, rutaDef);
                }
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = $"Captura Guardada : \n{DateAndTime + formato}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fSetCam1 f = new fSetCam1();
            f.Show();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Mariscope\Camara1\");
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            AMC1c1.FullScreen = true;
        }
    }
}
