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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.progressPressure = new System.Windows.Forms.ProgressBar();
            this.labelPressure = new System.Windows.Forms.Label();
            this.progressFuel = new System.Windows.Forms.ProgressBar();
            this.labelFuel = new System.Windows.Forms.Label();
            this.TelemetriaGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TelemetriaGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelFuelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 250);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(195, 214);
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2369, 24);
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
            // btnToggleValve1
            // 
            this.btnToggleValve1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleValve1.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve1.Location = new System.Drawing.Point(119, 206);
            this.btnToggleValve1.Name = "btnToggleValve1";
            this.btnToggleValve1.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve1.TabIndex = 23;
            this.btnToggleValve1.Text = "CLOSE";
            this.btnToggleValve1.UseVisualStyleBackColor = false;
            this.btnToggleValve1.Click += new System.EventHandler(this.btnToggleValve1_Click);
            // 
            // btnToggleValve2
            // 
            this.btnToggleValve2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleValve2.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleValve2.Location = new System.Drawing.Point(6, 206);
            this.btnToggleValve2.Name = "btnToggleValve2";
            this.btnToggleValve2.Size = new System.Drawing.Size(75, 23);
            this.btnToggleValve2.TabIndex = 24;
            this.btnToggleValve2.Text = "CLOSE";
            this.btnToggleValve2.UseVisualStyleBackColor = false;
            this.btnToggleValve2.Click += new System.EventHandler(this.btnToggleValve2_Click);
            // 
            // progressPressure
            // 
            this.progressPressure.Location = new System.Drawing.Point(6, 19);
            this.progressPressure.Name = "progressPressure";
            this.progressPressure.Size = new System.Drawing.Size(141, 23);
            this.progressPressure.TabIndex = 25;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(153, 29);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(40, 13);
            this.labelPressure.TabIndex = 26;
            this.labelPressure.Text = "0.0 bar";
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
            this.TelemetriaGroupBox.Controls.Add(this.progressPressure);
            this.TelemetriaGroupBox.Controls.Add(this.labelPressure);
            this.TelemetriaGroupBox.Location = new System.Drawing.Point(175, 825);
            this.TelemetriaGroupBox.Name = "TelemetriaGroupBox";
            this.TelemetriaGroupBox.Size = new System.Drawing.Size(195, 198);
            this.TelemetriaGroupBox.TabIndex = 29;
            this.TelemetriaGroupBox.TabStop = false;
            this.TelemetriaGroupBox.Text = "Telemetria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelValveIndicator1);
            this.groupBox2.Controls.Add(this.PressureLabel6);
            this.groupBox2.Controls.Add(this.PressureLabel5);
            this.groupBox2.Controls.Add(this.PressureLabel4);
            this.groupBox2.Controls.Add(this.PressureLabel3);
            this.groupBox2.Controls.Add(this.PressureLabel2);
            this.groupBox2.Controls.Add(this.PressureLabel1);
            this.groupBox2.Controls.Add(this.pictureBackground);
            this.groupBox2.Location = new System.Drawing.Point(803, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 573);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visual Control";
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
            this.groupBox3.Controls.Add(this.btnToggleValve1);
            this.groupBox3.Controls.Add(this.btnToggleValve2);
            this.groupBox3.Location = new System.Drawing.Point(378, 252);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2369, 1211);
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
            this.TelemetriaGroupBox.ResumeLayout(false);
            this.TelemetriaGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelFuelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.ProgressBar progressPressure;
        private System.Windows.Forms.Label labelPressure;
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
    }
}

