using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testform.models
{
    public class camera
    {
        #region stream
        public string ip_server { get; set; }
        public string nombre_camara { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string resolucion { get; set; }
        public string compression { get; set; }
        #endregion stream

        #region image
        public string brightness { get; set; }
        public string contrast { get; set; }
        public string saturation { get; set; }
        public string whiteBalance { get; set; }
        public string exposureControl { get; set; }
        public string exposureZone { get; set; }
        public string exposureValue { get; set; }
        public string maxShutter { get; set; }
        public string maxGain { get; set; }
        #endregion image

        #region overlay
        public string overlayText { get; set; }
        public string backgroundColor { get; set; }
        public string placeText { get; set; }
        public string colorText { get; set; }
        public string Date { get; set; } //comando camara '%D'
        public string Time { get; set; } //comando camara '%T'
        #endregion overlay   
        
    }



}
