
namespace SoftSensConf
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPortSSC = new System.IO.Ports.SerialPort(this.components);
            this.statusStripSSC = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSSC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlSSC = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.labelBitRate = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBitRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.textBoxAlarmh = new System.Windows.Forms.TextBox();
            this.textBoxAlarml = new System.Windows.Forms.TextBox();
            this.textBoxurv = new System.Windows.Forms.TextBox();
            this.textBoxlrv = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAlarmh = new System.Windows.Forms.Label();
            this.labelAlarml = new System.Windows.Forms.Label();
            this.labelurv = new System.Windows.Forms.Label();
            this.labellrv = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonWriteConfig = new System.Windows.Forms.Button();
            this.buttonReadConfig = new System.Windows.Forms.Button();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonToggleMonitor = new System.Windows.Forms.Button();
            this.buttonRawScaled = new System.Windows.Forms.Button();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.chartSensorData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTipSSC = new System.Windows.Forms.ToolTip(this.components);
            this.timerReadSerial = new System.Windows.Forms.Timer(this.components);
            this.labelConnect = new System.Windows.Forms.Label();
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogConfig = new System.Windows.Forms.OpenFileDialog();
            this.timerConnected = new System.Windows.Forms.Timer(this.components);
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.timerReadStatus = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogData = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusStripSSC.SuspendLayout();
            this.tabControlSSC.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripSSC
            // 
            this.statusStripSSC.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripSSC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSSC});
            this.statusStripSSC.Location = new System.Drawing.Point(0, 460);
            this.statusStripSSC.Name = "statusStripSSC";
            this.statusStripSSC.Size = new System.Drawing.Size(929, 32);
            this.statusStripSSC.TabIndex = 0;
            this.statusStripSSC.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSSC
            // 
            this.toolStripStatusLabelSSC.Name = "toolStripStatusLabelSSC";
            this.toolStripStatusLabelSSC.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabelSSC.Text = "toolStripStatusLabel1";
            // 
            // tabControlSSC
            // 
            this.tabControlSSC.Controls.Add(this.tabPageConnection);
            this.tabControlSSC.Controls.Add(this.tabPageConfig);
            this.tabControlSSC.Controls.Add(this.tabPageData);
            this.tabControlSSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSSC.Location = new System.Drawing.Point(0, 0);
            this.tabControlSSC.Name = "tabControlSSC";
            this.tabControlSSC.SelectedIndex = 0;
            this.tabControlSSC.Size = new System.Drawing.Size(929, 460);
            this.tabControlSSC.TabIndex = 1;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.textBox2);
            this.tabPageConnection.Controls.Add(this.textBox1);
            this.tabPageConnection.Controls.Add(this.buttonNext1);
            this.tabPageConnection.Controls.Add(this.labelBitRate);
            this.tabPageConnection.Controls.Add(this.labelPort);
            this.tabPageConnection.Controls.Add(this.buttonDisconnect);
            this.tabPageConnection.Controls.Add(this.buttonConnect);
            this.tabPageConnection.Controls.Add(this.comboBoxBitRate);
            this.tabPageConnection.Controls.Add(this.comboBoxComPort);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 29);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(921, 427);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            this.tabPageConnection.Enter += new System.EventHandler(this.tabPageConnection_Enter);
            // 
            // buttonNext1
            // 
            this.buttonNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext1.Location = new System.Drawing.Point(292, 376);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(105, 36);
            this.buttonNext1.TabIndex = 6;
            this.buttonNext1.Text = "Next";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            this.buttonNext1.Enter += new System.EventHandler(this.buttonNext1_Enter);
            this.buttonNext1.MouseEnter += new System.EventHandler(this.buttonNext1_MouseEnter);
            // 
            // labelBitRate
            // 
            this.labelBitRate.AutoSize = true;
            this.labelBitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitRate.Location = new System.Drawing.Point(250, 202);
            this.labelBitRate.Name = "labelBitRate";
            this.labelBitRate.Size = new System.Drawing.Size(88, 29);
            this.labelBitRate.TabIndex = 5;
            this.labelBitRate.Text = "Bit rate";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(26, 202);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(57, 29);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(26, 376);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(105, 36);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            this.buttonDisconnect.Enter += new System.EventHandler(this.buttonDisconnect_Enter);
            this.buttonDisconnect.MouseEnter += new System.EventHandler(this.buttonDisconnect_MouseEnter);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(159, 376);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(105, 36);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.Enter += new System.EventHandler(this.buttonConnect_Enter);
            this.buttonConnect.MouseEnter += new System.EventHandler(this.buttonConnect_MouseEnter);
            // 
            // comboBoxBitRate
            // 
            this.comboBoxBitRate.FormattingEnabled = true;
            this.comboBoxBitRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBoxBitRate.Location = new System.Drawing.Point(255, 243);
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            this.comboBoxBitRate.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBitRate.TabIndex = 1;
            this.comboBoxBitRate.Text = "9600";
            this.comboBoxBitRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBitRate_SelectedIndexChanged);
            this.comboBoxBitRate.Enter += new System.EventHandler(this.comboBoxBitRate_Enter);
            this.comboBoxBitRate.MouseEnter += new System.EventHandler(this.comboBoxBitRate_MouseEnter);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(31, 243);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 28);
            this.comboBoxComPort.TabIndex = 0;
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            this.comboBoxComPort.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBoxComPort.MouseEnter += new System.EventHandler(this.comboBoxComPort_MouseEnter);
            this.comboBoxComPort.MouseHover += new System.EventHandler(this.comboBoxComPort_MouseHover);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.textBox3);
            this.tabPageConfig.Controls.Add(this.textBoxAlarmh);
            this.tabPageConfig.Controls.Add(this.textBoxAlarml);
            this.tabPageConfig.Controls.Add(this.textBoxurv);
            this.tabPageConfig.Controls.Add(this.textBoxlrv);
            this.tabPageConfig.Controls.Add(this.textBoxName);
            this.tabPageConfig.Controls.Add(this.labelAlarmh);
            this.tabPageConfig.Controls.Add(this.labelAlarml);
            this.tabPageConfig.Controls.Add(this.labelurv);
            this.tabPageConfig.Controls.Add(this.labellrv);
            this.tabPageConfig.Controls.Add(this.labelName);
            this.tabPageConfig.Controls.Add(this.buttonLoadConfig);
            this.tabPageConfig.Controls.Add(this.buttonSaveConfig);
            this.tabPageConfig.Controls.Add(this.buttonWriteConfig);
            this.tabPageConfig.Controls.Add(this.buttonReadConfig);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(921, 427);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Configuration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            this.tabPageConfig.Enter += new System.EventHandler(this.tabPageConfig_Enter);
            // 
            // textBoxAlarmh
            // 
            this.textBoxAlarmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlarmh.Location = new System.Drawing.Point(269, 293);
            this.textBoxAlarmh.MaxLength = 4;
            this.textBoxAlarmh.Name = "textBoxAlarmh";
            this.textBoxAlarmh.Size = new System.Drawing.Size(147, 35);
            this.textBoxAlarmh.TabIndex = 6;
            this.textBoxAlarmh.TextChanged += new System.EventHandler(this.textBoxAlarmh_TextChanged);
            this.textBoxAlarmh.Enter += new System.EventHandler(this.textBoxAlarmh_Enter);
            this.textBoxAlarmh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarmh_KeyPress);
            this.textBoxAlarmh.MouseEnter += new System.EventHandler(this.textBoxAlarmh_MouseEnter);
            // 
            // textBoxAlarml
            // 
            this.textBoxAlarml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlarml.Location = new System.Drawing.Point(269, 247);
            this.textBoxAlarml.MaxLength = 4;
            this.textBoxAlarml.Name = "textBoxAlarml";
            this.textBoxAlarml.Size = new System.Drawing.Size(147, 35);
            this.textBoxAlarml.TabIndex = 5;
            this.textBoxAlarml.TextChanged += new System.EventHandler(this.textBoxAlarml_TextChanged);
            this.textBoxAlarml.Enter += new System.EventHandler(this.textBoxAlarml_Enter);
            this.textBoxAlarml.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlarml_KeyPress);
            this.textBoxAlarml.MouseEnter += new System.EventHandler(this.textBoxAlarml_MouseEnter);
            // 
            // textBoxurv
            // 
            this.textBoxurv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxurv.Location = new System.Drawing.Point(269, 201);
            this.textBoxurv.MaxLength = 7;
            this.textBoxurv.Name = "textBoxurv";
            this.textBoxurv.Size = new System.Drawing.Size(147, 35);
            this.textBoxurv.TabIndex = 4;
            this.textBoxurv.TextChanged += new System.EventHandler(this.textBoxurv_TextChanged);
            this.textBoxurv.Enter += new System.EventHandler(this.textBoxurv_Enter);
            this.textBoxurv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxurv_KeyPress);
            this.textBoxurv.MouseEnter += new System.EventHandler(this.textBoxurv_MouseEnter);
            // 
            // textBoxlrv
            // 
            this.textBoxlrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlrv.Location = new System.Drawing.Point(269, 155);
            this.textBoxlrv.MaxLength = 7;
            this.textBoxlrv.Name = "textBoxlrv";
            this.textBoxlrv.Size = new System.Drawing.Size(147, 35);
            this.textBoxlrv.TabIndex = 3;
            this.textBoxlrv.TextChanged += new System.EventHandler(this.textBoxlrv_TextChanged);
            this.textBoxlrv.Enter += new System.EventHandler(this.textBoxlrv_Enter);
            this.textBoxlrv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxlrv_KeyPress);
            this.textBoxlrv.MouseEnter += new System.EventHandler(this.textBoxlrv_MouseEnter);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(269, 109);
            this.textBoxName.MaxLength = 10;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 35);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.MouseEnter += new System.EventHandler(this.textBoxName_MouseEnter);
            // 
            // labelAlarmh
            // 
            this.labelAlarmh.AutoSize = true;
            this.labelAlarmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmh.Location = new System.Drawing.Point(76, 296);
            this.labelAlarmh.Name = "labelAlarmh";
            this.labelAlarmh.Size = new System.Drawing.Size(127, 29);
            this.labelAlarmh.TabIndex = 8;
            this.labelAlarmh.Text = "Alarm high";
            // 
            // labelAlarml
            // 
            this.labelAlarml.AutoSize = true;
            this.labelAlarml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarml.Location = new System.Drawing.Point(76, 250);
            this.labelAlarml.Name = "labelAlarml";
            this.labelAlarml.Size = new System.Drawing.Size(119, 29);
            this.labelAlarml.TabIndex = 7;
            this.labelAlarml.Text = "Alarm low";
            // 
            // labelurv
            // 
            this.labelurv.AutoSize = true;
            this.labelurv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelurv.Location = new System.Drawing.Point(27, 204);
            this.labelurv.Name = "labelurv";
            this.labelurv.Size = new System.Drawing.Size(211, 29);
            this.labelurv.TabIndex = 6;
            this.labelurv.Text = "Upper range value";
            // 
            // labellrv
            // 
            this.labellrv.AutoSize = true;
            this.labellrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellrv.Location = new System.Drawing.Point(27, 158);
            this.labellrv.Name = "labellrv";
            this.labellrv.Size = new System.Drawing.Size(211, 29);
            this.labellrv.TabIndex = 5;
            this.labellrv.Text = "Lower range value";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(76, 112);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 29);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadConfig.Location = new System.Drawing.Point(321, 38);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(95, 49);
            this.buttonLoadConfig.TabIndex = 1;
            this.buttonLoadConfig.Text = "Load";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            this.buttonLoadConfig.Enter += new System.EventHandler(this.buttonLoadConfig_Enter);
            this.buttonLoadConfig.MouseEnter += new System.EventHandler(this.buttonLoadConfig_MouseEnter);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Enabled = false;
            this.buttonSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfig.Location = new System.Drawing.Point(321, 359);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(95, 49);
            this.buttonSaveConfig.TabIndex = 8;
            this.buttonSaveConfig.Text = "Save";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            this.buttonSaveConfig.Enter += new System.EventHandler(this.buttonSaveConfig_Enter);
            this.buttonSaveConfig.MouseEnter += new System.EventHandler(this.buttonSaveConfig_MouseEnter);
            // 
            // buttonWriteConfig
            // 
            this.buttonWriteConfig.Enabled = false;
            this.buttonWriteConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteConfig.Location = new System.Drawing.Point(84, 359);
            this.buttonWriteConfig.Name = "buttonWriteConfig";
            this.buttonWriteConfig.Size = new System.Drawing.Size(95, 49);
            this.buttonWriteConfig.TabIndex = 7;
            this.buttonWriteConfig.Text = "Write";
            this.buttonWriteConfig.UseVisualStyleBackColor = true;
            this.buttonWriteConfig.Click += new System.EventHandler(this.buttonWriteConfig_Click);
            this.buttonWriteConfig.Enter += new System.EventHandler(this.buttonWriteConfig_Enter);
            this.buttonWriteConfig.MouseEnter += new System.EventHandler(this.buttonWriteConfig_MouseEnter);
            // 
            // buttonReadConfig
            // 
            this.buttonReadConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadConfig.Location = new System.Drawing.Point(84, 38);
            this.buttonReadConfig.Name = "buttonReadConfig";
            this.buttonReadConfig.Size = new System.Drawing.Size(95, 49);
            this.buttonReadConfig.TabIndex = 0;
            this.buttonReadConfig.Text = "Read";
            this.buttonReadConfig.UseVisualStyleBackColor = true;
            this.buttonReadConfig.Click += new System.EventHandler(this.buttonReadConfig_Click);
            this.buttonReadConfig.Enter += new System.EventHandler(this.buttonReadConfig_Enter);
            this.buttonReadConfig.MouseEnter += new System.EventHandler(this.buttonReadConfig_MouseEnter);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.labelStatus);
            this.tabPageData.Controls.Add(this.labelStatus1);
            this.tabPageData.Controls.Add(this.buttonSaveData);
            this.tabPageData.Controls.Add(this.buttonToggleMonitor);
            this.tabPageData.Controls.Add(this.buttonRawScaled);
            this.tabPageData.Controls.Add(this.listBoxValues);
            this.tabPageData.Controls.Add(this.chartSensorData);
            this.tabPageData.Location = new System.Drawing.Point(4, 29);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(921, 427);
            this.tabPageData.TabIndex = 2;
            this.tabPageData.Text = "Sensor data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelStatus.Location = new System.Drawing.Point(806, 21);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 6;
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Location = new System.Drawing.Point(740, 21);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(60, 20);
            this.labelStatus1.TabIndex = 5;
            this.labelStatus1.Text = "Status:";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Enabled = false;
            this.buttonSaveData.Location = new System.Drawing.Point(12, 376);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(156, 39);
            this.buttonSaveData.TabIndex = 2;
            this.buttonSaveData.Text = "Save to file";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            this.buttonSaveData.Enter += new System.EventHandler(this.buttonSaveData_Enter);
            this.buttonSaveData.MouseEnter += new System.EventHandler(this.buttonSaveData_MouseEnter);
            // 
            // buttonToggleMonitor
            // 
            this.buttonToggleMonitor.Location = new System.Drawing.Point(12, 331);
            this.buttonToggleMonitor.Name = "buttonToggleMonitor";
            this.buttonToggleMonitor.Size = new System.Drawing.Size(156, 39);
            this.buttonToggleMonitor.TabIndex = 1;
            this.buttonToggleMonitor.Text = "Start monitor";
            this.buttonToggleMonitor.UseVisualStyleBackColor = true;
            this.buttonToggleMonitor.Click += new System.EventHandler(this.buttonToggleMonitor_Click);
            this.buttonToggleMonitor.Enter += new System.EventHandler(this.buttonToggleMonitor_Enter);
            this.buttonToggleMonitor.MouseEnter += new System.EventHandler(this.buttonToggleMonitor_MouseEnter);
            // 
            // buttonRawScaled
            // 
            this.buttonRawScaled.Location = new System.Drawing.Point(12, 12);
            this.buttonRawScaled.Name = "buttonRawScaled";
            this.buttonRawScaled.Size = new System.Drawing.Size(156, 39);
            this.buttonRawScaled.TabIndex = 0;
            this.buttonRawScaled.Text = "Scaled";
            this.buttonRawScaled.UseVisualStyleBackColor = true;
            this.buttonRawScaled.Click += new System.EventHandler(this.buttonRawScaled_Click);
            this.buttonRawScaled.Enter += new System.EventHandler(this.buttonRawScaled_Enter);
            this.buttonRawScaled.MouseEnter += new System.EventHandler(this.buttonRawScaled_MouseEnter);
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 20;
            this.listBoxValues.Location = new System.Drawing.Point(12, 57);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(156, 264);
            this.listBoxValues.TabIndex = 1;
            this.listBoxValues.TabStop = false;
            // 
            // chartSensorData
            // 
            chartArea10.AxisX.Title = "Time";
            chartArea10.AxisY.Title = "Light";
            chartArea10.Name = "ChartArea1";
            this.chartSensorData.ChartAreas.Add(chartArea10);
            this.chartSensorData.Location = new System.Drawing.Point(160, 3);
            this.chartSensorData.Name = "chartSensorData";
            series19.BorderWidth = 0;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Name = "SeriesRaw";
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Name = "SeriesScaled";
            this.chartSensorData.Series.Add(series19);
            this.chartSensorData.Series.Add(series20);
            this.chartSensorData.Size = new System.Drawing.Size(757, 412);
            this.chartSensorData.TabIndex = 0;
            this.chartSensorData.TabStop = false;
            title10.Name = "TitleRaw";
            this.chartSensorData.Titles.Add(title10);
            // 
            // timerReadSerial
            // 
            this.timerReadSerial.Interval = 500;
            this.timerReadSerial.Tick += new System.EventHandler(this.timerReadSerial_Tick);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelConnect.Location = new System.Drawing.Point(795, 467);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(113, 20);
            this.labelConnect.TabIndex = 2;
            this.labelConnect.Text = "Not connected";
            this.labelConnect.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveFileDialogConfig
            // 
            this.saveFileDialogConfig.DefaultExt = "ssc";
            // 
            // openFileDialogConfig
            // 
            this.openFileDialogConfig.DefaultExt = "ssc";
            this.openFileDialogConfig.FileName = "openFileDialog1";
            // 
            // timerConnected
            // 
            this.timerConnected.Enabled = true;
            this.timerConnected.Interval = 250;
            this.timerConnected.Tick += new System.EventHandler(this.timerConnected_Tick);
            // 
            // timerChart
            // 
            this.timerChart.Interval = 1000;
            this.timerChart.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 20000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick_1);
            // 
            // timerReadStatus
            // 
            this.timerReadStatus.Interval = 750;
            this.timerReadStatus.Tick += new System.EventHandler(this.timerReadStatus_Tick);
            // 
            // saveFileDialogData
            // 
            this.saveFileDialogData.DefaultExt = "csv";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(415, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 395);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(8, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 169);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(440, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(473, 402);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 492);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.tabControlSSC);
            this.Controls.Add(this.statusStripSSC);
            this.Name = "FormMain";
            this.Text = "SoftSensConf";
            this.statusStripSSC.ResumeLayout(false);
            this.statusStripSSC.PerformLayout();
            this.tabControlSSC.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortSSC;
        private System.Windows.Forms.StatusStrip statusStripSSC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSSC;
        private System.Windows.Forms.TabControl tabControlSSC;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.ComboBox comboBoxBitRate;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ToolTip toolTipSSC;
        private System.Windows.Forms.Label labelBitRate;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonWriteConfig;
        private System.Windows.Forms.Button buttonReadConfig;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.TextBox textBoxAlarmh;
        private System.Windows.Forms.TextBox textBoxAlarml;
        private System.Windows.Forms.TextBox textBoxurv;
        private System.Windows.Forms.TextBox textBoxlrv;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAlarmh;
        private System.Windows.Forms.Label labelAlarml;
        private System.Windows.Forms.Label labelurv;
        private System.Windows.Forms.Label labellrv;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Timer timerReadSerial;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.OpenFileDialog openFileDialogConfig;
        private System.Windows.Forms.Timer timerConnected;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorData;
        private System.Windows.Forms.Button buttonToggleMonitor;
        private System.Windows.Forms.Button buttonRawScaled;
        private System.Windows.Forms.Timer timerChart;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.Timer timerReadStatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

