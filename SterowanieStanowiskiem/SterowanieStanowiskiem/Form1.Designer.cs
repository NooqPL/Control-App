namespace SterowanieStanowiskiem
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.btnConnectCom = new System.Windows.Forms.Button();
            this.textBoxTerminal = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToggleValve1 = new System.Windows.Forms.Button();
            this.btnToggleValve2 = new System.Windows.Forms.Button();
            this.progressPressure1 = new System.Windows.Forms.ProgressBar();
            this.labelPressure1 = new System.Windows.Forms.Label();
            this.progressFuel = new System.Windows.Forms.ProgressBar();
            this.labelFuel = new System.Windows.Forms.Label();
            this.TelemetriaGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelValveIndicator4 = new System.Windows.Forms.Panel();
            this.panelValveIndicator5 = new System.Windows.Forms.Panel();
            this.panelValveIndicator6 = new System.Windows.Forms.Panel();
            this.panelValveIndicator2 = new System.Windows.Forms.Panel();
            this.panelValveIndicator3 = new System.Windows.Forms.Panel();
            this.panelValveIndicator7 = new System.Windows.Forms.Panel();
            this.panelValveIndicator8 = new System.Windows.Forms.Panel();
            this.panelValveIndicator1 = new System.Windows.Forms.Panel();
            this.PressureLabel6 = new System.Windows.Forms.Label();
            this.PressureLabel5 = new System.Windows.Forms.Label();
            this.PressureLabel4 = new System.Windows.Forms.Label();
            this.PressureLabel3 = new System.Windows.Forms.Label();
            this.PressureLabel2 = new System.Windows.Forms.Label();
            this.PressureLabel1 = new System.Windows.Forms.Label();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelFuelContainer = new System.Windows.Forms.Panel();
            this.panelFuelLevel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblInternetStatus = new System.Windows.Forms.Label();
            this.lblPiStatus = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.trackServoValue1 = new System.Windows.Forms.TrackBar();
            this.lblServoValue1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelPressure3 = new System.Windows.Forms.Label();
            this.progressPressure3 = new System.Windows.Forms.ProgressBar();
            this.label20 = new System.Windows.Forms.Label();
            this.labelPressure2 = new System.Windows.Forms.Label();
            this.progressPressure2 = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnToggleValve4 = new System.Windows.Forms.Button();
            this.btnToggleValve3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TankLabel1 = new System.Windows.Forms.Label();
            this.TankLabel2 = new System.Windows.Forms.Label();
            this.trackServoValue2 = new System.Windows.Forms.TrackBar();
            this.lblServoValue2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelFuelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 250);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 208);
            this.checkedListBox1.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(693, 1112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(981, 97);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(17, 19);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 15;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(144, 19);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaud.TabIndex = 16;
            this.comboBoxBaud.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaud_SelectedIndexChanged);
            // 
            // btnConnectCom
            // 
            this.btnConnectCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectCom.Location = new System.Drawing.Point(285, 17);
            this.btnConnectCom.Name = "btnConnectCom";
            this.btnConnectCom.Size = new System.Drawing.Size(75, 23);
            this.btnConnectCom.TabIndex = 17;
            this.btnConnectCom.Text = "Connect";
            this.btnConnectCom.UseVisualStyleBackColor = true;
            this.btnConnectCom.Click += new System.EventHandler(this.btnConnectCom_Click);
            // 
            // textBoxTerminal
            // 
            this.textBoxTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTerminal.Location = new System.Drawing.Point(175, 46);
            this.textBoxTerminal.Multiline = true;
            this.textBoxTerminal.Name = "textBoxTerminal";
            this.textBoxTerminal.ReadOnly = true;
            this.textBoxTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTerminal.Size = new System.Drawing.Size(185, 115);
            this.textBoxTerminal.TabIndex = 18;
            this.textBoxTerminal.TextChanged += new System.EventHandler(this.textBoxTerminal_TextChanged);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSend.Location = new System.Drawing.Point(17, 141);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(152, 20);
            this.textBoxSend.TabIndex = 19;
            this.textBoxSend.TextChanged += new System.EventHandler(this.textBoxSend_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(17, 112);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Controls.Add(this.btnConnectCom);
            this.groupBox1.Controls.Add(this.textBoxSend);
            this.groupBox1.Controls.Add(this.textBoxTerminal);
            this.groupBox1.Location = new System.Drawing.Point(1981, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 177);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2369, 33);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2});
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // btnToggleValve1
            // 
            this.btnToggleValve1.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve1.Location = new System.Drawing.Point(46, 7);
            this.btnToggleValve1.Name = "btnToggleValve1";
            this.btnToggleValve1.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve1.TabIndex = 23;
            this.btnToggleValve1.Text = "CLOSE";
            this.btnToggleValve1.UseVisualStyleBackColor = false;
            this.btnToggleValve1.Click += new System.EventHandler(this.btnToggleValve1_Click);
            // 
            // btnToggleValve2
            // 
            this.btnToggleValve2.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve2.Location = new System.Drawing.Point(46, 91);
            this.btnToggleValve2.Name = "btnToggleValve2";
            this.btnToggleValve2.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve2.TabIndex = 24;
            this.btnToggleValve2.Text = "CLOSE";
            this.btnToggleValve2.UseVisualStyleBackColor = false;
            this.btnToggleValve2.Click += new System.EventHandler(this.btnToggleValve2_Click);
            // 
            // progressPressure1
            // 
            this.progressPressure1.Location = new System.Drawing.Point(46, 49);
            this.progressPressure1.Name = "progressPressure1";
            this.progressPressure1.Size = new System.Drawing.Size(141, 23);
            this.progressPressure1.TabIndex = 25;
            // 
            // labelPressure1
            // 
            this.labelPressure1.AutoSize = true;
            this.labelPressure1.Location = new System.Drawing.Point(190, 58);
            this.labelPressure1.Name = "labelPressure1";
            this.labelPressure1.Size = new System.Drawing.Size(40, 13);
            this.labelPressure1.TabIndex = 26;
            this.labelPressure1.Text = "0.0 bar";
            // 
            // progressFuel
            // 
            this.progressFuel.Location = new System.Drawing.Point(30, 235);
            this.progressFuel.Name = "progressFuel";
            this.progressFuel.Size = new System.Drawing.Size(141, 23);
            this.progressFuel.TabIndex = 27;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(46, 186);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(21, 13);
            this.labelFuel.TabIndex = 28;
            this.labelFuel.Text = "0%";
            // 
            // TelemetriaGroupBox
            // 
            this.TelemetriaGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TelemetriaGroupBox.Location = new System.Drawing.Point(12, 807);
            this.TelemetriaGroupBox.Name = "TelemetriaGroupBox";
            this.TelemetriaGroupBox.Size = new System.Drawing.Size(200, 198);
            this.TelemetriaGroupBox.TabIndex = 29;
            this.TelemetriaGroupBox.TabStop = false;
            this.TelemetriaGroupBox.Text = "Telemetria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TankLabel2);
            this.groupBox2.Controls.Add(this.TankLabel1);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panelValveIndicator4);
            this.groupBox2.Controls.Add(this.panelValveIndicator5);
            this.groupBox2.Controls.Add(this.panelValveIndicator6);
            this.groupBox2.Controls.Add(this.panelValveIndicator2);
            this.groupBox2.Controls.Add(this.panelValveIndicator3);
            this.groupBox2.Controls.Add(this.panelValveIndicator7);
            this.groupBox2.Controls.Add(this.panelValveIndicator8);
            this.groupBox2.Controls.Add(this.panelValveIndicator1);
            this.groupBox2.Controls.Add(this.PressureLabel6);
            this.groupBox2.Controls.Add(this.PressureLabel5);
            this.groupBox2.Controls.Add(this.PressureLabel4);
            this.groupBox2.Controls.Add(this.PressureLabel3);
            this.groupBox2.Controls.Add(this.PressureLabel2);
            this.groupBox2.Controls.Add(this.PressureLabel1);
            this.groupBox2.Controls.Add(this.pictureBackground);
            this.groupBox2.Location = new System.Drawing.Point(1275, 533);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 573);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visual Control";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(532, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 25);
            this.label16.TabIndex = 46;
            this.label16.Text = "P3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(344, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 25);
            this.label15.TabIndex = 45;
            this.label15.Text = "P2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(453, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "P1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(608, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "V3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "V1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "V2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "V4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "V4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "V3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "V2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "V1";
            // 
            // panelValveIndicator4
            // 
            this.panelValveIndicator4.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator4.Location = new System.Drawing.Point(79, 227);
            this.panelValveIndicator4.Name = "panelValveIndicator4";
            this.panelValveIndicator4.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator4.TabIndex = 33;
            // 
            // panelValveIndicator5
            // 
            this.panelValveIndicator5.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator5.Location = new System.Drawing.Point(79, 346);
            this.panelValveIndicator5.Name = "panelValveIndicator5";
            this.panelValveIndicator5.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator5.TabIndex = 33;
            // 
            // panelValveIndicator6
            // 
            this.panelValveIndicator6.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator6.Location = new System.Drawing.Point(97, 412);
            this.panelValveIndicator6.Name = "panelValveIndicator6";
            this.panelValveIndicator6.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator6.TabIndex = 33;
            // 
            // panelValveIndicator2
            // 
            this.panelValveIndicator2.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator2.Location = new System.Drawing.Point(97, 160);
            this.panelValveIndicator2.Name = "panelValveIndicator2";
            this.panelValveIndicator2.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator2.TabIndex = 33;
            // 
            // panelValveIndicator3
            // 
            this.panelValveIndicator3.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator3.Location = new System.Drawing.Point(612, 160);
            this.panelValveIndicator3.Name = "panelValveIndicator3";
            this.panelValveIndicator3.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator3.TabIndex = 33;
            // 
            // panelValveIndicator7
            // 
            this.panelValveIndicator7.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator7.Location = new System.Drawing.Point(612, 412);
            this.panelValveIndicator7.Name = "panelValveIndicator7";
            this.panelValveIndicator7.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator7.TabIndex = 33;
            // 
            // panelValveIndicator8
            // 
            this.panelValveIndicator8.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator8.Location = new System.Drawing.Point(384, 480);
            this.panelValveIndicator8.Name = "panelValveIndicator8";
            this.panelValveIndicator8.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator8.TabIndex = 33;
            // 
            // panelValveIndicator1
            // 
            this.panelValveIndicator1.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator1.Location = new System.Drawing.Point(384, 94);
            this.panelValveIndicator1.Name = "panelValveIndicator1";
            this.panelValveIndicator1.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator1.TabIndex = 32;
            // 
            // PressureLabel6
            // 
            this.PressureLabel6.AutoSize = true;
            this.PressureLabel6.Location = new System.Drawing.Point(533, 398);
            this.PressureLabel6.Name = "PressureLabel6";
            this.PressureLabel6.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel6.TabIndex = 34;
            this.PressureLabel6.Text = "label6";
            // 
            // PressureLabel5
            // 
            this.PressureLabel5.AutoSize = true;
            this.PressureLabel5.Location = new System.Drawing.Point(439, 465);
            this.PressureLabel5.Name = "PressureLabel5";
            this.PressureLabel5.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel5.TabIndex = 33;
            this.PressureLabel5.Text = "label5";
            // 
            // PressureLabel4
            // 
            this.PressureLabel4.AutoSize = true;
            this.PressureLabel4.Location = new System.Drawing.Point(346, 398);
            this.PressureLabel4.Name = "PressureLabel4";
            this.PressureLabel4.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel4.TabIndex = 32;
            this.PressureLabel4.Text = "label4";
            // 
            // PressureLabel3
            // 
            this.PressureLabel3.AutoSize = true;
            this.PressureLabel3.Location = new System.Drawing.Point(533, 179);
            this.PressureLabel3.Name = "PressureLabel3";
            this.PressureLabel3.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel3.TabIndex = 31;
            this.PressureLabel3.Text = "label3";
            // 
            // PressureLabel2
            // 
            this.PressureLabel2.AutoSize = true;
            this.PressureLabel2.Location = new System.Drawing.Point(454, 111);
            this.PressureLabel2.Name = "PressureLabel2";
            this.PressureLabel2.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel2.TabIndex = 30;
            this.PressureLabel2.Text = "label2";
            // 
            // PressureLabel1
            // 
            this.PressureLabel1.AutoSize = true;
            this.PressureLabel1.Location = new System.Drawing.Point(346, 179);
            this.PressureLabel1.Name = "PressureLabel1";
            this.PressureLabel1.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel1.TabIndex = 29;
            this.PressureLabel1.Text = "label1";
            // 
            // pictureBackground
            // 
            this.pictureBackground.Image = global::SterowanieStanowiskiem.Properties.Resources.model8;
            this.pictureBackground.Location = new System.Drawing.Point(6, 22);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(943, 545);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBackground.TabIndex = 3;
            this.pictureBackground.TabStop = false;
            this.pictureBackground.Click += new System.EventHandler(this.pictureBackground_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SterowanieStanowiskiem.Properties.Resources.ArcLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelFuelContainer);
            this.groupBox3.Controls.Add(this.labelFuel);
            this.groupBox3.Controls.Add(this.progressFuel);
            this.groupBox3.Location = new System.Drawing.Point(12, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 286);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panelFuelContainer
            // 
            this.panelFuelContainer.BackColor = System.Drawing.Color.LightGray;
            this.panelFuelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuelContainer.Controls.Add(this.panelFuelLevel);
            this.panelFuelContainer.Location = new System.Drawing.Point(6, 19);
            this.panelFuelContainer.Name = "panelFuelContainer";
            this.panelFuelContainer.Size = new System.Drawing.Size(35, 181);
            this.panelFuelContainer.TabIndex = 25;
            // 
            // panelFuelLevel
            // 
            this.panelFuelLevel.BackColor = System.Drawing.Color.Green;
            this.panelFuelLevel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFuelLevel.Location = new System.Drawing.Point(0, -1);
            this.panelFuelLevel.Name = "panelFuelLevel";
            this.panelFuelLevel.Size = new System.Drawing.Size(33, 180);
            this.panelFuelLevel.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Location = new System.Drawing.Point(1981, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 124);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection";
            // 
            // lblInternetStatus
            // 
            this.lblInternetStatus.AutoSize = true;
            this.lblInternetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternetStatus.Location = new System.Drawing.Point(707, 1160);
            this.lblInternetStatus.Name = "lblInternetStatus";
            this.lblInternetStatus.Size = new System.Drawing.Size(99, 25);
            this.lblInternetStatus.TabIndex = 1;
            this.lblInternetStatus.Text = "Internet: ?";
            // 
            // lblPiStatus
            // 
            this.lblPiStatus.AutoSize = true;
            this.lblPiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiStatus.Location = new System.Drawing.Point(707, 1123);
            this.lblPiStatus.Name = "lblPiStatus";
            this.lblPiStatus.Size = new System.Drawing.Size(112, 25);
            this.lblPiStatus.TabIndex = 0;
            this.lblPiStatus.Text = "Status Pi: ?";
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Interval = 2000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // trackServoValue1
            // 
            this.trackServoValue1.Location = new System.Drawing.Point(141, 3);
            this.trackServoValue1.Maximum = 100;
            this.trackServoValue1.Name = "trackServoValue1";
            this.trackServoValue1.Size = new System.Drawing.Size(141, 69);
            this.trackServoValue1.TabIndex = 35;
            this.trackServoValue1.Scroll += new System.EventHandler(this.trackServoValue_Scroll_1);
            // 
            // lblServoValue1
            // 
            this.lblServoValue1.AutoSize = true;
            this.lblServoValue1.Location = new System.Drawing.Point(49, 33);
            this.lblServoValue1.Name = "lblServoValue1";
            this.lblServoValue1.Size = new System.Drawing.Size(62, 13);
            this.lblServoValue1.TabIndex = 36;
            this.lblServoValue1.Text = "ServoValue";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Location = new System.Drawing.Point(271, 250);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(297, 761);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RED";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 741);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblServoValue2);
            this.panel2.Controls.Add(this.lblServoValue1);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.labelPressure3);
            this.panel2.Controls.Add(this.progressPressure3);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.labelPressure2);
            this.panel2.Controls.Add(this.progressPressure2);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.labelPressure1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.progressPressure1);
            this.panel2.Controls.Add(this.btnToggleValve1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnToggleValve4);
            this.panel2.Controls.Add(this.btnToggleValve3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnToggleValve2);
            this.panel2.Controls.Add(this.trackServoValue1);
            this.panel2.Controls.Add(this.trackServoValue2);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 731);
            this.panel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(0, 429);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(286, 5);
            this.panel8.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(0, 315);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 5);
            this.panel6.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(0, 389);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(286, 5);
            this.panel7.TabIndex = 41;
            // 
            // labelPressure3
            // 
            this.labelPressure3.AutoSize = true;
            this.labelPressure3.Location = new System.Drawing.Point(190, 369);
            this.labelPressure3.Name = "labelPressure3";
            this.labelPressure3.Size = new System.Drawing.Size(40, 13);
            this.labelPressure3.TabIndex = 53;
            this.labelPressure3.Text = "0.0 bar";
            // 
            // progressPressure3
            // 
            this.progressPressure3.Location = new System.Drawing.Point(46, 360);
            this.progressPressure3.Name = "progressPressure3";
            this.progressPressure3.Size = new System.Drawing.Size(141, 23);
            this.progressPressure3.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 360);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 25);
            this.label20.TabIndex = 54;
            this.label20.Text = "P3";
            // 
            // labelPressure2
            // 
            this.labelPressure2.AutoSize = true;
            this.labelPressure2.Location = new System.Drawing.Point(190, 146);
            this.labelPressure2.Name = "labelPressure2";
            this.labelPressure2.Size = new System.Drawing.Size(40, 13);
            this.labelPressure2.TabIndex = 50;
            this.labelPressure2.Text = "0.0 bar";
            // 
            // progressPressure2
            // 
            this.progressPressure2.Location = new System.Drawing.Point(46, 137);
            this.progressPressure2.Name = "progressPressure2";
            this.progressPressure2.Size = new System.Drawing.Size(141, 23);
            this.progressPressure2.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 25);
            this.label18.TabIndex = 51;
            this.label18.Text = "P2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 5);
            this.panel5.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "V1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "V4";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "V3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "P1";
            // 
            // btnToggleValve4
            // 
            this.btnToggleValve4.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve4.Location = new System.Drawing.Point(46, 400);
            this.btnToggleValve4.Name = "btnToggleValve4";
            this.btnToggleValve4.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve4.TabIndex = 47;
            this.btnToggleValve4.Text = "CLOSE";
            this.btnToggleValve4.UseVisualStyleBackColor = false;
            this.btnToggleValve4.Click += new System.EventHandler(this.btnToggleValve4_Click);
            // 
            // btnToggleValve3
            // 
            this.btnToggleValve3.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve3.Location = new System.Drawing.Point(46, 329);
            this.btnToggleValve3.Name = "btnToggleValve3";
            this.btnToggleValve3.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve3.TabIndex = 46;
            this.btnToggleValve3.Text = "CLOSE";
            this.btnToggleValve3.UseVisualStyleBackColor = false;
            this.btnToggleValve3.Click += new System.EventHandler(this.btnToggleValve3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "V2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel3);
            this.groupBox7.Location = new System.Drawing.Point(599, 250);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(297, 761);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "BLUE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 741);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 731);
            this.panel4.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(438, 498);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 25);
            this.label21.TabIndex = 47;
            this.label21.Text = "P1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(532, 426);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 25);
            this.label22.TabIndex = 48;
            this.label22.Text = "P3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(344, 430);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 25);
            this.label23.TabIndex = 49;
            this.label23.Text = "P2";
            // 
            // TankLabel1
            // 
            this.TankLabel1.AutoSize = true;
            this.TankLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankLabel1.Location = new System.Drawing.Point(201, 170);
            this.TankLabel1.Name = "TankLabel1";
            this.TankLabel1.Size = new System.Drawing.Size(36, 25);
            this.TankLabel1.TabIndex = 39;
            this.TankLabel1.Text = "T1";
            // 
            // TankLabel2
            // 
            this.TankLabel2.AutoSize = true;
            this.TankLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankLabel2.Location = new System.Drawing.Point(201, 389);
            this.TankLabel2.Name = "TankLabel2";
            this.TankLabel2.Size = new System.Drawing.Size(36, 25);
            this.TankLabel2.TabIndex = 39;
            this.TankLabel2.Text = "T2";
            // 
            // trackServoValue2
            // 
            this.trackServoValue2.Location = new System.Drawing.Point(141, 91);
            this.trackServoValue2.Maximum = 100;
            this.trackServoValue2.Name = "trackServoValue2";
            this.trackServoValue2.Size = new System.Drawing.Size(141, 69);
            this.trackServoValue2.TabIndex = 36;
            this.trackServoValue2.Scroll += new System.EventHandler(this.trackServoValue2_Scroll);
            // 
            // lblServoValue2
            // 
            this.lblServoValue2.AutoSize = true;
            this.lblServoValue2.Location = new System.Drawing.Point(49, 121);
            this.lblServoValue2.Name = "lblServoValue2";
            this.lblServoValue2.Size = new System.Drawing.Size(62, 13);
            this.lblServoValue2.TabIndex = 55;
            this.lblServoValue2.Text = "ServoValue";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2369, 1211);
            this.Controls.Add(this.lblInternetStatus);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lblPiStatus);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TelemetriaGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astria Porta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelFuelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListView listView1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button btnConnectCom;
        private System.Windows.Forms.TextBox textBoxTerminal;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnToggleValve1;
        private System.Windows.Forms.Button btnToggleValve2;
        private System.Windows.Forms.ProgressBar progressPressure1;
        private System.Windows.Forms.Label labelPressure1;
        private System.Windows.Forms.ProgressBar progressFuel;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.GroupBox TelemetriaGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.Label PressureLabel6;
        private System.Windows.Forms.Label PressureLabel5;
        private System.Windows.Forms.Label PressureLabel4;
        private System.Windows.Forms.Label PressureLabel3;
        private System.Windows.Forms.Label PressureLabel2;
        private System.Windows.Forms.Label PressureLabel1;
        private System.Windows.Forms.Panel panelValveIndicator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelFuelContainer;
        private System.Windows.Forms.Panel panelFuelLevel;
        private System.Windows.Forms.Panel panelValveIndicator4;
        private System.Windows.Forms.Panel panelValveIndicator5;
        private System.Windows.Forms.Panel panelValveIndicator6;
        private System.Windows.Forms.Panel panelValveIndicator2;
        private System.Windows.Forms.Panel panelValveIndicator3;
        private System.Windows.Forms.Panel panelValveIndicator7;
        private System.Windows.Forms.Panel panelValveIndicator8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblInternetStatus;
        private System.Windows.Forms.Label lblPiStatus;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.TrackBar trackServoValue1;
        private System.Windows.Forms.Label lblServoValue1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnToggleValve4;
        private System.Windows.Forms.Button btnToggleValve3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelPressure2;
        private System.Windows.Forms.ProgressBar progressPressure2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelPressure3;
        private System.Windows.Forms.ProgressBar progressPressure3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label TankLabel2;
        private System.Windows.Forms.Label TankLabel1;
        private System.Windows.Forms.TrackBar trackServoValue2;
        private System.Windows.Forms.Label lblServoValue2;
    }
}

