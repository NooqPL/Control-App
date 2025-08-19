namespace SterowanieStanowiskiem
{
    partial class ScriptEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditorForm));
            this.comboBoxScripts = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.btnRunLive = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.richTextBoxSimulation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxScripts
            // 
            this.comboBoxScripts.FormattingEnabled = true;
            this.comboBoxScripts.Location = new System.Drawing.Point(12, 38);
            this.comboBoxScripts.Name = "comboBoxScripts";
            this.comboBoxScripts.Size = new System.Drawing.Size(156, 21);
            this.comboBoxScripts.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 469);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(255, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRunTest
            // 
            this.btnRunTest.Location = new System.Drawing.Point(12, 65);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunTest.TabIndex = 4;
            this.btnRunTest.Text = "RunTest";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // btnRunLive
            // 
            this.btnRunLive.Location = new System.Drawing.Point(93, 65);
            this.btnRunLive.Name = "btnRunLive";
            this.btnRunLive.Size = new System.Drawing.Size(75, 23);
            this.btnRunLive.TabIndex = 5;
            this.btnRunLive.Text = "RunLive";
            this.btnRunLive.UseVisualStyleBackColor = true;
            this.btnRunLive.Click += new System.EventHandler(this.btnRunLive_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(174, 65);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New Script";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // richTextBoxSimulation
            // 
            this.richTextBoxSimulation.Location = new System.Drawing.Point(374, 94);
            this.richTextBoxSimulation.Name = "richTextBoxSimulation";
            this.richTextBoxSimulation.Size = new System.Drawing.Size(318, 469);
            this.richTextBoxSimulation.TabIndex = 7;
            this.richTextBoxSimulation.Text = "";
            // 
            // ScriptEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 573);
            this.Controls.Add(this.richTextBoxSimulation);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRunLive);
            this.Controls.Add(this.btnRunTest);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBoxScripts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptEditorForm";
            this.Text = "Astra Porta - (Script Editor)";
            this.Load += new System.EventHandler(this.ScriptEditorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxScripts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.Button btnRunLive;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RichTextBox richTextBoxSimulation;
    }
}