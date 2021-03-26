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
using System.Net;
using System.IO;
using Newtonsoft.Json;



namespace testform
{
    public partial class fSetCam1 : Form
    {
        camera cam1 = new camera();
        string serverpathCamera = Path.Combine("..\\..\\..\\testform\\", "json", "camara1.json");

        
        public fSetCam1()
        {
            InitializeComponent();
            cargar_ultima_IP();
            cam1.ip_server = $"http://{ipAddressControl1.Text}";
            cam1.user      = "root";
            cam1.password  = "admin";
        }

        private void trkbcam1Compression_Scroll(object sender, EventArgs e)
        {
            lblCompression.Text = trkbcam1Compression.Value.ToString();
        }
        #region cargar_componentes
        public void cargar_componentes()
        {

            //===========LLENADO cbxREsolution==============
            cbxResolution.DisplayMember = "Text";
            cbxResolution.ValueMember = "Value";

            var itemsRes = new[] {
             new { Text = "1400x1050 (16:9)" , Value = "1400x1050" },
             new { Text = "1280x720 (16:9)"  , Value = "1280x960"  },
             new { Text = "1024x768 (4:3)"   , Value = "1024x768"  },
             new { Text = "800x600 (4:3)"    , Value = "800x600"   },
             new { Text = "640x480 (4:3)"    , Value = "640x480"   },
             new { Text = "480x360 (4:3)"    , Value = "480x360"   },
             new { Text = "320x240 (4:3)"    , Value = "320x240"   },
             new { Text = "240x180(4:3)"     , Value = "240x180"   },
             new { Text = "160x120 (4:3)"    , Value = "160x120"   },
             new { Text = "1920x1080 (16:9)" , Value = "1920x1080" },
             new { Text = "1280x720 (16:9)"  , Value = "1280x720"  },
             new { Text = "854x480 (16:9)"   , Value = "854x480"   },
             new { Text = "800x450 (16:9)"   , Value = "800x450"   },
             new { Text = "640x360 (16:9)"   , Value = "640x360"   },
             new { Text = "320x180 (16:9)"   , Value = "320x180"   },
             new { Text = "160x90 (16:9)"    , Value = "160x90"    },
            };

            cbxResolution.DataSource = itemsRes;
            //===========LLENADO cbxREsolution==============

            //------Llenado White Balance ------------
            cbxWhiteBalance.DisplayMember = "Text";
            cbxWhiteBalance.ValueMember = "Value";

            var itemsWB = new[] {
             new { Text = "Automatic" ,        Value = "auto" },
             new { Text = "Automatic Outdoor"  , Value = "auto_outdoor"  },
             new { Text = "Hold Current"  , Value = "hold"  },
             new { Text = "Fixed Outdoor 1"   , Value = "fixed_outdoor1"   },
             new { Text = "Fixed Outdoor 2"   , Value = "fixed_outdoor2"   },
             new { Text = "Fixed Indoor"   , Value = "fixed_indoor"   },
             new { Text = "Fixed Fluorescent 1"   , Value = "fixed_fluor1"   },
             new { Text = "Fixed Fluorescent 2"   , Value = "fixed_fluor2"   },
             new { Text = "Manual"   , Value = "manual"   },

            };
            cbxWhiteBalance.DataSource = itemsWB;
            //------Llenado  Llenado White Balance ------------

            //------Llenado Zone Exposure ------------
            cbxExposureZone.DisplayMember = "Text";
            cbxExposureZone.ValueMember = "Value";
            var itemsEZ = new[] {
             new { Text = "Auto"  , Value = "auto"},
             new { Text = "Right" , Value = "right"},
             new { Text = "Left"  , Value = "left"},
             new { Text = "Upper" , Value = "upper"},
             new { Text = "Lower" , Value = "lower"},
             new { Text = "Spot"  , Value = "spot"}
            };
            cbxExposureZone.DataSource = itemsEZ;
            //------Llenado Zone Exposure ------------

            //------Llenado Exposure Control ------------
            cbxExposureControl.DisplayMember = "Text";
            cbxExposureControl.ValueMember = "Value";
            var itemsEC = new[] {
             new { Text = "Automatic"  , Value = "auto"},
             new { Text = "Flicker-reduced 50 Hz" , Value = "flickerreduced50"},
             new { Text = "Flicker-reduced 60 Hz"  , Value = "flickerreduced60"},
             new { Text = "Hold current" , Value = "hold"}
            };
            cbxExposureControl.DataSource = itemsEC;
            //------Llenado Exposure Control ------------

            //------Llenado GAIN MAX ------------
            cbxMaxGain.DisplayMember = "Text";
            cbxMaxGain.ValueMember = "Value";
            var itemMG = new[] 
            {
                   new { Text = "0"   , Value = "0"},
                   new { Text = "3"   , Value = "8"},
                   new { Text = "6"   , Value = "17"},
                   new { Text = "9"   , Value = "25"},
                   new { Text = "12"  , Value = "33"},
                   new { Text = "15"  , Value = "42"},
                   new { Text = "18"  , Value = "50"},
                   new { Text = "21"  , Value = "58"},
                   new { Text = "24"  , Value = "67"},
                   new { Text = "27"  , Value = "75"},
                   new { Text = "30"  , Value = "83"},
                   new { Text = "33"  , Value = "92"},
                   new { Text = "36"  , Value = "100"},

            };
            cbxMaxGain.DataSource = itemMG;
            
            //------Llenado GAIN MAX ------------

            //------Llenado SHUTTER MAX ------------
            cbxMaxShutter.DisplayMember = "Text";
            cbxMaxShutter.ValueMember = "Value";
            var itemMS = new[] {
             new { Text = "1/30"   , Value = "33333"},
             new { Text = "1/25"   , Value = "40000"},
             new { Text = "1/15"   , Value = "66667"},
             new { Text = "1/12"   , Value = "83333"},
             new { Text = "1/10"   , Value = "100000"},
             new { Text = "1/6"    , Value = "166666"},
             new { Text = "1/5"    , Value = "200000"},
             new { Text = "1/4"    , Value = "250000"},
             new { Text = "1/2"    , Value = "500000"},
             new { Text = "1"      , Value = "1000000"},
             new { Text = "2"      , Value = "1965990"},
            };
            cbxMaxShutter.DataSource = itemMS;
            //------Llenado SHUTTER MAX ------------
        }
        #endregion cargar_componentes
        private void fSetCam1_Load(object sender, EventArgs e)
        {
            cargar_componentes();
            reset_default_settings();
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            AMCfcam1.Stop();

            cam1.resolucion = cbxResolution.SelectedValue.ToString();
            cam1.compression = lblCompression.Text;
            string url_cam1 = cam1.ip_server + "/axis-cgi/mjpg/video.cgi?resolution=" + cbxResolution.SelectedValue.ToString() +
                              "&compression=" + lblCompression.Text + "&camera=1";
            AMCfcam1.MediaURL = url_cam1;
            AMCfcam1.MediaType = "MJPG";

            //BRIGHTNESS 
            string urlBright = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.brightness=" +lblBright.Text;
            NetworkCredential networkCredential = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request = WebRequest.Create(urlBright);
            request.Credentials = networkCredential;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
            //FIN BRIGHTNESS 

            //CONTRAST
            string urlContrast = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.Contrast=" + lblContrast.Text;
            NetworkCredential networkCredential2 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request2 = WebRequest.Create(urlContrast);
            request2.Credentials = networkCredential2;
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            response2.Close();
            //FIN CONTRAST

            //SATURATION
            string urlSaturation = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.Colordesaturation=" + lblSaturation.Text;
            NetworkCredential networkCredential3 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request3 = WebRequest.Create(urlSaturation);
            request3.Credentials = networkCredential3;
            HttpWebResponse response3 = (HttpWebResponse)request3.GetResponse();
            response3.Close();
            //FIN SATURATION

            //SHARPNESS
            string urlSharpness = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.Sharpness=" + lblSharpness.Text;
            NetworkCredential networkCredential4 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request4 = WebRequest.Create(urlSharpness);
            request4.Credentials = networkCredential4;
            HttpWebResponse response4 = (HttpWebResponse)request4.GetResponse();
            response4.Close();
            //FIN SHARPNESS

            //WHITE BALANCE
            string urlWB = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.WhiteBalance=" + cbxWhiteBalance.SelectedValue.ToString();
            NetworkCredential networkCredential5 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request5 = WebRequest.Create(urlWB);
            request5.Credentials = networkCredential5;
            HttpWebResponse response5 = (HttpWebResponse)request5.GetResponse();
            response5.Close();
            //FIN WHITE BALANCE

            //EXPOSURE VALUE
            string urlEV = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.ExposureValue=" + lblExposureValue.Text;
            NetworkCredential networkCredential6 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request6 = WebRequest.Create(urlEV);
            request6.Credentials = networkCredential6;
            HttpWebResponse response6 = (HttpWebResponse)request6.GetResponse();
            response6.Close();
            //FIN EXPOSURE VALUE

            //Exposure zones
            string urlEZ = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.ExposureWindow=" + cbxExposureZone.SelectedValue.ToString();
            NetworkCredential networkCredential7 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request7 = WebRequest.Create(urlEZ);
            request7.Credentials = networkCredential7;
            HttpWebResponse response7 = (HttpWebResponse)request7.GetResponse();
            response7.Close();
            //FIN Exposure zones

            //Exposure Control
            string urlEC = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.Exposure=" + cbxExposureControl.SelectedValue.ToString();
            NetworkCredential networkCredential8 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request8 = WebRequest.Create(urlEC);
            request8.Credentials = networkCredential8;
            HttpWebResponse response8 = (HttpWebResponse)request8.GetResponse();
            response8.Close();
            //FIN Exposure Control

            // Gain max
            string urlShutterMAX = cam1.ip_server + "/axis-cgi/param.cgi?action=update&ImageSource.I0.Sensor.ManGainVal=" + cbxMaxGain.SelectedValue.ToString();
            NetworkCredential networkCredential9 = new NetworkCredential(cam1.user, cam1.password);
            WebRequest request9 = WebRequest.Create(urlShutterMAX);
            request9.Credentials = networkCredential9;
            HttpWebResponse response9 = (HttpWebResponse)request9.GetResponse();
            response9.Close();
            //FIN gain max


            //============OVERLAY TEXT ===================
            
            AMCfcam1.EnableOverlays = false;
            //string urlOver = $"{ip_server}/axis-cgi/param.cgi?action=update&Image.I0.Text.TextEnabled=yes&Image.I0.Text.String={txtOverlay.Text}&Image.I0.Text.Position={cbxPlaceText.Text}&Image.I0.Text.Color={cbxColorText.Text}&Image.I0.Text.BGColor={cbxBKcolor.Text}&camera=1";
            string urlOver = $"{cam1.ip_server}/axis-cgi/param.cgi?action=update&Image.I0.Text.TextEnabled=yes&Image.I0.Text.String={txtOverlay.Text}"+
                             $"&Image.I0.Text.Position={cbxPlaceText.Text}&Image.I0.Text.Color={cbxColorText.Text}&Image.I0.Text.BGColor={cbxBkgColor.Text}";
            NetworkCredential networkCredentialOverlay = new NetworkCredential(cam1.user, cam1.password);
            WebRequest requestOverlay = WebRequest.Create(urlOver);
            requestOverlay.Credentials = networkCredentialOverlay;
            HttpWebResponse responseOverlay = (HttpWebResponse)requestOverlay.GetResponse();
            responseOverlay.Close();
            
            //============OVERLAY TEXT ===================

            AMCfcam1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AMCfcam1.FullScreen=true;
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == true) { txtOverlay.Text += " %D"; }
            else { txtOverlay.Text = txtOverlay.Text.Replace("%D", string.Empty); }
        }

        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTime.Checked == true) { txtOverlay.Text += " %T"; }
            else { txtOverlay.Text = txtOverlay.Text.Replace("%T", string.Empty); }
        }

        private void tkbBrightness_Scroll(object sender, EventArgs e)
        {
            lblBright.Text = tkbBrightness.Value.ToString();
        }

        private void tkbContrast_Scroll(object sender, EventArgs e)
        {
            lblContrast.Text = tkbContrast.Value.ToString();
        }

        private void tkbSaturation_Scroll(object sender, EventArgs e)
        {
            lblSaturation.Text = tkbSaturation.Value.ToString();
        }

        private void tkbSharpness_Scroll(object sender, EventArgs e)
        {
            lblSharpness.Text = tkbSharpness.Value.ToString();
        }

        private void tkbExposureValue_Scroll(object sender, EventArgs e)
        {
            lblExposureValue.Text = tkbExposureValue.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            reset_default_settings();
        }
        public void reset_default_settings()
        {
            tkbBrightness.Value = 50;
            lblBright.Text = tkbBrightness.Value.ToString();
            tkbContrast.Value = 50;
            lblContrast.Text = tkbBrightness.Value.ToString();
            tkbSaturation.Value = 50;
            lblSaturation.Text = tkbSaturation.Value.ToString();
            tkbSharpness.Value = 50;
            lblSharpness.Text = tkbSharpness.Value.ToString();
            tkbExposureValue.Value = 50;
            lblExposureValue.Text = tkbExposureValue.Value.ToString();
            trkbcam1Compression.Value = 30;
            lblCompression.Text = trkbcam1Compression.Value.ToString();

            txtOverlay.Text = "Mariscope Ingeniería";
            cbxBkgColor.SelectedIndex = 1;
            cbxPlaceText.SelectedIndex = 0;
            cbxColorText.SelectedIndex = 0;
            chkDate.Checked = false;
            chkTime.Checked = false;
            //cbxResolution.SelectedIndex = 9;
            cbxWhiteBalance.SelectedIndex = 0;
            cbxExposureZone.SelectedIndex = 0;
            cbxExposureControl.SelectedIndex = 0;
            cbxMaxShutter.SelectedIndex = 0;
            cbxMaxGain.SelectedIndex = 12;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOverlay.Clear();
            txtOverlay.Focus();
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
              string nombrecam = "Camara1";
              var ip_camera = new set_cam()
              {
                  ip_camara =  ipAddressControl1.Text, 
                  nombre_camara = nombrecam 
              };
              var sIniFile = File.ReadAllText(serverpathCamera);
              var cameraDes = JsonConvert.DeserializeObject<List<set_cam>>(sIniFile);
              if (cameraDes == null)
              cameraDes = new List<set_cam>();
              cameraDes.Add(ip_camera);
              string datosJson = JsonConvert.SerializeObject(cameraDes);
              File.WriteAllText(serverpathCamera, datosJson);
              MessageBox.Show($"Direccion '{ ipAddressControl1.Text}' guardada.", "Dirección IP Guardada",MessageBoxButtons.OK);
              
            
        }

        public void cargar_ultima_IP()
        {
            //Se cargan ultima registro de IP 
            var sIniFile = File.ReadAllText(serverpathCamera);
            var jsonObj = JsonConvert.DeserializeObject<List<set_cam>>(sIniFile);
            var LastRegister = jsonObj.OrderByDescending(x => x.nombre_camara)
                                      .LastOrDefault().ip_camara;
            ipAddressControl1.Text = LastRegister.ToString();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (ipAddressControl1.Text == "...")
            {
                MessageBox.Show("IP no ingresada");
            }
            else
            { 
                AMCfcam1.Stop();
                //Inicio de camara al iniciar modulo setting camara   ||
                string url = "/axis-cgi/mjpg/video.cgi";
                string urlDef = $"http://{ipAddressControl1.Text}{url}";
                AMCfcam1.MediaURL = urlDef;
                AMCfcam1.MediaType = "MJPEG";
                AMCfcam1.Play();
                reset_default_settings();
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            ToolTip tt = new ToolTip();

            tt.Show("Guardar Valores", btnGuardar);
            tt.SetToolTip(btnRestablecer, "Restablecer Valores de Fábrica");
        }
    }
}
