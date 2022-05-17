namespace SignalGenerator
{
    partial class Form1
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
            this.btn_FindPort = new System.Windows.Forms.Button();
            this.btn_ClosePort = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_OpenPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_HandShake = new System.Windows.Forms.Timer(this.components);
            this.button_RunStop = new System.Windows.Forms.Button();
            this.checkBox_RealTimeChange = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BatLevelBar = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.LoggingTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton_W1A0_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_W1A1 = new System.Windows.Forms.RadioButton();
            this.radioButton_W1A1_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_W1A2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton_W1F2000 = new System.Windows.Forms.RadioButton();
            this.radioButton_W1F960 = new System.Windows.Forms.RadioButton();
            this.radioButton_W1F1000 = new System.Windows.Forms.RadioButton();
            this.radioButton_W1F1020 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton_W2A0_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_W2A1 = new System.Windows.Forms.RadioButton();
            this.radioButton_W2A1_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_W2A2 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_W2F2000 = new System.Windows.Forms.RadioButton();
            this.radioButton_W2F960 = new System.Windows.Forms.RadioButton();
            this.radioButton_W2F1000 = new System.Windows.Forms.RadioButton();
            this.radioButton_W2F1020 = new System.Windows.Forms.RadioButton();
            this.VltLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_FindPort
            // 
            this.btn_FindPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindPort.Location = new System.Drawing.Point(11, 9);
            this.btn_FindPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FindPort.Name = "btn_FindPort";
            this.btn_FindPort.Size = new System.Drawing.Size(107, 28);
            this.btn_FindPort.TabIndex = 34;
            this.btn_FindPort.Text = "Find Ports";
            this.btn_FindPort.UseVisualStyleBackColor = true;
            this.btn_FindPort.Click += new System.EventHandler(this.btn_FindPort_Click);
            // 
            // btn_ClosePort
            // 
            this.btn_ClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClosePort.Location = new System.Drawing.Point(11, 81);
            this.btn_ClosePort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ClosePort.Name = "btn_ClosePort";
            this.btn_ClosePort.Size = new System.Drawing.Size(107, 28);
            this.btn_ClosePort.TabIndex = 33;
            this.btn_ClosePort.Text = "Close Port";
            this.btn_ClosePort.UseVisualStyleBackColor = true;
            this.btn_ClosePort.Click += new System.EventHandler(this.Btn_ClosePort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(209, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(355, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(127, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(73, 100);
            this.listBox1.TabIndex = 30;
            // 
            // btn_OpenPort
            // 
            this.btn_OpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenPort.Location = new System.Drawing.Point(11, 46);
            this.btn_OpenPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OpenPort.Name = "btn_OpenPort";
            this.btn_OpenPort.Size = new System.Drawing.Size(107, 28);
            this.btn_OpenPort.TabIndex = 29;
            this.btn_OpenPort.Text = "Open Port";
            this.btn_OpenPort.UseVisualStyleBackColor = true;
            this.btn_OpenPort.Click += new System.EventHandler(this.btn_OpenPort_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ReadBufferSize = 20;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer_HandShake
            // 
            this.timer_HandShake.Interval = 1000;
            this.timer_HandShake.Tick += new System.EventHandler(this.timer_HandShake_Tick);
            // 
            // button_RunStop
            // 
            this.button_RunStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RunStop.Location = new System.Drawing.Point(11, 508);
            this.button_RunStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RunStop.Name = "button_RunStop";
            this.button_RunStop.Size = new System.Drawing.Size(619, 28);
            this.button_RunStop.TabIndex = 44;
            this.button_RunStop.Text = "Run";
            this.button_RunStop.UseVisualStyleBackColor = true;
            this.button_RunStop.Click += new System.EventHandler(this.button_RunStop_Click);
            // 
            // checkBox_RealTimeChange
            // 
            this.checkBox_RealTimeChange.AutoSize = true;
            this.checkBox_RealTimeChange.Checked = true;
            this.checkBox_RealTimeChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RealTimeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RealTimeChange.Location = new System.Drawing.Point(11, 462);
            this.checkBox_RealTimeChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RealTimeChange.Name = "checkBox_RealTimeChange";
            this.checkBox_RealTimeChange.Size = new System.Drawing.Size(169, 24);
            this.checkBox_RealTimeChange.TabIndex = 45;
            this.checkBox_RealTimeChange.Text = "Real Time Change";
            this.checkBox_RealTimeChange.UseVisualStyleBackColor = true;
            this.checkBox_RealTimeChange.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Battery Level: ";
            // 
            // BatLevelBar
            // 
            this.BatLevelBar.Location = new System.Drawing.Point(139, 21);
            this.BatLevelBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BatLevelBar.Name = "BatLevelBar";
            this.BatLevelBar.Size = new System.Drawing.Size(97, 22);
            this.BatLevelBar.TabIndex = 59;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text file|*.txt";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(411, 463);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 26);
            this.textBox5.TabIndex = 55;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(205, 462);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(197, 28);
            this.Btn_Save.TabIndex = 54;
            this.Btn_Save.Text = "Save Measurments";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LoggingTimer
            // 
            this.LoggingTimer.Interval = 1000;
            this.LoggingTimer.Tick += new System.EventHandler(this.LoggingTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(573, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(488, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Timer:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 121);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(619, 158);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wave #1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.radioButton_W1A0_5);
            this.groupBox3.Controls.Add(this.radioButton_W1A1);
            this.groupBox3.Controls.Add(this.radioButton_W1A1_5);
            this.groupBox3.Controls.Add(this.radioButton_W1A2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(605, 63);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(8, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Amplitude:";
            // 
            // radioButton_W1A0_5
            // 
            this.radioButton_W1A0_5.AutoSize = true;
            this.radioButton_W1A0_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1A0_5.Location = new System.Drawing.Point(156, 31);
            this.radioButton_W1A0_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1A0_5.Name = "radioButton_W1A0_5";
            this.radioButton_W1A0_5.Size = new System.Drawing.Size(82, 24);
            this.radioButton_W1A0_5.TabIndex = 39;
            this.radioButton_W1A0_5.TabStop = true;
            this.radioButton_W1A0_5.Text = "0.5 mA";
            this.radioButton_W1A0_5.UseVisualStyleBackColor = true;
            this.radioButton_W1A0_5.Click += new System.EventHandler(this.radioButton_W1A0_5_Click);
            // 
            // radioButton_W1A1
            // 
            this.radioButton_W1A1.AutoSize = true;
            this.radioButton_W1A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1A1.Location = new System.Drawing.Point(265, 31);
            this.radioButton_W1A1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1A1.Name = "radioButton_W1A1";
            this.radioButton_W1A1.Size = new System.Drawing.Size(69, 24);
            this.radioButton_W1A1.TabIndex = 35;
            this.radioButton_W1A1.TabStop = true;
            this.radioButton_W1A1.Text = "1 mA";
            this.radioButton_W1A1.UseVisualStyleBackColor = true;
            this.radioButton_W1A1.Click += new System.EventHandler(this.radioButton_W1A1_Click);
            // 
            // radioButton_W1A1_5
            // 
            this.radioButton_W1A1_5.AutoSize = true;
            this.radioButton_W1A1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1A1_5.Location = new System.Drawing.Point(389, 30);
            this.radioButton_W1A1_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1A1_5.Name = "radioButton_W1A1_5";
            this.radioButton_W1A1_5.Size = new System.Drawing.Size(82, 24);
            this.radioButton_W1A1_5.TabIndex = 36;
            this.radioButton_W1A1_5.TabStop = true;
            this.radioButton_W1A1_5.Text = "1.5 mA";
            this.radioButton_W1A1_5.UseVisualStyleBackColor = true;
            this.radioButton_W1A1_5.Click += new System.EventHandler(this.radioButton_W1A1_5_Click);
            // 
            // radioButton_W1A2
            // 
            this.radioButton_W1A2.AutoSize = true;
            this.radioButton_W1A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1A2.Location = new System.Drawing.Point(501, 30);
            this.radioButton_W1A2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1A2.Name = "radioButton_W1A2";
            this.radioButton_W1A2.Size = new System.Drawing.Size(69, 24);
            this.radioButton_W1A2.TabIndex = 37;
            this.radioButton_W1A2.TabStop = true;
            this.radioButton_W1A2.Text = "2 mA";
            this.radioButton_W1A2.UseVisualStyleBackColor = true;
            this.radioButton_W1A2.Click += new System.EventHandler(this.radioButton_W1A2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.radioButton_W1F2000);
            this.groupBox1.Controls.Add(this.radioButton_W1F960);
            this.groupBox1.Controls.Add(this.radioButton_W1F1000);
            this.groupBox1.Controls.Add(this.radioButton_W1F1020);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(605, 58);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(8, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Frequency:";
            // 
            // radioButton_W1F2000
            // 
            this.radioButton_W1F2000.AutoSize = true;
            this.radioButton_W1F2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1F2000.Location = new System.Drawing.Point(501, 31);
            this.radioButton_W1F2000.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1F2000.Name = "radioButton_W1F2000";
            this.radioButton_W1F2000.Size = new System.Drawing.Size(93, 24);
            this.radioButton_W1F2000.TabIndex = 39;
            this.radioButton_W1F2000.TabStop = true;
            this.radioButton_W1F2000.Text = "2000 Hz";
            this.radioButton_W1F2000.UseVisualStyleBackColor = true;
            this.radioButton_W1F2000.Click += new System.EventHandler(this.radioButton_W1F2000_Click);
            // 
            // radioButton_W1F960
            // 
            this.radioButton_W1F960.AutoSize = true;
            this.radioButton_W1F960.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1F960.Location = new System.Drawing.Point(156, 31);
            this.radioButton_W1F960.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1F960.Name = "radioButton_W1F960";
            this.radioButton_W1F960.Size = new System.Drawing.Size(84, 24);
            this.radioButton_W1F960.TabIndex = 35;
            this.radioButton_W1F960.TabStop = true;
            this.radioButton_W1F960.Text = "960 Hz";
            this.radioButton_W1F960.UseVisualStyleBackColor = true;
            this.radioButton_W1F960.CheckedChanged += new System.EventHandler(this.radioButton_W1F960_CheckedChanged);
            this.radioButton_W1F960.Click += new System.EventHandler(this.radioButton_W1F960_Click);
            // 
            // radioButton_W1F1000
            // 
            this.radioButton_W1F1000.AutoSize = true;
            this.radioButton_W1F1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1F1000.Location = new System.Drawing.Point(265, 31);
            this.radioButton_W1F1000.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1F1000.Name = "radioButton_W1F1000";
            this.radioButton_W1F1000.Size = new System.Drawing.Size(93, 24);
            this.radioButton_W1F1000.TabIndex = 36;
            this.radioButton_W1F1000.TabStop = true;
            this.radioButton_W1F1000.Text = "1000 Hz";
            this.radioButton_W1F1000.UseVisualStyleBackColor = true;
            this.radioButton_W1F1000.Click += new System.EventHandler(this.radioButton_W1F1000_Click);
            // 
            // radioButton_W1F1020
            // 
            this.radioButton_W1F1020.AutoSize = true;
            this.radioButton_W1F1020.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W1F1020.Location = new System.Drawing.Point(389, 31);
            this.radioButton_W1F1020.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W1F1020.Name = "radioButton_W1F1020";
            this.radioButton_W1F1020.Size = new System.Drawing.Size(93, 24);
            this.radioButton_W1F1020.TabIndex = 37;
            this.radioButton_W1F1020.TabStop = true;
            this.radioButton_W1F1020.Text = "1020 Hz";
            this.radioButton_W1F1020.UseVisualStyleBackColor = true;
            this.radioButton_W1F1020.Click += new System.EventHandler(this.radioButton_W1F1020_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 297);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(619, 158);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wave #2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.radioButton_W2A0_5);
            this.groupBox6.Controls.Add(this.radioButton_W2A1);
            this.groupBox6.Controls.Add(this.radioButton_W2A1_5);
            this.groupBox6.Controls.Add(this.radioButton_W2A2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(5, 84);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(605, 63);
            this.groupBox6.TabIndex = 59;
            this.groupBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(8, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Amplitude:";
            // 
            // radioButton_W2A0_5
            // 
            this.radioButton_W2A0_5.AutoSize = true;
            this.radioButton_W2A0_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2A0_5.Location = new System.Drawing.Point(156, 31);
            this.radioButton_W2A0_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2A0_5.Name = "radioButton_W2A0_5";
            this.radioButton_W2A0_5.Size = new System.Drawing.Size(82, 24);
            this.radioButton_W2A0_5.TabIndex = 39;
            this.radioButton_W2A0_5.TabStop = true;
            this.radioButton_W2A0_5.Text = "0.5 mA";
            this.radioButton_W2A0_5.UseVisualStyleBackColor = true;
            this.radioButton_W2A0_5.Click += new System.EventHandler(this.radioButton_W2A0_5_Click);
            // 
            // radioButton_W2A1
            // 
            this.radioButton_W2A1.AutoSize = true;
            this.radioButton_W2A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2A1.Location = new System.Drawing.Point(265, 31);
            this.radioButton_W2A1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2A1.Name = "radioButton_W2A1";
            this.radioButton_W2A1.Size = new System.Drawing.Size(69, 24);
            this.radioButton_W2A1.TabIndex = 35;
            this.radioButton_W2A1.TabStop = true;
            this.radioButton_W2A1.Text = "1 mA";
            this.radioButton_W2A1.UseVisualStyleBackColor = true;
            this.radioButton_W2A1.Click += new System.EventHandler(this.radioButton_W2A1_Click);
            // 
            // radioButton_W2A1_5
            // 
            this.radioButton_W2A1_5.AutoSize = true;
            this.radioButton_W2A1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2A1_5.Location = new System.Drawing.Point(389, 31);
            this.radioButton_W2A1_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2A1_5.Name = "radioButton_W2A1_5";
            this.radioButton_W2A1_5.Size = new System.Drawing.Size(82, 24);
            this.radioButton_W2A1_5.TabIndex = 36;
            this.radioButton_W2A1_5.TabStop = true;
            this.radioButton_W2A1_5.Text = "1.5 mA";
            this.radioButton_W2A1_5.UseVisualStyleBackColor = true;
            this.radioButton_W2A1_5.Click += new System.EventHandler(this.radioButton_W2A1_5_Click);
            // 
            // radioButton_W2A2
            // 
            this.radioButton_W2A2.AutoSize = true;
            this.radioButton_W2A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2A2.Location = new System.Drawing.Point(501, 31);
            this.radioButton_W2A2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2A2.Name = "radioButton_W2A2";
            this.radioButton_W2A2.Size = new System.Drawing.Size(69, 24);
            this.radioButton_W2A2.TabIndex = 37;
            this.radioButton_W2A2.TabStop = true;
            this.radioButton_W2A2.Text = "2 mA";
            this.radioButton_W2A2.UseVisualStyleBackColor = true;
            this.radioButton_W2A2.Click += new System.EventHandler(this.radioButton_W2A2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.radioButton_W2F2000);
            this.groupBox7.Controls.Add(this.radioButton_W2F960);
            this.groupBox7.Controls.Add(this.radioButton_W2F1000);
            this.groupBox7.Controls.Add(this.radioButton_W2F1020);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(5, 21);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(605, 58);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(8, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Frequency:";
            // 
            // radioButton_W2F2000
            // 
            this.radioButton_W2F2000.AutoSize = true;
            this.radioButton_W2F2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2F2000.Location = new System.Drawing.Point(501, 31);
            this.radioButton_W2F2000.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2F2000.Name = "radioButton_W2F2000";
            this.radioButton_W2F2000.Size = new System.Drawing.Size(93, 24);
            this.radioButton_W2F2000.TabIndex = 39;
            this.radioButton_W2F2000.TabStop = true;
            this.radioButton_W2F2000.Text = "2020 Hz";
            this.radioButton_W2F2000.UseVisualStyleBackColor = true;
            this.radioButton_W2F2000.CheckedChanged += new System.EventHandler(this.radioButton_W2F2000_CheckedChanged);
            this.radioButton_W2F2000.Click += new System.EventHandler(this.radioButton_W2F2000_Click);
            // 
            // radioButton_W2F960
            // 
            this.radioButton_W2F960.AutoSize = true;
            this.radioButton_W2F960.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2F960.Location = new System.Drawing.Point(156, 31);
            this.radioButton_W2F960.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2F960.Name = "radioButton_W2F960";
            this.radioButton_W2F960.Size = new System.Drawing.Size(84, 24);
            this.radioButton_W2F960.TabIndex = 35;
            this.radioButton_W2F960.TabStop = true;
            this.radioButton_W2F960.Text = "960 Hz";
            this.radioButton_W2F960.UseVisualStyleBackColor = true;
            this.radioButton_W2F960.Click += new System.EventHandler(this.radioButton_W2F960_Click);
            // 
            // radioButton_W2F1000
            // 
            this.radioButton_W2F1000.AutoSize = true;
            this.radioButton_W2F1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2F1000.Location = new System.Drawing.Point(265, 31);
            this.radioButton_W2F1000.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2F1000.Name = "radioButton_W2F1000";
            this.radioButton_W2F1000.Size = new System.Drawing.Size(93, 24);
            this.radioButton_W2F1000.TabIndex = 36;
            this.radioButton_W2F1000.TabStop = true;
            this.radioButton_W2F1000.Text = "1000 Hz";
            this.radioButton_W2F1000.UseVisualStyleBackColor = true;
            this.radioButton_W2F1000.Click += new System.EventHandler(this.radioButton_W2F1000_Click);
            // 
            // radioButton_W2F1020
            // 
            this.radioButton_W2F1020.AutoSize = true;
            this.radioButton_W2F1020.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_W2F1020.Location = new System.Drawing.Point(389, 31);
            this.radioButton_W2F1020.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_W2F1020.Name = "radioButton_W2F1020";
            this.radioButton_W2F1020.Size = new System.Drawing.Size(93, 24);
            this.radioButton_W2F1020.TabIndex = 37;
            this.radioButton_W2F1020.TabStop = true;
            this.radioButton_W2F1020.Text = "1020 Hz";
            this.radioButton_W2F1020.UseVisualStyleBackColor = true;
            this.radioButton_W2F1020.Click += new System.EventHandler(this.radioButton_W2F1020_Click);
            // 
            // VltLbl
            // 
            this.VltLbl.AutoSize = true;
            this.VltLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VltLbl.Location = new System.Drawing.Point(244, 21);
            this.VltLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VltLbl.Name = "VltLbl";
            this.VltLbl.Size = new System.Drawing.Size(21, 18);
            this.VltLbl.TabIndex = 61;
            this.VltLbl.Text = "%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VltLbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BatLevelBar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(209, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(271, 65);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measure";
            // 
            // Form1
            // 
            this.AccessibleDescription = "Bipolar PaceMaker V1";
            this.AccessibleName = "Bipolar PaceMaker V1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 543);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox_RealTimeChange);
            this.Controls.Add(this.button_RunStop);
            this.Controls.Add(this.btn_FindPort);
            this.Controls.Add(this.btn_ClosePort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_OpenPort);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PaceMaker V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FindPort;
        private System.Windows.Forms.Button btn_ClosePort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_OpenPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer_HandShake;
        private System.Windows.Forms.Button button_RunStop;
        private System.Windows.Forms.CheckBox checkBox_RealTimeChange;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Timer LoggingTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar BatLevelBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton_W1A0_5;
        private System.Windows.Forms.RadioButton radioButton_W1A1;
        private System.Windows.Forms.RadioButton radioButton_W1A1_5;
        private System.Windows.Forms.RadioButton radioButton_W1A2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_W1F2000;
        private System.Windows.Forms.RadioButton radioButton_W1F960;
        private System.Windows.Forms.RadioButton radioButton_W1F1000;
        private System.Windows.Forms.RadioButton radioButton_W1F1020;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton_W2A0_5;
        private System.Windows.Forms.RadioButton radioButton_W2A1;
        private System.Windows.Forms.RadioButton radioButton_W2A1_5;
        private System.Windows.Forms.RadioButton radioButton_W2A2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_W2F2000;
        private System.Windows.Forms.RadioButton radioButton_W2F960;
        private System.Windows.Forms.RadioButton radioButton_W2F1000;
        private System.Windows.Forms.RadioButton radioButton_W2F1020;
        private System.Windows.Forms.Label VltLbl;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

