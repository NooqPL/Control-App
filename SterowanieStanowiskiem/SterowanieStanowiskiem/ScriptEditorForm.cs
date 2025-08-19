using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SterowanieStanowiskiem
{
    public partial class ScriptEditorForm : Form
    {
        private string scriptsPath;
        private MainWindow mainForm;

        public ScriptEditorForm(MainWindow form)
        {
            InitializeComponent();
            mainForm = form;

            scriptsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "SterowanieStanowiskiem", "Scripts"
            );

            if (!Directory.Exists(scriptsPath))
                Directory.CreateDirectory(scriptsPath);

            LoadScriptList();
        }

        private void ScriptEditorForm_Load(object sender, EventArgs e)
        {
            if (comboBoxScripts.Items.Count > 0)
                comboBoxScripts.SelectedIndex = 0;
        }

        private void LoadScriptList()
        {
            comboBoxScripts.Items.Clear();
            var files = Directory.GetFiles(scriptsPath, "*.myscript");
            foreach (var file in files)
            {
                comboBoxScripts.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            comboBoxScripts.Text = "";
            richTextBox1.Clear();
            this.Text = "Script Editor - New Script";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = comboBoxScripts.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a script name.");
                return;
            }

            string filePath = Path.Combine(scriptsPath, name + ".myscript");
            File.WriteAllText(filePath, richTextBox1.Text);

            LoadScriptList();
            comboBoxScripts.SelectedItem = name;
            this.Text = "Script Editor - " + name;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string name = comboBoxScripts.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please select a script to load.");
                return;
            }

            string filePath = Path.Combine(scriptsPath, name + ".myscript");
            if (File.Exists(filePath))
            {
                richTextBox1.Text = File.ReadAllText(filePath);
                this.Text = "Script Editor - " + name;
            }
            else
            {
                MessageBox.Show("Script not found.");
            }
        }

        private async void btnRunTest_Click(object sender, EventArgs e)
        {
            richTextBoxSimulation.Clear();
            await RunScriptAsync(richTextBox1.Text, false);
        }

        private async void btnRunLive_Click(object sender, EventArgs e)
        {
            richTextBoxSimulation.Clear();
            await RunScriptAsync(richTextBox1.Text, true);
        }


        private async Task RunScriptAsync(string scriptText, bool live)
        {
            // Split on both \r\n and \n to handle all cases
            string[] lines = scriptText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmedLine)) continue;

                string[] parts = trimmedLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0].ToUpper();

                switch (command)
                {
                    case "VALVE":
                        if (parts.Length >= 3)
                        {
                            string valve = parts[1].ToUpper();
                            string action = parts[2].ToUpper();

                            if (live)
                            {
                                bool? desiredState = null;

                                switch (action.ToUpper())
                                {
                                    case "ON":
                                        desiredState = true;
                                        break;
                                    case "OFF":
                                        desiredState = false;
                                        break;
                                    case "TOGGLE":
                                        desiredState = null; // means flip current state
                                        break;
                                    default:
                                        AppendSimulationLog($"Unknown valve action: {action}");
                                        continue; // skip this line
                                }


                                switch (valve)
                                {
                                    case "RED1":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve1State(desiredState.Value);
                                        else
                                            mainForm.SetValve1State(!mainForm.isValve1Open);
                                        break;

                                    case "RED2":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve2State(desiredState.Value);
                                        else
                                            mainForm.SetValve2State(!mainForm.isValve2Open);
                                        break;
                                    case "RED3":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve3State(desiredState.Value);
                                        else
                                            mainForm.SetValve3State(!mainForm.isValve3Open);
                                        break;

                                    case "RED4":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve4State(desiredState.Value);
                                        else
                                            mainForm.SetValve4State(!mainForm.isValve4Open);
                                        break;
                                    case "BLUE1":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve5State(desiredState.Value);
                                        else
                                            mainForm.SetValve5State(!mainForm.isValve5Open);
                                        break;

                                    case "BLUE2":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve6State(desiredState.Value);
                                        else
                                            mainForm.SetValve6State(!mainForm.isValve6Open);
                                        break;
                                    case "BLUE3":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve7State(desiredState.Value);
                                        else
                                            mainForm.SetValve7State(!mainForm.isValve7Open);
                                        break;

                                    case "BLUE4":
                                        if (desiredState.HasValue)
                                            mainForm.SetValve8State(desiredState.Value);
                                        else
                                            mainForm.SetValve8State(!mainForm.isValve8Open);
                                        break;


                                    // add more valves here
                                    default:
                                        AppendSimulationLog($"Unknown valve: {valve}");
                                        break;
                                }
                            }
                            else
                            {
                                AppendSimulationLog($"Simulate: Valve {valve} -> {action}");
                            }
                        }
                        break;



                    case "SERVO1":
                    case "SERVO2":
                    case "SERVO3":
                    case "SERVO4":
                        if (parts.Length >= 2 && int.TryParse(parts[1], out int servoValue))
                        {
                            if (live)
                            {
                                switch (command)
                                {
                                    case "SERVO1": mainForm.SetServo1(servoValue); break;
                                    case "SERVO2": mainForm.SetServo2(servoValue); break;
                                    case "SERVO3": mainForm.SetServo3(servoValue); break;
                                    case "SERVO4": mainForm.SetServo4(servoValue); break;
                                }
                                
                            }
                            else
                            {
                                AppendSimulationLog($"Simulate: {command} {servoValue}%");
                            }
                        }
                        break;

                    case "WAIT":
                        if (parts.Length >= 2 && int.TryParse(parts[1], out int ms))
                        {
                            if (!live) 
                                AppendSimulationLog($"Simulate: WAIT {ms} ms");
                             await Task.Delay(ms);
                            
                        }
                        else
                        {
                            AppendSimulationLog("WAIT command missing milliseconds");
                        }
                        break;

                    default:
                        AppendSimulationLog($"Unknown command: {trimmedLine}");
                        break;
                }
            }
        }

        private void AppendSimulationLog(string text)
        {
            if (richTextBoxSimulation.InvokeRequired)
                richTextBoxSimulation.Invoke(new Action(() => richTextBoxSimulation.AppendText(text + Environment.NewLine)));
            else
                richTextBoxSimulation.AppendText(text + Environment.NewLine);
        }


        


    }
}