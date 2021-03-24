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
       
        private void fCam1_Load(object sender, EventArgs e)
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

    }
}
