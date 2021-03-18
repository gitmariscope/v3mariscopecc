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

        public delegate void DelegadoAcceso(string accion);
        public string strBufferIn;
        public string strBufferOut;

        public FormROV()
        {
            InitializeComponent();
        }
        private void AccesoForm(string accion)
        {
            strBufferIn = accion;

            while (strBufferIn.StartsWith("PC"))
            {
                string str = strBufferIn.Substring(0, 86);
                int n = Convert.ToInt32(str.Length);
                byte[] asciiBytes = Encoding.ASCII.GetBytes(strBufferIn);
                
                if (str.StartsWith("PC"))
                {
                    float ns = Convert.ToInt32(str[31]);
                    ns = (ns / 255) * 100;

                    lblLuces.Text = String.Join(" ", ns);
                    lbltest.Text = String.Join(" ", asciiBytes);
                    //listBox1.Items.Add(String.Join(" ", asciiBytes));
                   // lblPosicion.Text = String.Join("",asciiBytes[79]);
                    //listBox1.Items.Add(str);
                    //lblPosicion.Text = n.ToString();

                    // foreach (byte b in asciiBytes)
                    // {
                    //     listBox1.Items.Add("->" + b + " / ");
                    //     //lblTest.Text = b.ToString();
                    // }
                }
                else
                {
                    MessageBox.Show("error");
                }
                break;
            }
            // Convert the string into a byte[].
            //===========IMPRIMIR EN LISTBOX=====================
            // listBox1.Items.Add(String.Join("  ",asciiBytes));
            //===========IMPRIMIR EN LISTBOX=====================
            //  lblPosicion.Text = String.Join("",asciiBytes[79]);
            //========================================
        }
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelagadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            Invoke(Var_DelagadoAcceso, arg);

        }
        private void CargarPuertos() 
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            cbxPorts.Items.Clear();
            foreach (string puerto_simple in PuertosDisponibles)
            {
                cbxPorts.Items.Add(puerto_simple);
            }
            if (cbxPorts.Items.Count > 0)
            {
                cbxPorts.SelectedIndex = 0;
                lblPortsOk.Visible = true;
                lblPortsOk.Text = "Puertos\nEncontrados !";
                lblPortsOk.ForeColor = Color.Green;
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ningun Puerto Detectado", "Puerto No Detectado",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblPortsOk.Text = "Puertos\nNo Detectados";
                lblPortsOk.ForeColor = Color.Red;
                lblPortsOk.Visible = true;
                cbxPorts.Items.Clear();
                cbxPorts.Text = "";
                strBufferIn = "";
                strBufferOut = "";
                btnConectar.Enabled = false;
            }
        }

        private void FormROV_Load(object sender, EventArgs e)
        {
            strBufferIn  = "";
            strBufferOut = "";
            btnConectar.Enabled = false;
            CargarPuertos();
        }
       
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Text == "Conectar")
                {
                    SpPuertos.BaudRate  = Convert.ToInt32(cbxBaudrate.Text);
                    SpPuertos.DataBits  = 8;
                    SpPuertos.Parity    = Parity.None;
                    SpPuertos.StopBits  = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName  = cbxPorts.Text.ToString();
                    try
                    {
                        SpPuertos.Open();
                        tsStatusCOM.Visible = true;
                        tsStatusCOM.Text = " '"+ cbxPorts.SelectedItem.ToString() + "' Seleccionado." ; 
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
                    listBox1.Items.Clear();
                    tsStatusCOM.Visible = false;
                    btnConectar.Text = "Conectar";
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void SpPuertos_DataReceived(object sender, SerialDataReceivedEventArgs eventArgs)
        {
            if (SpPuertos.IsOpen)
            {
                //  SerialPort sp = (SerialPort)sender;
                AccesoInterrupcion(SpPuertos.ReadExisting());

            }
            else
            {
                MessageBox.Show("Error, el puerto COM no esta abierto");
            }
        }
        private void FormROV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SpPuertos.IsOpen)
            {
                DialogResult dialogo = MessageBox.Show("¿Desea salir de Settings ROV?\nSi cierra la ventana se cerraran todos los puertos.", "Puertos Abiertos",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.OK) { }
                else 
                {
                    SpPuertos.Close();
                    btnConectar.Text = "Conectar";
                    e.Cancel = true;
                }

            }
            else
            {
                SpPuertos.Close();
            }
           
        }
    }
}
