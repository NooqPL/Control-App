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
            trackServoValue1.Enabled = false;

            btnToggleValve2.Text = "CLOSE";
            btnToggleValve2.BackColor = Color.IndianRed;
            trackServoValue2.Enabled = false;

            btnToggleValve3.Text = "CLOSE";
            btnToggleValve3.BackColor = Color.IndianRed;

            btnToggleValve4.Text = "CLOSE";
            btnToggleValve4.BackColor = Color.IndianRed;

            btnToggleValve5.Text = "CLOSE";
            btnToggleValve5.BackColor = Color.IndianRed;
            trackServoValue5.Enabled = false;

            btnToggleValve6.Text = "CLOSE";
            btnToggleValve6.BackColor = Color.IndianRed;
            trackServoValue6.Enabled = false;

            btnToggleValve7.Text = "CLOSE";
            btnToggleValve7.BackColor = Color.IndianRed;

            btnToggleValve8.Text = "CLOSE";
            btnToggleValve8.BackColor = Color.IndianRed;

            //================================================================================//


        }







        //================================================================================//
        public bool isValve1Open = false;
        public bool isValve2Open = false;
        public bool isValve3Open = false;
        public bool isValve4Open = false;

        public bool isValve5Open = false;
        public bool isValve6Open = false;
        public bool isValve7Open = false;
        public bool isValve8Open = false;



        //============================== RED =============================================//
        #region Valve Indicators RED
        private bool valveOpen1 = false;
        private bool valveOpen2 = false;
        private bool valveOpen3 = false;
        private bool valveOpen4 = false;
        private void ToggleValve1(string color = null)
        {
            // Toggle state
            valveOpen1 = !valveOpen1;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator1.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator1.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator1.BackColor = valveOpen1 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
            else
            {
                // Default colors based on state
                panelValveIndicator1.BackColor = valveOpen1 ? Color.LightGreen : Color.IndianRed;
            }
        }

        private void ToggleValve2(string color = null)
        {
            valveOpen2 = !valveOpen2;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator2.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator2.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator2.BackColor = valveOpen3 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
            else
            {
                // Default colors based on state
                panelValveIndicator2.BackColor = valveOpen2 ? Color.LightGreen : Color.IndianRed;
            }
        }
        private void ToggleValve3(string color = null)
        {
            valveOpen3 = !valveOpen3;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator3.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator3.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator3.BackColor = valveOpen3 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
            else
            {
                // Default colors based on state
                panelValveIndicator3.BackColor = valveOpen3 ? Color.LightGreen : Color.IndianRed;
            }
        }
        private void ToggleValve4(string color = null)
        {
            valveOpen4 = !valveOpen4;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator4.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator4.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator4.BackColor = valveOpen4 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
            else
            {
                // Default colors based on state
                panelValveIndicator4.BackColor = valveOpen4 ? Color.LightGreen : Color.IndianRed;
            }
        }
        #endregion

        #region Color Buttons RED
        //======================= COLOR BUTTONs ================================================//


        public void btnToggleValve1_Click(object sender, EventArgs e)
        {
            SetValve1State(!isValve1Open); // just flip current state
            
        }
        public void btnToggleValve2_Click(object sender, EventArgs e)
        {
            SetValve2State(!isValve2Open);
            
        }
        public void btnToggleValve3_Click(object sender, EventArgs e)
        {
            SetValve3State(!isValve3Open); // just flip current state

        }
        public void btnToggleValve4_Click(object sender, EventArgs e)
        {
            SetValve4State(!isValve4Open);

        }


        // ----- NEW METHODS -----
        public void SetValve1State(bool open)
        {
            if (isValve1Open == open) return; // already in desired state

            if (open)
            {
                ToggleValve1("GREEN");
                port.WriteLine("OPEN1");
                isValve1Open = true;
                btnToggleValve1.Text = "OPEN";
                btnToggleValve1.BackColor = Color.LightGreen;
                
                // Enable servo trackbar
                trackServoValue1.Enabled = true;
                if (trackServoValue1.Value == 0)
                    trackServoValue1.Value = 0;

                SendServoValue1(trackServoValue1.Value);
            }
            else
            {
                ToggleValve1("RED");
                port.WriteLine("CLOSE1");
                isValve1Open = false;
                btnToggleValve1.Text = "CLOSE";
                btnToggleValve1.BackColor = Color.IndianRed;

                // Disable servo trackbar
                trackServoValue1.Value = 0;
                trackServoValue1.Enabled = false;

                SendServoValue1(0);
            }

            UpdateServoLabel1();
        }

        public void SetValve2State(bool open)
        {
            if (isValve2Open == open) return;

            if (open)
            {
                ToggleValve2("GREEN");
                port.WriteLine("OPEN2");
                isValve2Open = true;
                btnToggleValve2.Text = "OPEN";
                btnToggleValve2.BackColor = Color.LightGreen;

                trackServoValue2.Enabled = true;
                if (trackServoValue2.Value == 0)
                    trackServoValue2.Value = 0;

                SendServoValue2(trackServoValue2.Value);
            }
            else
            {
                ToggleValve2("RED");
                port.WriteLine("CLOSE2");
                isValve2Open = false;
                btnToggleValve2.Text = "CLOSE";
                btnToggleValve2.BackColor = Color.IndianRed;

                trackServoValue2.Value = 0;
                trackServoValue2.Enabled = false;

                SendServoValue2(0);
            }

            UpdateServoLabel2();
        }

        public void SetValve3State(bool open)
        {
            if (isValve3Open == open) return;

            if (open)
            {
                ToggleValve3("GREEN");
                port.WriteLine("OPEN3");
                isValve3Open = true;
                btnToggleValve3.Text = "OPEN";
                btnToggleValve3.BackColor = Color.LightGreen;

              //  trackServoValue3.Enabled = true;
              //  if (trackServoValue3.Value == 0)
              //      trackServoValue3.Value = 0;
              //
              //  SendServoValue3(trackServoValue3.Value);
            }
            else
            {
                ToggleValve3("RED");
                port.WriteLine("CLOSE3");
                isValve3Open = false;
                btnToggleValve3.Text = "CLOSE";
                btnToggleValve3.BackColor = Color.IndianRed;

              //  trackServoValue2.Value = 0;
              //  trackServoValue2.Enabled = false;
              //
              //  SendServoValue2(0);
            }

            //UpdateServoLabel3();
        }

        public void SetValve4State(bool open)
        {
            if (isValve4Open == open) return;

            if (open)
            {
                ToggleValve4("GREEN");
                port.WriteLine("OPEN4");
                isValve4Open = true;
                btnToggleValve4.Text = "OPEN";
                btnToggleValve4.BackColor = Color.LightGreen;

                //  trackServoValue3.Enabled = true;
                //  if (trackServoValue3.Value == 0)
                //      trackServoValue3.Value = 0;
                //
                //  SendServoValue3(trackServoValue3.Value);
            }
            else
            {
                ToggleValve4("RED");
                port.WriteLine("CLOSE3");
                isValve4Open = false;
                btnToggleValve4.Text = "CLOSE";
                btnToggleValve4.BackColor = Color.IndianRed;

                //  trackServoValue2.Value = 0;
                //  trackServoValue2.Enabled = false;
                //
                //  SendServoValue2(0);
            }

            //UpdateServoLabel4();
        }


     

          
        

        //=====================================================================================//
        #endregion

        #region Slinders Servo Output RED
        private void UpdateServoLabel1()
        {
            lblServoValue1.Text = $"Wartość serwa: {trackServoValue1.Value}%";
        }
        private void UpdateServoLabel2()
        {
            lblServoValue2.Text = $"Wartość serwa: {trackServoValue2.Value}%";
        }

        private void trackServoValue_Scroll_1(object sender, EventArgs e)
        {
            
            UpdateServoLabel1();

            if (isValve1Open)
            {
                // Wysyłaj wartość serwa tylko gdy jest włączone
                SendServoValue1(trackServoValue1.Value);
            }
        }

        private void trackServoValue2_Scroll(object sender, EventArgs e)
        {
            UpdateServoLabel2();

            if (isValve2Open)
            {
                // Wysyłaj wartość serwa tylko gdy jest włączone
                SendServoValue2(trackServoValue2.Value);
            }
        }



        private void SendServoValue1(int value)
        {
            string message = $"[DEBUG] Wysyłam do Pi: SERVO:{value}%";

            // Dopisz wiadomość na końcu TextBox
            port.WriteLine(message);
        }
        private void SendServoValue2(int value)
        {
            string message = $"[DEBUG] Wysyłam do Pi: SERVO:{value}%";

            // Dopisz wiadomość na końcu TextBox
            port.WriteLine(message);
        }

        #endregion
        //================================================================================//

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

        //============================== BLUE ============================================//
        #region Valve Indicators BLUE
        
        private bool valveOpen5 = false;
        private bool valveOpen6 = false;
        private bool valveOpen7 = false;
        private bool valveOpen8 = false;
   
            
        private void ToggleValve5(string color = null)
        {
            valveOpen5 = !valveOpen5;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator5.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator5.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator5.BackColor = valveOpen5 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
        }
        private void ToggleValve6(string color = null)
        {
            valveOpen6 = !valveOpen6;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator6.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator6.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator6.BackColor = valveOpen6 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
        }
        private void ToggleValve7(string color = null)
        {
            valveOpen7 = !valveOpen7;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator7.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator7.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator7.BackColor = valveOpen7 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
        }
        private void ToggleValve8(string color = null)
        {
            valveOpen8 = !valveOpen8;

            // Decide the panel color
            if (!string.IsNullOrEmpty(color))
            {
                // Use specified color
                switch (color.ToUpper())
                {
                    case "GREEN":
                        panelValveIndicator8.BackColor = Color.LightGreen;
                        break;
                    case "RED":
                        panelValveIndicator8.BackColor = Color.IndianRed;
                        break;
                    default:
                        panelValveIndicator8.BackColor = valveOpen8 ? Color.LightGreen : Color.IndianRed;
                        break;
                }
            }
        }


        //=====================================================================================//
        #endregion

        #region Color Buttons BLUE
        //======================= COLOR BUTTONs ================================================//

        public void btnToggleValve5_Click(object sender, EventArgs e)
        {
            SetValve5State(!isValve5Open); // just flip current state
        }
        public void btnToggleValve6_Click(object sender, EventArgs e)
        {
            SetValve6State(!isValve6Open); // just flip current state
        }
        public void btnToggleValve7_Click(object sender, EventArgs e)
        {
            SetValve7State(!isValve7Open); // just flip current state
        }
        public void btnToggleValve8_Click(object sender, EventArgs e)
        {
            SetValve8State(!isValve8Open); // just flip current state
        }




        public void SetValve5State(bool open)
        {
            if (isValve5Open == open) return; // already in desired state

            if (open)
            {
                ToggleValve8("GREEN");
                port.WriteLine("OPEN5");
                isValve5Open = true;
                btnToggleValve5.Text = "OPEN";
                btnToggleValve5.BackColor = Color.LightGreen;

                // Enable servo trackbar
                trackServoValue5.Enabled = true;
                if (trackServoValue5.Value == 0)
                    trackServoValue5.Value = 0;

                SendServoValue5(trackServoValue5.Value);
            }
            else
            {
                ToggleValve8("RED");
                port.WriteLine("CLOSE5");
                isValve5Open = false;
                btnToggleValve5.Text = "CLOSE";
                btnToggleValve5.BackColor = Color.IndianRed;

                // Disable servo trackbar
                trackServoValue5.Value = 0;
                trackServoValue5.Enabled = false;

                SendServoValue5(0);
            }

            UpdateServoLabel5();
        }
        public void SetValve6State(bool open)
        {
            if (isValve6Open == open) return; // already in desired state

            if (open)
            {
                ToggleValve6("GREEN");
                port.WriteLine("OPEN6");
                isValve6Open = true;
                btnToggleValve6.Text = "OPEN";
                btnToggleValve6.BackColor = Color.LightGreen;

                // Enable servo trackbar
                trackServoValue6.Enabled = true;
                if (trackServoValue6.Value == 0)
                    trackServoValue6.Value = 0;

                SendServoValue6(trackServoValue6.Value);
            }
            else
            {
                ToggleValve6("RED");
                port.WriteLine("CLOSE6");
                isValve6Open = false;
                btnToggleValve6.Text = "CLOSE";
                btnToggleValve6.BackColor = Color.IndianRed;

                // Disable servo trackbar
                trackServoValue6.Value = 0;
                trackServoValue6.Enabled = false;

                SendServoValue6(0);
            }

            UpdateServoLabel6();
        }
        public void SetValve7State(bool open)
        {
            if (isValve7Open == open) return; // already in desired state

            if (open)
            {
                ToggleValve7("GREEN");
                port.WriteLine("OPEN7");
                isValve7Open = true;
                btnToggleValve7.Text = "OPEN";
                btnToggleValve7.BackColor = Color.LightGreen;

                // Enable servo trackbar
                // trackServoValue7.Enabled = true;
                //if (trackServoValue7.Value == 0)
                // trackServoValue7.Value = 0;

                //SendServoValue7(trackServoValue7.Value);
            }
            else
            {
                ToggleValve7("RED");
                port.WriteLine("CLOSE7");
                isValve7Open = false;
                btnToggleValve7.Text = "CLOSE";
                btnToggleValve7.BackColor = Color.IndianRed;

                // Disable servo trackbar
                //trackServoValue7.Value = 0;
                //trackServoValue7.Enabled = false;

                //SendServoValue7(0);
            }

            //UpdateServoLabel7();
        }
        public void SetValve8State(bool open)
        {
            if (isValve8Open == open) return; // already in desired state

            if (open)
            {
                ToggleValve5("GREEN");
                port.WriteLine("OPEN8");
                isValve8Open = true;
                btnToggleValve8.Text = "OPEN";
                btnToggleValve8.BackColor = Color.LightGreen;

                // Enable servo trackbar
                // trackServoValue8.Enabled = true;
                // if (trackServoValue8.Value == 0)
                //trackServoValue8.Value = 0;

                //SendServoValue8(trackServoValue8.Value);
            }
            else
            {
                ToggleValve5("RED");
                port.WriteLine("CLOSE8");
                isValve8Open = false;
                btnToggleValve8.Text = "CLOSE";
                btnToggleValve8.BackColor = Color.IndianRed;

                // Disable servo trackbar
                //trackServoValue8.Value = 0;
                //trackServoValue8.Enabled = false;

                //SendServoValue8(0);
            }

            //UpdateServoLabel8();
        }


        //=====================================================================================//
        #endregion

        #region Slinders Servo Output RED
        private void UpdateServoLabel5()
        {
            lblServoValue5.Text = $"Wartość serwa: {trackServoValue5.Value}%";
        }
        private void UpdateServoLabel6()
        {
            lblServoValue6.Text = $"Wartość serwa: {trackServoValue6.Value}%";
        }

        private void trackServoValue5_Scroll(object sender, EventArgs e)
        {
            
            UpdateServoLabel5();

            if (isValve5Open) SendServoValue5(trackServoValue5.Value);
        }

        private void trackServoValue6_Scroll(object sender, EventArgs e)
        {
            

            UpdateServoLabel6();

            if (isValve6Open) SendServoValue6(trackServoValue6.Value);
            
        }



        private void SendServoValue5(int value)
        {
            string message = $"[DEBUG] Wysyłam do Pi: SERVO:{value}%";

            // Dopisz wiadomość na końcu TextBox
            port.WriteLine(message);
        }
        private void SendServoValue6(int value)
        {
            string message = $"[DEBUG] Wysyłam do Pi: SERVO:{value}%";

            // Dopisz wiadomość na końcu TextBox
            port.WriteLine(message);
        }

        #endregion
        //================================================================================//
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

        private void scriptEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptEditorForm editor = new ScriptEditorForm(this);
            editor.Show(); // use ShowDialog() if you want it modal
        }

        public void ToggleValve(string valve, string action)
        {
            // Normalize action
            action = action.ToUpper();

            switch (valve)
            {
                case "RED1":
                    btnToggleValve1.PerformClick();
                    break;
                case "RED2":
                    btnToggleValve2.PerformClick();
                    break;
                case "RED3":
                    btnToggleValve3.PerformClick();
                    break;
                case "RED4":
                    btnToggleValve4.PerformClick();
                    break;

                case "BLUE1":
                    btnToggleValve5.PerformClick();
                    break;
                case "BLUE2":
                    btnToggleValve6.PerformClick();
                    break;
                case "BLUE3":
                    btnToggleValve7.PerformClick();
                    break;
                case "BLUE4":
                    btnToggleValve8.PerformClick();
                    break;
            }
        }

        public void SetServo1(int value)
        {
            trackServoValue1.Value = Math.Max(trackServoValue1.Minimum, Math.Min(trackServoValue1.Maximum, value));
            UpdateServoLabel1();
            if (isValve1Open) SendServoValue1(trackServoValue1.Value);
        }

        public void SetServo2(int value)
        {
            trackServoValue2.Value = Math.Max(trackServoValue2.Minimum, Math.Min(trackServoValue2.Maximum, value));
            UpdateServoLabel2();
            if (isValve2Open) SendServoValue2(trackServoValue2.Value);
        }

        public void SetServo3(int value)
        {
            trackServoValue5.Value = Math.Max(trackServoValue5.Minimum, Math.Min(trackServoValue5.Maximum, value));
            UpdateServoLabel5();
            if (isValve5Open) SendServoValue5(trackServoValue5.Value);
        }

        public void SetServo4(int value)
        {
            trackServoValue6.Value = Math.Max(trackServoValue6.Minimum, Math.Min(trackServoValue6.Maximum, value));
            UpdateServoLabel6();
            if (isValve6Open) SendServoValue6(trackServoValue6.Value);
        }

        // and same for Servo3, Servo4

    }
}
