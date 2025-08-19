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
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.btnToggleValve1 = new System.Windows.Forms.Button();
            this.btnToggleValve2 = new System.Windows.Forms.Button();
            this.progressPressure1 = new System.Windows.Forms.ProgressBar();
            this.labelPressure1 = new System.Windows.Forms.Label();
            this.progressFuel = new System.Windows.Forms.ProgressBar();
            this.labelFuel = new System.Windows.Forms.Label();
            this.TelemetriaGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TankLabel2 = new System.Windows.Forms.Label();
            this.panelValveIndicator3 = new System.Windows.Forms.Panel();
            this.TankLabel1 = new System.Windows.Forms.Label();
            this.panelValveIndicator2 = new System.Windows.Forms.Panel();
            this.panelValveIndicator7 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panelValveIndicator6 = new System.Windows.Forms.Panel();
            this.panelValveIndicator8 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panelValveIndicator5 = new System.Windows.Forms.Panel();
            this.panelValveIndicator1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panelValveIndicator4 = new System.Windows.Forms.Panel();
            this.PressureLabel6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PressureLabel5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PressureLabel4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PressureLabel3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PressureLabel2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PressureLabel1 = new System.Windows.Forms.Label();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFuelContainer = new System.Windows.Forms.Panel();
            this.panelFuelLevel = new System.Windows.Forms.Panel();
            this.lblInternetStatus = new System.Windows.Forms.Label();
            this.lblPiStatus = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.trackServoValue1 = new System.Windows.Forms.TrackBar();
            this.lblServoValue1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblServoValue2 = new System.Windows.Forms.Label();
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
            this.trackServoValue2 = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelPressure6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnToggleValve8 = new System.Windows.Forms.Button();
            this.progressPressure6 = new System.Windows.Forms.ProgressBar();
            this.label31 = new System.Windows.Forms.Label();
            this.lblServoValue6 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnToggleValve7 = new System.Windows.Forms.Button();
            this.labelPressure5 = new System.Windows.Forms.Label();
            this.lblServoValue5 = new System.Windows.Forms.Label();
            this.progressPressure5 = new System.Windows.Forms.ProgressBar();
            this.btnToggleValve5 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.labelPressure4 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.trackServoValue5 = new System.Windows.Forms.TrackBar();
            this.btnToggleValve6 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.trackServoValue6 = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.progressPressure4 = new System.Windows.Forms.ProgressBar();
            this.scriptEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFuelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue6)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 872);
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.serialToolStripMenuItem,
            this.scriptEditorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2});
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.serialToolStripMenuItem.Text = "Serial";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
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
            this.progressFuel.Location = new System.Drawing.Point(8, 454);
            this.progressFuel.Name = "progressFuel";
            this.progressFuel.Size = new System.Drawing.Size(141, 23);
            this.progressFuel.TabIndex = 27;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(43, 295);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(21, 13);
            this.labelFuel.TabIndex = 28;
            this.labelFuel.Text = "0%";
            // 
            // TelemetriaGroupBox
            // 
            this.TelemetriaGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TelemetriaGroupBox.Location = new System.Drawing.Point(-210, 732);
            this.TelemetriaGroupBox.Name = "TelemetriaGroupBox";
            this.TelemetriaGroupBox.Size = new System.Drawing.Size(200, 198);
            this.TelemetriaGroupBox.TabIndex = 29;
            this.TelemetriaGroupBox.TabStop = false;
            this.TelemetriaGroupBox.Text = "Telemetria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TankLabel2);
            this.groupBox2.Controls.Add(this.panelValveIndicator3);
            this.groupBox2.Controls.Add(this.TankLabel1);
            this.groupBox2.Controls.Add(this.panelValveIndicator2);
            this.groupBox2.Controls.Add(this.panelValveIndicator7);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.panelValveIndicator6);
            this.groupBox2.Controls.Add(this.panelValveIndicator8);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.panelValveIndicator5);
            this.groupBox2.Controls.Add(this.panelValveIndicator1);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.panelValveIndicator4);
            this.groupBox2.Controls.Add(this.PressureLabel6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PressureLabel5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PressureLabel4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PressureLabel3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PressureLabel2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PressureLabel1);
            this.groupBox2.Controls.Add(this.pictureBackground);
            this.groupBox2.Location = new System.Drawing.Point(516, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 564);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visual Control";
            // 
            // TankLabel2
            // 
            this.TankLabel2.AutoSize = true;
            this.TankLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankLabel2.Location = new System.Drawing.Point(195, 386);
            this.TankLabel2.Name = "TankLabel2";
            this.TankLabel2.Size = new System.Drawing.Size(25, 17);
            this.TankLabel2.TabIndex = 39;
            this.TankLabel2.Text = "T2";
            // 
            // panelValveIndicator3
            // 
            this.panelValveIndicator3.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator3.Location = new System.Drawing.Point(606, 157);
            this.panelValveIndicator3.Name = "panelValveIndicator3";
            this.panelValveIndicator3.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator3.TabIndex = 33;
            // 
            // TankLabel1
            // 
            this.TankLabel1.AutoSize = true;
            this.TankLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankLabel1.Location = new System.Drawing.Point(195, 167);
            this.TankLabel1.Name = "TankLabel1";
            this.TankLabel1.Size = new System.Drawing.Size(25, 17);
            this.TankLabel1.TabIndex = 39;
            this.TankLabel1.Text = "T1";
            // 
            // panelValveIndicator2
            // 
            this.panelValveIndicator2.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator2.Location = new System.Drawing.Point(91, 157);
            this.panelValveIndicator2.Name = "panelValveIndicator2";
            this.panelValveIndicator2.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator2.TabIndex = 33;
            // 
            // panelValveIndicator7
            // 
            this.panelValveIndicator7.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator7.Location = new System.Drawing.Point(606, 409);
            this.panelValveIndicator7.Name = "panelValveIndicator7";
            this.panelValveIndicator7.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator7.TabIndex = 33;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(338, 427);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 17);
            this.label23.TabIndex = 49;
            this.label23.Text = "P2";
            // 
            // panelValveIndicator6
            // 
            this.panelValveIndicator6.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator6.Location = new System.Drawing.Point(91, 409);
            this.panelValveIndicator6.Name = "panelValveIndicator6";
            this.panelValveIndicator6.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator6.TabIndex = 33;
            // 
            // panelValveIndicator8
            // 
            this.panelValveIndicator8.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator8.Location = new System.Drawing.Point(378, 477);
            this.panelValveIndicator8.Name = "panelValveIndicator8";
            this.panelValveIndicator8.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator8.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(526, 423);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 17);
            this.label22.TabIndex = 48;
            this.label22.Text = "P3";
            // 
            // panelValveIndicator5
            // 
            this.panelValveIndicator5.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator5.Location = new System.Drawing.Point(73, 343);
            this.panelValveIndicator5.Name = "panelValveIndicator5";
            this.panelValveIndicator5.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator5.TabIndex = 33;
            // 
            // panelValveIndicator1
            // 
            this.panelValveIndicator1.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator1.Location = new System.Drawing.Point(378, 91);
            this.panelValveIndicator1.Name = "panelValveIndicator1";
            this.panelValveIndicator1.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator1.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(432, 495);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 17);
            this.label21.TabIndex = 47;
            this.label21.Text = "P1";
            // 
            // panelValveIndicator4
            // 
            this.panelValveIndicator4.BackColor = System.Drawing.Color.IndianRed;
            this.panelValveIndicator4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValveIndicator4.Location = new System.Drawing.Point(73, 224);
            this.panelValveIndicator4.Name = "panelValveIndicator4";
            this.panelValveIndicator4.Size = new System.Drawing.Size(15, 15);
            this.panelValveIndicator4.TabIndex = 33;
            // 
            // PressureLabel6
            // 
            this.PressureLabel6.AutoSize = true;
            this.PressureLabel6.Location = new System.Drawing.Point(527, 395);
            this.PressureLabel6.Name = "PressureLabel6";
            this.PressureLabel6.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel6.TabIndex = 34;
            this.PressureLabel6.Text = "label6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(526, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "P3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "V1";
            // 
            // PressureLabel5
            // 
            this.PressureLabel5.AutoSize = true;
            this.PressureLabel5.Location = new System.Drawing.Point(433, 462);
            this.PressureLabel5.Name = "PressureLabel5";
            this.PressureLabel5.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel5.TabIndex = 33;
            this.PressureLabel5.Text = "label5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(338, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 45;
            this.label15.Text = "P2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "V2";
            // 
            // PressureLabel4
            // 
            this.PressureLabel4.AutoSize = true;
            this.PressureLabel4.Location = new System.Drawing.Point(340, 395);
            this.PressureLabel4.Name = "PressureLabel4";
            this.PressureLabel4.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel4.TabIndex = 32;
            this.PressureLabel4.Text = "label4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "P1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "V3";
            // 
            // PressureLabel3
            // 
            this.PressureLabel3.AutoSize = true;
            this.PressureLabel3.Location = new System.Drawing.Point(527, 176);
            this.PressureLabel3.Name = "PressureLabel3";
            this.PressureLabel3.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel3.TabIndex = 31;
            this.PressureLabel3.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(602, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "V3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "V4";
            // 
            // PressureLabel2
            // 
            this.PressureLabel2.AutoSize = true;
            this.PressureLabel2.Location = new System.Drawing.Point(448, 108);
            this.PressureLabel2.Name = "PressureLabel2";
            this.PressureLabel2.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel2.TabIndex = 30;
            this.PressureLabel2.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "V1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "V4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "V2";
            // 
            // PressureLabel1
            // 
            this.PressureLabel1.AutoSize = true;
            this.PressureLabel1.Location = new System.Drawing.Point(340, 176);
            this.PressureLabel1.Name = "PressureLabel1";
            this.PressureLabel1.Size = new System.Drawing.Size(35, 13);
            this.PressureLabel1.TabIndex = 29;
            this.PressureLabel1.Text = "label1";
            // 
            // pictureBackground
            // 
            this.pictureBackground.Image = global::SterowanieStanowiskiem.Properties.Resources.model8;
            this.pictureBackground.Location = new System.Drawing.Point(0, 19);
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
            // panelFuelContainer
            // 
            this.panelFuelContainer.BackColor = System.Drawing.Color.LightGray;
            this.panelFuelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuelContainer.Controls.Add(this.panelFuelLevel);
            this.panelFuelContainer.Location = new System.Drawing.Point(7, 171);
            this.panelFuelContainer.Name = "panelFuelContainer";
            this.panelFuelContainer.Size = new System.Drawing.Size(35, 138);
            this.panelFuelContainer.TabIndex = 25;
            // 
            // panelFuelLevel
            // 
            this.panelFuelLevel.BackColor = System.Drawing.Color.Green;
            this.panelFuelLevel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFuelLevel.Location = new System.Drawing.Point(0, -1);
            this.panelFuelLevel.Name = "panelFuelLevel";
            this.panelFuelLevel.Size = new System.Drawing.Size(33, 137);
            this.panelFuelLevel.TabIndex = 33;
            // 
            // lblInternetStatus
            // 
            this.lblInternetStatus.AutoSize = true;
            this.lblInternetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternetStatus.Location = new System.Drawing.Point(707, 1160);
            this.lblInternetStatus.Name = "lblInternetStatus";
            this.lblInternetStatus.Size = new System.Drawing.Size(72, 17);
            this.lblInternetStatus.TabIndex = 1;
            this.lblInternetStatus.Text = "Internet: ?";
            // 
            // lblPiStatus
            // 
            this.lblPiStatus.AutoSize = true;
            this.lblPiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiStatus.Location = new System.Drawing.Point(707, 1123);
            this.lblPiStatus.Name = "lblPiStatus";
            this.lblPiStatus.Size = new System.Drawing.Size(80, 17);
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
            this.trackServoValue1.Size = new System.Drawing.Size(90, 45);
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
            this.groupBox6.Location = new System.Drawing.Point(12, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 533);
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
            this.panel1.Size = new System.Drawing.Size(246, 513);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.progressFuel);
            this.panel2.Controls.Add(this.labelFuel);
            this.panel2.Controls.Add(this.panelFuelContainer);
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
            this.panel2.Size = new System.Drawing.Size(236, 500);
            this.panel2.TabIndex = 0;
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
            this.label20.Size = new System.Drawing.Size(25, 17);
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
            this.label18.Size = new System.Drawing.Size(25, 17);
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
            this.label9.Size = new System.Drawing.Size(25, 17);
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
            this.label12.Size = new System.Drawing.Size(25, 17);
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
            this.label11.Size = new System.Drawing.Size(25, 17);
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
            this.label14.Size = new System.Drawing.Size(25, 17);
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
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "V2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackServoValue2
            // 
            this.trackServoValue2.Location = new System.Drawing.Point(141, 91);
            this.trackServoValue2.Maximum = 100;
            this.trackServoValue2.Name = "trackServoValue2";
            this.trackServoValue2.Size = new System.Drawing.Size(90, 45);
            this.trackServoValue2.TabIndex = 36;
            this.trackServoValue2.Scroll += new System.EventHandler(this.trackServoValue2_Scroll);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel3);
            this.groupBox7.Location = new System.Drawing.Point(264, 140);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(246, 533);
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
            this.panel3.Size = new System.Drawing.Size(246, 513);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.labelPressure6);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.btnToggleValve8);
            this.panel4.Controls.Add(this.progressPressure6);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.lblServoValue6);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.btnToggleValve7);
            this.panel4.Controls.Add(this.labelPressure5);
            this.panel4.Controls.Add(this.lblServoValue5);
            this.panel4.Controls.Add(this.progressPressure5);
            this.panel4.Controls.Add(this.btnToggleValve5);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.labelPressure4);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.trackServoValue5);
            this.panel4.Controls.Add(this.btnToggleValve6);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.trackServoValue6);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.progressPressure4);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 500);
            this.panel4.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(0, 429);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 5);
            this.panel11.TabIndex = 49;
            // 
            // labelPressure6
            // 
            this.labelPressure6.AutoSize = true;
            this.labelPressure6.Location = new System.Drawing.Point(196, 369);
            this.labelPressure6.Name = "labelPressure6";
            this.labelPressure6.Size = new System.Drawing.Size(40, 13);
            this.labelPressure6.TabIndex = 59;
            this.labelPressure6.Text = "0.0 bar";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(0, 389);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(286, 5);
            this.panel12.TabIndex = 48;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(9, 396);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 17);
            this.label33.TabIndex = 50;
            this.label33.Text = "V4";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(0, 315);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(286, 5);
            this.panel10.TabIndex = 41;
            // 
            // btnToggleValve8
            // 
            this.btnToggleValve8.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve8.Location = new System.Drawing.Point(52, 400);
            this.btnToggleValve8.Name = "btnToggleValve8";
            this.btnToggleValve8.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve8.TabIndex = 51;
            this.btnToggleValve8.Text = "CLOSE";
            this.btnToggleValve8.UseVisualStyleBackColor = false;
            this.btnToggleValve8.Click += new System.EventHandler(this.btnToggleValve8_Click);
            // 
            // progressPressure6
            // 
            this.progressPressure6.Location = new System.Drawing.Point(52, 360);
            this.progressPressure6.Name = "progressPressure6";
            this.progressPressure6.Size = new System.Drawing.Size(141, 23);
            this.progressPressure6.TabIndex = 58;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(10, 360);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 17);
            this.label31.TabIndex = 60;
            this.label31.Text = "P3";
            // 
            // lblServoValue6
            // 
            this.lblServoValue6.AutoSize = true;
            this.lblServoValue6.Location = new System.Drawing.Point(49, 119);
            this.lblServoValue6.Name = "lblServoValue6";
            this.lblServoValue6.Size = new System.Drawing.Size(62, 13);
            this.lblServoValue6.TabIndex = 62;
            this.lblServoValue6.Text = "ServoValue";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(9, 325);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 17);
            this.label32.TabIndex = 57;
            this.label32.Text = "V3";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(0, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(286, 5);
            this.panel9.TabIndex = 40;
            // 
            // btnToggleValve7
            // 
            this.btnToggleValve7.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve7.Location = new System.Drawing.Point(52, 329);
            this.btnToggleValve7.Name = "btnToggleValve7";
            this.btnToggleValve7.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve7.TabIndex = 56;
            this.btnToggleValve7.Text = "CLOSE";
            this.btnToggleValve7.UseVisualStyleBackColor = false;
            this.btnToggleValve7.Click += new System.EventHandler(this.btnToggleValve7_Click);
            // 
            // labelPressure5
            // 
            this.labelPressure5.AutoSize = true;
            this.labelPressure5.Location = new System.Drawing.Point(190, 144);
            this.labelPressure5.Name = "labelPressure5";
            this.labelPressure5.Size = new System.Drawing.Size(40, 13);
            this.labelPressure5.TabIndex = 60;
            this.labelPressure5.Text = "0.0 bar";
            // 
            // lblServoValue5
            // 
            this.lblServoValue5.AutoSize = true;
            this.lblServoValue5.Location = new System.Drawing.Point(49, 33);
            this.lblServoValue5.Name = "lblServoValue5";
            this.lblServoValue5.Size = new System.Drawing.Size(62, 13);
            this.lblServoValue5.TabIndex = 60;
            this.lblServoValue5.Text = "ServoValue";
            // 
            // progressPressure5
            // 
            this.progressPressure5.Location = new System.Drawing.Point(46, 135);
            this.progressPressure5.Name = "progressPressure5";
            this.progressPressure5.Size = new System.Drawing.Size(141, 23);
            this.progressPressure5.TabIndex = 59;
            // 
            // btnToggleValve5
            // 
            this.btnToggleValve5.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve5.Location = new System.Drawing.Point(46, 7);
            this.btnToggleValve5.Name = "btnToggleValve5";
            this.btnToggleValve5.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve5.TabIndex = 56;
            this.btnToggleValve5.Text = "CLOSE";
            this.btnToggleValve5.UseVisualStyleBackColor = false;
            this.btnToggleValve5.Click += new System.EventHandler(this.btnToggleValve5_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(4, 135);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 17);
            this.label28.TabIndex = 61;
            this.label28.Text = "P2";
            // 
            // labelPressure4
            // 
            this.labelPressure4.AutoSize = true;
            this.labelPressure4.Location = new System.Drawing.Point(190, 58);
            this.labelPressure4.Name = "labelPressure4";
            this.labelPressure4.Size = new System.Drawing.Size(40, 13);
            this.labelPressure4.TabIndex = 58;
            this.labelPressure4.Text = "0.0 bar";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(4, 87);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 17);
            this.label29.TabIndex = 58;
            this.label29.Text = "V2";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackServoValue5
            // 
            this.trackServoValue5.Location = new System.Drawing.Point(141, 3);
            this.trackServoValue5.Maximum = 100;
            this.trackServoValue5.Name = "trackServoValue5";
            this.trackServoValue5.Size = new System.Drawing.Size(90, 45);
            this.trackServoValue5.TabIndex = 59;
            this.trackServoValue5.Scroll += new System.EventHandler(this.trackServoValue5_Scroll);
            // 
            // btnToggleValve6
            // 
            this.btnToggleValve6.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve6.Location = new System.Drawing.Point(46, 89);
            this.btnToggleValve6.Name = "btnToggleValve6";
            this.btnToggleValve6.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve6.TabIndex = 56;
            this.btnToggleValve6.Text = "CLOSE";
            this.btnToggleValve6.UseVisualStyleBackColor = false;
            this.btnToggleValve6.Click += new System.EventHandler(this.btnToggleValve6_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 17);
            this.label24.TabIndex = 61;
            this.label24.Text = "V1";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackServoValue6
            // 
            this.trackServoValue6.Location = new System.Drawing.Point(141, 89);
            this.trackServoValue6.Maximum = 100;
            this.trackServoValue6.Name = "trackServoValue6";
            this.trackServoValue6.Size = new System.Drawing.Size(90, 45);
            this.trackServoValue6.TabIndex = 57;
            this.trackServoValue6.Scroll += new System.EventHandler(this.trackServoValue6_Scroll);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(4, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 17);
            this.label25.TabIndex = 62;
            this.label25.Text = "P1";
            // 
            // progressPressure4
            // 
            this.progressPressure4.Location = new System.Drawing.Point(46, 49);
            this.progressPressure4.Name = "progressPressure4";
            this.progressPressure4.Size = new System.Drawing.Size(141, 23);
            this.progressPressure4.TabIndex = 57;
            // 
            // scriptEditorToolStripMenuItem
            // 
            this.scriptEditorToolStripMenuItem.Name = "scriptEditorToolStripMenuItem";
            this.scriptEditorToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.scriptEditorToolStripMenuItem.Text = "Script Editor";
            this.scriptEditorToolStripMenuItem.Click += new System.EventHandler(this.scriptEditorToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.lblInternetStatus);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lblPiStatus);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TelemetriaGroupBox);
            this.Controls.Add(this.groupBox1);
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
            this.panelFuelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackServoValue6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panelFuelContainer;
        private System.Windows.Forms.Panel panelFuelLevel;
        private System.Windows.Forms.Panel panelValveIndicator4;
        private System.Windows.Forms.Panel panelValveIndicator5;
        private System.Windows.Forms.Panel panelValveIndicator6;
        private System.Windows.Forms.Panel panelValveIndicator2;
        private System.Windows.Forms.Panel panelValveIndicator3;
        private System.Windows.Forms.Panel panelValveIndicator7;
        private System.Windows.Forms.Panel panelValveIndicator8;
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
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label labelPressure6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnToggleValve8;
        private System.Windows.Forms.ProgressBar progressPressure6;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblServoValue6;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnToggleValve7;
        private System.Windows.Forms.Label labelPressure5;
        private System.Windows.Forms.Label lblServoValue5;
        private System.Windows.Forms.ProgressBar progressPressure5;
        private System.Windows.Forms.Button btnToggleValve5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelPressure4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TrackBar trackServoValue5;
        private System.Windows.Forms.Button btnToggleValve6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar trackServoValue6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ProgressBar progressPressure4;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem scriptEditorToolStripMenuItem;
    }
}

