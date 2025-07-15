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

namespace SterowanieStanowiskiem
{
    public partial class MainWindow : Form
    {
        FakePort port;
        SerialPort serialPort = new SerialPort();

        public MainWindow()
        {
            InitializeComponent();








            port = new FakePort();
            port.DataReceived += Port_DataReceived;



            LoadSerialSettings();


            try
            {
                port.Open(); // Otwórz połączenie
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można połączyć z urządzeniem: " + ex.Message);
            }






            //pictureBackground.Image = Image.FromFile("stand.png");
            // pictureBackground.Size = new Size(1920, 1080); // lub inny rozmiar
            // CenterPictureBox();





            btnToggleValve1.Text = "OPEN";
            btnToggleValve1.BackColor = Color.LightGreen;
            // checkBoxValve1.Checked = false;

            btnToggleValve2.Text = "OPEN";
            btnToggleValve2.BackColor = Color.LightGreen;
            //checkBoxValve2.Checked = false;



















        }


        private bool isValve1Open = false;
        private bool isValve2Open = false;




























        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine("OPEN");


        }
        private void btnCloseValve_Click(object sender, EventArgs e)
        {
            port.WriteLine("CLOSE");


        }
        private void Port_DataReceived(string data)
        {
            Invoke(new Action(() =>
            {
                ProcessIncomingData(data);
            }));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (port != null && port.IsOpen)
            //{
            //    port.WriteLine("READ");
            // }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBackground_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(textBoxSend.Text);
                textBoxSend.Clear();
            }
        }
        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxTerminal_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnConnectCom_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(comboBoxBaud.SelectedItem.ToString());
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();

                    btnConnectCom.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open port:\n" + ex.Message);
                }
            }
            else
            {
                serialPort.Close();
                btnConnectCom.Text = "Connect";
            }
        }
        private void comboBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadSerialSettings()
        {
            // Ładowanie portów COM
            comboBoxPorts.Items.Clear();
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;

            // Popularne prędkości transmisji
            comboBoxBaud.Items.Clear();
            comboBoxBaud.Items.AddRange(new object[] { 9600, 19200, 38400, 57600, 115200 });
            comboBoxBaud.SelectedIndex = 0;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();

            Invoke(new Action(() =>
            {
                ProcessIncomingData(data);
            }));
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleValve1_Click(object sender, EventArgs e)
        {
            if (!isValve1Open)
            {
                port.WriteLine("CLOSE1");
                isValve1Open = true;
                btnToggleValve1.Text = "CLOSE";
                btnToggleValve1.BackColor = Color.IndianRed;
                // checkBoxValve1.Checked = true;
            }
            else
            {
                port.WriteLine("OPEN1");
                isValve1Open = false;
                btnToggleValve1.Text = "OPEN";
                btnToggleValve1.BackColor = Color.LightGreen;
                // checkBoxValve1.Checked = false;
            }

            // LogTelemetry(isValve1Open ? "OPEN1" : "CLOSE1");
        }

        private void btnToggleValve2_Click(object sender, EventArgs e)
        {
            if (!isValve2Open)
            {
                port.WriteLine("CLOSE2");
                isValve2Open = true;
                btnToggleValve2.Text = "CLOSE";
                btnToggleValve2.BackColor = Color.IndianRed;
                //  checkBoxValve2.Checked = true;
            }
            else
            {
                port.WriteLine("OPEN2");
                isValve2Open = false;
                btnToggleValve2.Text = "OPEN";
                btnToggleValve2.BackColor = Color.LightGreen;
                //  checkBoxValve2.Checked = false;
            }

            // LogTelemetry(isValve2Open ? "OPEN2" : "CLOSE2");
        }

        private void lblSensorData_Click(object sender, EventArgs e)
        {

        }



        private void ProcessIncomingData(string data)
        {
            lblSensorData.Text = "Odczyt: " + data;

            if (data.StartsWith("PRESSURE="))
            {
                string val = data.Replace("PRESSURE=", "").Trim();
                if (double.TryParse(val, out double pressure))
                {
                    int percent = (int)(pressure * 10);
                    percent = Math.Min(100, Math.Max(0, percent));
                    progressPressure.Value = percent;
                    labelPressure.Text = $"{pressure:0.0} bar";
                }
            }
            else if (data.StartsWith("FUEL="))
            {
                string val = data.Replace("FUEL=", "").Trim();
                if (int.TryParse(val, out int fuel))
                {
                    fuel = Math.Min(100, Math.Max(0, fuel));
                    progressFuel.Value = fuel;
                    labelFuel.Text = $"{fuel}%";
                }
            }

            textBoxTerminal.AppendText(data + Environment.NewLine);
        }
    }


}
