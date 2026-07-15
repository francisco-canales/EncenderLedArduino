using System.IO.Ports;

namespace EncenderLedArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPuertosCOM();
        }

        private void CargarPuertosCOM()
        {
            cmbPuertos.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();

            if (puertos.Length > 0)
            {
                cmbPuertos.Items.AddRange(puertos);
                cmbPuertos.SelectedIndex = 0;
            }
            else
            {
                cmbPuertos.Items.Add("No hay puertos");
                cmbPuertos.SelectedIndex = 0;
                btnConectar.Enabled = false;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = cmbPuertos.SelectedItem.ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();

                    btnConectar.Text = "Desconectar";
                    btnConectar.BackColor = Color.FromArgb(220, 53, 69);
                    btnEncender.Enabled = true;
                    btnApagar.Enabled = true;
                    lblStatusConexion.Text = "Conectado";
                    lblStatusConexion.ForeColor = Color.Green;
                    cmbPuertos.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();

                btnConectar.Text = "Conectar";
                btnConectar.BackColor = Color.FromArgb(0, 122, 204);
                btnEncender.Enabled = false;
                btnApagar.Enabled = false;
                lblStatusConexion.Text = "Desconectado";
                lblStatusConexion.ForeColor = Color.Red;
                cmbPuertos.Enabled = true;
                lblEstado.Text = "LED: APAGADO";
                lblEstado.ForeColor = Color.Gray;
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("1");
                    lblEstado.Text = "LED: ENCENDIDO";
                    lblEstado.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar dato: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)

            {
                try
                {
                    serialPort1.Write("0");
                    lblEstado.Text = "LED: APAGADO";
                    lblEstado.ForeColor = Color.Gray;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar dato: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
