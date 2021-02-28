using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftSensConf
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        string config;
        string[] configs = new string[5];
        string command;


        private void timerConnected_Tick(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                labelConnect.Text = "Connected";
                labelConnect.ForeColor = Color.Green;
            }
            else
            {
                labelConnect.Text = "Not connected";
                labelConnect.ForeColor = Color.Red;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBoxComPort.Items.Clear();
            toolStripStatusLabelSSC.Text = "Select which port to connect to.";
            foreach (var item in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBoxComPort.Items.Add(item);
            }
        }

        private void comboBoxBitRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortSSC.BaudRate = Convert.ToInt32(comboBoxBitRate.SelectedItem);
        }

        private void comboBoxComPort_MouseHover(object sender, EventArgs e)
        {
            toolTipSSC.SetToolTip(comboBoxComPort, "Select ComPort");
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect:
            try
            {
                serialPortSSC.Open();
                MessageBox.Show(string.Format("Succsessfully connected to port {0}!", serialPortSSC.PortName), "Connected!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelConnect.Text = "Connected";
                labelConnect.ForeColor = Color.Green;
            }
            catch (IOException)
            {
                string message = "";
                MessageBoxButtons buttons;
                MessageBoxIcon icon;

                comboBoxComPort.Items.Clear();
                foreach (var item in System.IO.Ports.SerialPort.GetPortNames())
                {
                    comboBoxComPort.Items.Add(item);
                }

                if (comboBoxComPort.Items.Count > 0)
                {
                    message = String.Format("ComPort {0} detected. Would you like to connect to this port?", comboBoxComPort.Items[0]);
                    buttons = MessageBoxButtons.OKCancel;
                    icon = MessageBoxIcon.Warning;
                }
                else
                {
                    message = "No ComPort detected. Make sure a device is plugged in. If this problem continues, please unplug and re-plug the device.";
                    buttons = MessageBoxButtons.OK;
                    icon = MessageBoxIcon.Error;
                }
                DialogResult result = MessageBox.Show(message, "No comport selected", buttons, icon);
                if (result == DialogResult.OK && comboBoxComPort.Items.Count > 0)
                {
                    comboBoxComPort.SelectedItem = comboBoxComPort.Items[0];
                    goto Connect;
                }
                
                //throw;
                
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("This port is already connected", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serialPortSSC.IsOpen)
            {
                serialPortSSC.PortName = comboBoxComPort.Text;
            }
        }

        private void tabPageConnection_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Select which port to connect to and the bit rate, then hit connect";
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                serialPortSSC.Close();
                MessageBox.Show("Succsessfully disconnected", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelConnect.Text = "Not connected";
                labelConnect.ForeColor = Color.Gray;
            }
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                tabControlSSC.SelectedTab = tabPageConfig;
            }
        }

        private void comboBoxComPort_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Select which port to connect to.";
        }

        private void comboBoxBitRate_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Select bitrate. Standard is 9600.";
        }

        private void buttonConnect_MouseEnter(object sender, EventArgs e)
        {
            string message = "";
            if (comboBoxComPort.Text.Length > 0)
            {
                message = " " + comboBoxComPort.Text;
            }
            toolStripStatusLabelSSC.Text = string.Format("Connect to port{0}.", message);
        }

        private void buttonDisconnect_MouseEnter(object sender, EventArgs e)
        {
            string message = "";
            if (serialPortSSC.IsOpen)
            {
                message = " " + serialPortSSC.PortName;
            }
            toolStripStatusLabelSSC.Text = string.Format("Disconnect from port{0}.", message);
        }

        private void buttonNext1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "If connected, moves to the configuration tab.";
        }

        private void comboBoxBitRate_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Select bitrate. Standard is 9600.";
        }

        private void buttonConnect_Enter(object sender, EventArgs e)
        {
            string message = "";
            if (comboBoxComPort.Text.Length > 0)
            {
                message = " " + comboBoxComPort.Text;
            }
            toolStripStatusLabelSSC.Text = string.Format("Connect to port{0}.", message);
        }

        private void buttonDisconnect_Enter(object sender, EventArgs e)
        {
            string message = "";
            if (serialPortSSC.IsOpen)
            {
                message = " " + serialPortSSC.PortName;
            }
            toolStripStatusLabelSSC.Text = string.Format("Disconnect from port{0}.", message);
        }

        private void buttonNext1_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "If connected, moves to the configuration tab.";
        }

        private void buttonReadConfig_Click(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                serialPortSSC.WriteLine("readconf");
                command = "readconf";
                timerReadSerial.Enabled = true;

            }
            else
            {
                MessageBox.Show("Connect to a device to use this function", "Connection needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonWriteConfig_Click(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                FormPrompt writeConfPrompt;
                DialogResult result = DialogResult.None;
                string promptString = "";

                while (promptString.Length < 8 && result != DialogResult.Cancel)
                {
                    writeConfPrompt = new FormPrompt();
                    writeConfPrompt.ShowDialog();
                    promptString = writeConfPrompt.promptText;
                    if (promptString.Length < 8)
                    {
                        result = MessageBox.Show("Password needs to be 8 characters long", "Password length incorrect", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    }
                }

                string[] tempConfs = new string[5];
                tempConfs[0] = textBoxName.Text;
                tempConfs[1] = textBoxlrv.Text;
                tempConfs[2] = textBoxurv.Text;
                tempConfs[3] = textBoxAlarml.Text;
                tempConfs[4] = textBoxAlarmh.Text;

                command = "writeconf";
                string confWriteString = command + ">" + promptString + ">" + string.Join(";", tempConfs);
                serialPortSSC.WriteLine(confWriteString);
                timerReadSerial.Enabled = true;
            }
            else
            {
                MessageBox.Show("Connect to a device to use this function", "Connection needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }


        private void tabPageConfig_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Select instrument configuration";
        }

        private void timerReadSerial_Tick(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                if (command == "readconf")
                {
                    config = serialPortSSC.ReadExisting();
                    if (config.Length > 0)
                    {
                        try
                        {
                            configs = config.Split(';');
                            textBoxName.Text = configs[0];
                            textBoxlrv.Text = configs[1];
                            textBoxurv.Text = configs[2];
                            textBoxAlarml.Text = configs[3];
                            textBoxAlarmh.Text = configs[4];


                            timerReadSerial.Enabled = false;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            MessageBox.Show("Something went wrong when reading the configuration. Please try again. If the issue continues, make sure the device is connected and operating.", "Reading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            timerReadSerial.Enabled = false;
                        }
                    }
                }

                else if (command == "writeconf")
                {
                    Write:
                    string success;
                    success = serialPortSSC.ReadExisting();
                    if (success.Length > 0)
                    {
                        if (success == "1")
                        {
                            MessageBox.Show("New configuration accepted!", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            configs[0] = textBoxName.Text;
                            configs[1] = textBoxlrv.Text;
                            configs[2] = textBoxurv.Text;
                            configs[3] = textBoxAlarml.Text;
                            configs[4] = textBoxAlarmh.Text;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("New configuration denied! Make sure the password is correct. Try again?", "Write error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                timerReadSerial.Enabled = false;
                                FormPrompt writeConfPrompt = new FormPrompt();
                                writeConfPrompt.ShowDialog();
                                string promptString = writeConfPrompt.promptText;

                                string[] tempConfs = new string[5];
                                tempConfs[0] = textBoxName.Text;
                                tempConfs[1] = textBoxlrv.Text;
                                tempConfs[2] = textBoxurv.Text;
                                tempConfs[3] = textBoxAlarml.Text;
                                tempConfs[4] = textBoxAlarmh.Text;

                                string confWriteString = command + ">" + promptString + ">" + string.Join(";", tempConfs);
                                serialPortSSC.WriteLine(confWriteString);
                                timerReadSerial.Enabled = true;
                                goto Write;
                            }
                            else
                            {
                                textBoxName.Text = configs[0];
                                textBoxlrv.Text = configs[1];
                                textBoxurv.Text = configs[2];
                                textBoxAlarml.Text = configs[3];
                                textBoxAlarmh.Text = configs[4];
                            }
                        }
                        timerReadSerial.Enabled = false;
                    }
                    
                }
                else if (command == "readraw")
                {
                    string inputString = serialPortSSC.ReadExisting();
                    if (inputString.Length > 0)
                    {
                        double input = double.Parse(inputString);
                        string urv = string.Join(",",configs[2].Split('.'));
                        double scaledInput = double.Parse(urv) / 1023.0 * input;
                        chartSensorData.Series[1].Points.Add(scaledInput);
                        chartSensorData.Series[0].Points.Add(input);

                        if (buttonRawScaled.Text == "Scaled")
                        {
                            listBoxValues.Items.Add(Math.Round(scaledInput, 2));
                        }
                        else if (buttonRawScaled.Text == "Raw")
                        {
                            listBoxValues.Items.Add(input);
                        }
                        
                        timerReadSerial.Enabled = false;
                        timerChart.Enabled = true;

                    }
                    
                    
                }
                
            
                
                
            }
            else
            {
                MessageBox.Show("Connect to a device to use this function", "Connection needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxlrv.Text.Length > 2 &&
                textBoxurv.Text.Length > 2 &&
                textBoxAlarml.Text.Length > 0 &&
                textBoxAlarmh.Text.Length > 0)
            {
                buttonWriteConfig.Enabled = true;
                buttonSaveConfig.Enabled = true;
            }
            else
            {
                buttonWriteConfig.Enabled = false;
                buttonSaveConfig.Enabled = false;
            }
        }

        private void textBoxlrv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxlrv.Text.Length > 2 &&
                textBoxurv.Text.Length > 2 &&
                textBoxAlarml.Text.Length > 0 &&
                textBoxAlarmh.Text.Length > 0)
            {
                buttonWriteConfig.Enabled = true;
                buttonSaveConfig.Enabled = true;
            }
            else
            {
                buttonWriteConfig.Enabled = false;
                buttonSaveConfig.Enabled = false;
            }
        }

        private void textBoxurv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxlrv.Text.Length > 2 &&
                textBoxurv.Text.Length > 2 &&
                textBoxAlarml.Text.Length > 0 &&
                textBoxAlarmh.Text.Length > 0)
            {
                buttonWriteConfig.Enabled = true;
                buttonSaveConfig.Enabled = true;
            }
            else
            {
                buttonWriteConfig.Enabled = false;
                buttonSaveConfig.Enabled = false;
            }
        }

        private void textBoxAlarml_TextChanged(object sender, EventArgs e)
        {
            if (textBoxlrv.Text.Length > 2 &&
                textBoxurv.Text.Length > 2 &&
                textBoxAlarml.Text.Length > 0 &&
                textBoxAlarmh.Text.Length > 0)
            {
                buttonWriteConfig.Enabled = true;
                buttonSaveConfig.Enabled = true;
            }
            else
            {
                buttonWriteConfig.Enabled = false;
                buttonSaveConfig.Enabled = false;
            }
        }

        private void textBoxAlarmh_TextChanged(object sender, EventArgs e)
        {
            if (textBoxlrv.Text.Length > 2 &&
                textBoxurv.Text.Length > 2 &&
                textBoxAlarml.Text.Length > 0 &&
                textBoxAlarmh.Text.Length > 0)
            {
                buttonWriteConfig.Enabled = true;
                buttonSaveConfig.Enabled = true;
            }
            else
            {
                buttonWriteConfig.Enabled = false;
                buttonSaveConfig.Enabled = false;
            }
        }

        private void textBoxlrv_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '.':
                case '\b':
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        private void textBoxurv_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '.':
                case '\b':
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        private void textBoxAlarml_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        private void textBoxAlarmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            string filename = "";

            if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialogConfig.FileName;
                File.Delete(filename);
                File.AppendAllLines(filename, configs);

                MessageBox.Show("File successfully saved", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            string filePath = "";
            openFileDialogConfig.InitialDirectory = "c:\\";
            openFileDialogConfig.RestoreDirectory = true;

            if (openFileDialogConfig.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialogConfig.FileName;
            }
            if (File.Exists(filePath))
            {
                string[] fileData;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileData = sr.ReadToEnd().Split('\n');
                    

                    textBoxName.Text = fileData[0];
                    textBoxlrv.Text = fileData[1];
                    textBoxurv.Text = fileData[2];
                    textBoxAlarml.Text = fileData[3];
                    textBoxAlarmh.Text = fileData[4];

                }
            }
        }

        private void buttonReadConfig_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Read configuration from connected device.";
        }

        private void buttonReadConfig_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Read configuration from connected device.";
        }

        private void buttonWriteConfig_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Write configuration to connected device. Requires a password.";
        }

        private void buttonWriteConfig_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Write configuration to connected device. Requires a password.";
        }

        private void buttonLoadConfig_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Load configuration from file.";
        }

        private void buttonLoadConfig_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Load configuration from file.";
        }

        private void buttonSaveConfig_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Save configuration to file.";
        }

        private void buttonSaveConfig_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Save configuration to file.";
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the name of the unit.";
        }

        private void textBoxName_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the name of the unit.";
        }

        private void textBoxlrv_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the lower range value of the unit.";
        }

        private void textBoxlrv_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the lower range value of the unit.";
        }

        private void textBoxurv_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the upper range value of the unit.";
        }

        private void textBoxurv_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the upper range value of the unit.";
        }

        private void textBoxAlarml_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the lower value for when the alarm should signal.";
        }

        private void textBoxAlarml_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the lower value for when the alarm should signal.";
        }

        private void textBoxAlarmh_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the upper value for when the alarm should signal.";
        }

        private void textBoxAlarmh_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Displays the upper value for when the alarm should signal.";
        }

        private void buttonRawScaled_Click(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();
            if (buttonRawScaled.Text == "Scaled")
            {
                chartSensorData.Series[0].BorderWidth = 2;
                chartSensorData.Series[1].BorderWidth = 0;
                buttonRawScaled.Text = "Raw";
                listBoxValues.Items.Clear();
                foreach (var point in chartSensorData.Series[0].Points)
                {
                    foreach (var value in point.YValues)
                    {
                        listBoxValues.Items.Add(value);
                    }
                    
                }
            }
            else if (buttonRawScaled.Text == "Raw")
            {
                chartSensorData.Series[0].BorderWidth = 0;
                chartSensorData.Series[1].BorderWidth = 2;
                buttonRawScaled.Text = "Scaled";
                foreach (var point in chartSensorData.Series[1].Points)
                {
                    foreach (var value in point.YValues)
                    {
                        listBoxValues.Items.Add(Math.Round(value, 2));
                    }
                }
            }
            
        }

        private void buttonToggleMonitor_Click(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                if (configs[2] != null)
                {
                    if (buttonToggleMonitor.Text == "Start monitor")
                    {
                        chartSensorData.Series[0].Points.Clear();
                        chartSensorData.Series[1].Points.Clear();
                        listBoxValues.Items.Clear();
                        buttonToggleMonitor.Text = "Stop monitor";
                        timerChart.Enabled = true;
                        buttonSaveData.Enabled = false;
                        timerStatus.Enabled = true;
                    }
                    else if (buttonToggleMonitor.Text == "Stop monitor")
                    {
                        buttonToggleMonitor.Text = "Start monitor";
                        timerChart.Enabled = false;
                        timerReadSerial.Enabled = false;
                        buttonSaveData.Enabled = true;
                        timerStatus.Enabled = false;
                    }
                }
                
                else
                {
                    MessageBox.Show("No configuration accepted. Please read or write configuration.", "Instrument configuration needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControlSSC.SelectedTab = tabPageConfig;
                }
            }
            else
            {
                MessageBox.Show("Connect to a device to use this function", "Connection needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            if (serialPortSSC.IsOpen)
            {
                serialPortSSC.WriteLine("readraw");
                command = "readraw";

                timerReadSerial.Enabled = true;
                timerChart.Enabled = false;
            }
            else
            {
                MessageBox.Show("Connect to a device to use this function", "Connection needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {

        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            string filename = "";

            if (saveFileDialogData.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialogData.FileName;
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                string[] saveData = new string[listBoxValues.Items.Count+1];
                saveData[0] = ("Time , " + buttonRawScaled.Text);
                for (int i = 0; i < listBoxValues.Items.Count; i++)
                {
                    saveData[i+1] = (i.ToString() + ", " + listBoxValues.Items[i]);
                }
                File.WriteAllLines(filename, saveData);

                MessageBox.Show("File successfully saved", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timerStatus_Tick_1(object sender, EventArgs e)
        {
            serialPortSSC.WriteLine("readstatus");
            timerChart.Enabled = false;
            timerReadSerial.Enabled = false;
            timerReadStatus.Enabled = true;
        }

        private void timerReadStatus_Tick(object sender, EventArgs e)
        {
            
            string input = serialPortSSC.ReadExisting();
            labelStatus.Text = "Reading...";
            labelStatus.ForeColor = Color.Gray;
            if (input.Length == 1)
            {
                if (input == "0")
                {
                    labelStatus.Text = "OK";
                    labelStatus.ForeColor = Color.LimeGreen;
                }
                else if (input == "1")
                {
                    labelStatus.Text = "Fail";
                    labelStatus.ForeColor = Color.Red;
                }
                else if (input == "2")
                {
                    labelStatus.Text = "Alarm low";
                    labelStatus.ForeColor = Color.Orange;
                }
                else if (input == "3")
                {
                    labelStatus.Text = "Alarm high";
                    labelStatus.ForeColor = Color.Orange;
                }

                timerReadStatus.Enabled = false;
                timerChart.Enabled = true;
            }
            
        }

        private void buttonRawScaled_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Toggles viewing of the scaled and raw values.";
        }

        private void buttonRawScaled_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Toggles viewing of the scaled and raw values.";
        }

        private void buttonToggleMonitor_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Toggles monitoring of real-time values.";
        }

        private void buttonToggleMonitor_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Toggles monitoring of real-time values.";
        }

        private void buttonSaveData_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Saves recorded data to file.";
        }

        private void buttonSaveData_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelSSC.Text = "Saves recorded data to file.";
        }
    }
        
    
}
