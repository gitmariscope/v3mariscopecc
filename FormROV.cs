using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace testform
{
    public partial class FormROV : Form
    {

        private delegate void DelegadoAcceso(string accion);

        private string strBufferIn;
        private string strBufferOut;

        public FormROV()
        {
            InitializeComponent();
        }

        private void AccesoForm(string accion) 
        {
            strBufferIn = accion;
            //========================================
            txtBoxDatosSerialPort.Text = strBufferIn;
            //========================================

        }
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelagadoAcceso;
            Var_DelagadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            Invoke(Var_DelagadoAcceso, arg);

        }

        private void FormROV_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            btnConectar.Enabled = false;
            btnRecibirDatos.Enabled = false;
        }

        private void btnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            cbxPorts.Items.Clear();
            foreach(string puerto_simple in PuertosDisponibles)
            {
                cbxPorts.Items.Add(puerto_simple);
            }
            if (cbxPorts.Items.Count > 0)
            {
                cbxPorts.SelectedIndex = 0;
                MessageBox.Show("Seleccionar Puerto de Trabajo" ,"Seleccione Puerto");
                btnConectar.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Ningun Puerto Detectado", "Puerto No Detectado");
                cbxPorts.Items.Clear();
                cbxPorts.Text = "";
                strBufferIn = "";
                strBufferOut = "";
                btnConectar.Enabled = false;
                btnRecibirDatos.Enabled = false;
            }
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Text == "Conectar")
                {
                    
                    SpPuertos.BaudRate = Convert.ToInt32(cbxBaudrate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = cbxPorts.Text;
                    try
                    {
                        SpPuertos.Open();
                        btnConectar.Text = "Desconectar";
                        
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString()); ;
                    }
                 }
                else if (btnConectar.Text == "Desconectar")
                {
                    SpPuertos.Close();
                    btnConectar.Text = "Conectar"; 
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void SpPuertos_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(SpPuertos.ReadExisting());

            

            string message = SpPuertos.ReadLine();
            txtBoxDatosSerialPort.Text = message;

            //   string data_in = SpPuertos.ReadExisting();
            //   MessageBox.Show(data_in);
            //   txtBoxDatosSerialPort.Text = data_in;
        }
    }
}
