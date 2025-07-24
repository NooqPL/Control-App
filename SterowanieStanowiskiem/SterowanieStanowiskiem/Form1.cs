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

using PiController;
using System.Net.NetworkInformation;


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

            //======================== COLOR BUTTON SETUP ====================================//

            btnToggleValve1.Text = "CLOSE";
            btnToggleValve1.BackColor = Color.IndianRed;
            

            btnToggleValve2.Text = "CLOSE";
            btnToggleValve2.BackColor = Color.IndianRed;
            
            //================================================================================//


        }


        private bool isValve1Open = false;
        private bool isValve2Open = false;
        private bool isValve3Open = false;
        private bool isValve4Open = false;


        #region Valve Indicators  
        //======================== INDICATORS =================================================//
        private bool valveOpen1 = false;
        private bool valveOpen2 = false;
        private bool valveOpen3 = false;
        private bool valveOpen4 = false;
        private bool valveOpen5 = false;
        private bool valveOpen6 = false;
        private bool valveOpen7 = false;
        private bool valveOpen8 = false;
        private void ToggleValve1()
        {
            valveOpen1 = !valveOpen1;

            if (valveOpen1)
            {
                panelValveIndicator1.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator1.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve2()
        {
            valveOpen2 = !valveOpen2;

            if (valveOpen2)
            {
                panelValveIndicator2.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator2.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve3()
        {
            valveOpen3 = !valveOpen3;

            if (valveOpen3)
            {
                panelValveIndicator3.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator3.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve4()
        {
            valveOpen4 = !valveOpen4;

            if (valveOpen4)
            {
                panelValveIndicator4.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator4.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve5()
        {
            valveOpen5 = !valveOpen5;

            if (valveOpen5)
            {
                panelValveIndicator5.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator5.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve6()
        {
            valveOpen6 = !valveOpen6;

            if (valveOpen6)
            {
                panelValveIndicator6.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator6.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve7()
        {
            valveOpen7 = !valveOpen7;

            if (valveOpen7)
            {
                panelValveIndicator7.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator7.BackColor = Color.IndianRed;
            }
        }
        private void ToggleValve8()
        {
            valveOpen8 = !valveOpen8;

            if (valveOpen8)
            {
                panelValveIndicator8.BackColor = Color.LightGreen;
            }
            else
            {
                panelValveIndicator8.BackColor = Color.IndianRed;
            }
        }
    

    //=====================================================================================//
    #endregion

        #region Color Buttons
    //======================= COLOR BUTTONs ================================================//
    private void btnToggleValve1_Click(object sender, EventArgs e)
        {

            if (!isValve1Open)
            {
                port.WriteLine("OPEN1");
                isValve1Open = true;
                btnToggleValve1.Text = "OPEN";
                btnToggleValve1.BackColor = Color.LightGreen;
                // checkBoxValve1.Checked = true;
                ToggleValve1();
            }
            else
            {
                port.WriteLine("CLOSE1");
                isValve1Open = false;
                btnToggleValve1.Text = "CLOSE";
                btnToggleValve1.BackColor = Color.IndianRed;
                // checkBoxValve1.Checked = false;
                ToggleValve1();
            }

            // LogTelemetry(isValve1Open ? "OPEN1" : "CLOSE1");
        }

        private void btnToggleValve2_Click(object sender, EventArgs e)
        {
            if (!isValve2Open)
            {
                port.WriteLine("OPEN2");
                isValve2Open = true;
                btnToggleValve2.Text = "OPEN";
                btnToggleValve2.BackColor = Color.LightGreen;
                //  checkBoxValve2.Checked = true;
                ToggleValve2();
            }
            else
            {
                port.WriteLine("CLOSE2");
                isValve2Open = false;
                btnToggleValve2.Text = "CLOSE";
                btnToggleValve2.BackColor = Color.IndianRed;
                //  checkBoxValve2.Checked = false;
                ToggleValve2();
            }

            // LogTelemetry(isValve2Open ? "OPEN2" : "CLOSE2");
        }
        private void btnToggleValve3_Click(object sender, EventArgs e)
        {
            if (!isValve3Open)
            {
                port.WriteLine("OPEN3");
                isValve3Open = true;
                btnToggleValve3.Text = "OPEN";
                btnToggleValve3.BackColor = Color.LightGreen;
                //  checkBoxValve2.Checked = true;
                ToggleValve3();
            }
            else
            {
                port.WriteLine("CLOSE3");
                isValve3Open = false;
                btnToggleValve3.Text = "CLOSE";
                btnToggleValve3.BackColor = Color.IndianRed;
                //  checkBoxValve2.Checked = false;
                ToggleValve3();
            }

            // LogTelemetry(isValve2Open ? "OPEN2" : "CLOSE2");
        }
        private void btnToggleValve4_Click(object sender, EventArgs e)
        {
            if (!isValve4Open)
            {
                port.WriteLine("OPEN4");
                isValve4Open = true;
                btnToggleValve4.Text = "OPEN";
                btnToggleValve4.BackColor = Color.LightGreen;
                //  checkBoxValve4.Checked = true;
                ToggleValve4();
            }
            else
            {
                port.WriteLine("CLOSE4");
                isValve4Open = false;
                btnToggleValve4.Text = "CLOSE";
                btnToggleValve4.BackColor = Color.IndianRed;
                //  checkBoxValve4.Checked = false;
                ToggleValve4();
            }

            // LogTelemetry(isValve2Open ? "OPEN2" : "CLOSE2");
        }

        //=====================================================================================//
        #endregion

        #region DATA SETUP / VISUAL
        //=================== DATA PROCESSING =================================================//
        private void ProcessIncomingData(string data)
        {
            

            if (data.StartsWith("PRESSURE="))
            {
                string val = data.Replace("PRESSURE=", "").Trim();
                if (double.TryParse(val, out double pressure))
                {
                    int percent = (int)(pressure * 10);
                    percent = Math.Min(100, Math.Max(0, percent));
                    progressPressure1.Value = percent;
                    progressPressure2.Value = percent;
                    progressPressure3.Value = percent;
                    labelPressure1.Text = $"{pressure:0.0} bar";
                    labelPressure2.Text = $"{pressure:0.0} bar";
                    labelPressure3.Text = $"{pressure:0.0} bar";
                    PressureLabel1.Text = $"{pressure:0.0} bar";
                    PressureLabel2.Text = $"{pressure:0.0} bar";
                    PressureLabel3.Text = $"{pressure:0.0} bar";
                    PressureLabel4.Text = $"{pressure:0.0} bar";
                    PressureLabel5.Text = $"{pressure:0.0} bar";
                    PressureLabel6.Text = $"{pressure:0.0} bar";



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
                    SetFuelLevel(fuel);
                }
            }

            textBoxTerminal.AppendText(data + Environment.NewLine);
        }
        //=====================================================================================//

        #endregion



        #region Progress Bars
        //================ Progress Bars ======================================================//
        private void SetFuelLevel(int percent)
        {
            // Upewniamy się że percent jest w zakresie 0–100
            percent = Math.Max(0, Math.Min(100, percent));

            int totalHeight = panelFuelContainer.Height;
            int fillHeight = (totalHeight * percent) / 100;

            panelFuelLevel.Height = fillHeight;
            panelFuelLevel.Top = totalHeight - fillHeight;

            // Zmiana koloru w zależności od poziomu
            if (percent < 30)
                panelFuelLevel.BackColor = Color.Red;
            else if (percent < 60)
                panelFuelLevel.BackColor = Color.Orange;
            else
                panelFuelLevel.BackColor = Color.Green;
        }
        //=====================================================================================//
        #endregion



        private bool PingPi()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("192.168.1.10", 500); // IP twojego Pi
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
        private bool CheckInternet()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("8.8.8.8", 500); // Google DNS
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }













        //var pi = new PiTcpClient();





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
        private void statusTimer_Tick(object sender, EventArgs e)
        {
            // Sprawdzenie Pi
            if (PingPi())
            {
                lblPiStatus.Text = "Status Pi: ✅ Połączono";
                lblPiStatus.ForeColor = Color.Green;
            }
            else
            {
                lblPiStatus.Text = "Status Pi: ❌ Brak połączenia";
                lblPiStatus.ForeColor = Color.Red;
            }

            // Sprawdzenie internetu
            if (CheckInternet())
            {
                lblInternetStatus.Text = "Internet: 🌐 Dostępny";
                lblInternetStatus.ForeColor = Color.Green;
            }
            else
            {
                lblInternetStatus.Text = "Internet: ❌ Niedostępny";
                lblInternetStatus.ForeColor = Color.Red;
            }
        }
        private void UpdateServoLabel()
        {
            lblServoValue.Text = $"Wartość serwa: {trackServoValue.Value}%";
        }
        private void SendServoValue(int value)
        {
            string message = $"[DEBUG] Wysyłam do Pi: SERVO:{value}%";

            // Dopisz wiadomość na końcu TextBox
            port.WriteLine(message);
        }
        private void trackServoValue_Scroll_1(object sender, EventArgs e)
        {
            UpdateServoLabel();

            if (chkServoEnable.Checked)
            {
                // Wysyłaj wartość serwa tylko gdy jest włączone
                SendServoValue(trackServoValue.Value);
            }
        }
        private void chkServoEnable_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkServoEnable.Checked)
            {
                // Włącz serwo: aktywuj TrackBar
                trackServoValue.Enabled = true;

                // Możesz też od razu ustawić np. na 50% lub zostawić ostatnią wartość
                if (trackServoValue.Value == 0)
                    trackServoValue.Value = 0;

                // Wyślij komendę do Pi, aby obudzić serwo na aktualnej wartości
                SendServoValue(trackServoValue.Value);
            }
            else
            {
                // Wyłącz serwo: ustaw wartość na 0 i zablokuj TrackBar
                trackServoValue.Value = 0;
                trackServoValue.Enabled = false;

                // Wyślij komendę do Pi, aby wyłączyć serwo (ustaw 0)
                SendServoValue(0);
            }

            UpdateServoLabel();
        }

        
    }
}
