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
using System.Data.OleDb;
using System.IO;



namespace SignalGenerator
{
    public partial class Form1 : Form
    {
        int input_length = 0;
        string input_string = "";



 
        int Period_Uni = 20;
        int PulseWidth_Uni = 400;
        int OutCurrent_Uni = 5;
        int Frequency_Uni = 50;
        int ExpTimer = 0;



        int Wave1Frequency = 1000;
        int Wave1Amplitude = 1000;
        int Wave2Frequency = 1020;
        int Wave2Amplitude = 1000;
        int T = 0;
        int statePort = 0;

        int[] DataSampling = new int[1024];


        bool RunStop = false;
        bool RealTimeChange = true;
        bool Modulation = false;
        bool ApplyingLimitation = true;
        bool FlagResData = false;
        //bool FlagFirstTime = false;
        //bool FlagConnect = false;
        bool LoggingFlag = false;

        string Status = null;
        string path = null;
        StreamWriter log;
        float BatVolt;

        bool LimitationAlarm = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            label6.Text = "Disconnected";           
            label3.ForeColor = Color.DarkViolet;
            label1.ForeColor = Color.DarkViolet;  
            radioButton_W1F1000.Checked =true;
            radioButton_W1A1.Checked = true;
            radioButton_W2F1020.Checked = true;
            radioButton_W2A1.Checked = true;
            button_RunStop.BackColor = Color.Green;
            LoggingTimer.Enabled = false;
            Btn_Save.BackColor = Color.Green;
            VltLbl.BackColor = Color.Transparent;
           

        }

        private void btn_FindPort_Click(object sender, EventArgs e)
        {
            list_ports();
        }


        public void list_ports()
        {
            if (!serialPort1.IsOpen)
            {
                listBox1.Items.Clear();
                foreach (string s in SerialPort.GetPortNames()) { listBox1.Items.Add(s.ToString()); }
                if (SerialPort.GetPortNames().Count() > 0) { listBox1.SelectedIndex = 0; }
            }
        }


        void set_baudrate(int baudrate)
        { if (serialPort1.BaudRate != baudrate) { serialPort1.BaudRate = baudrate; } }


        private void btn_OpenPort_Click(object sender, EventArgs e)
        {
            // serialPort1.PortName = "COM15";
            serialPort1.PortName = listBox1.SelectedItem.ToString();
            serialPort1.Open();

            if (serialPort1.IsOpen)
            {
                //timer_find_ports.Enabled = false;
                listBox1.BackColor = Color.GreenYellow;
                set_baudrate(115200);
                timer_HandShake.Enabled = true;
                label6.Text = "Conecting . . .";
            }

        }

        private void Btn_ClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer_HandShake.Enabled = false;
            //timer_find_ports.Enabled = true;
            listBox1.BackColor = Color.White;
            //FlagFirstTime = true;
            label6.Text = "Disconnected";
            //groupBox_Aydin_Properties.Hide();
            //groupBox_Unipolar_Properties.Hide();
            //groupBox_Bipolar_Properties.Hide();
            //groupBox_Wave_Properties.Hide();
            if (RunStop) this.Invoke(new EventHandler(button_RunStop_Click));
         }

        private void timer_HandShake_Tick(object sender, EventArgs e)
        {
            send_string("HandShake");
            //HandShakeCnt++;
            //if (FlagConnect) HandShakeCnt = 0;
            //if (HandShakeCnt == 10)
            //{
            //    FlagConnect = false;
            //    button_RunStop.BackColor = Color.Red;
            //    button_RunStop.Text = "Run";
            //    send_string("RunStop:" + "0");
            //    groupBox1.Enabled = true;
            //    serialPort1.Close();
            //    listBox1.BackColor = Color.White;
            //    FlagFirstTime = true;
            //    label6.Text = "Disconnected";
            //}
         }

        void send_string(string input)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(input);
                // RTB_log.AppendText(input + " ", Color.LimeGreen);
                // RTB_log.SelectionStart = RTB_log.Text.Length; RTB_log.ScrollToCaret();
                statePort = 1;
            }
            else
            {
                this.Invoke(new EventHandler(btn_FindPort_Click));
                MessageBox.Show("please open port");
                statePort = 0;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            input_length = serialPort1.BytesToRead;
            input_string = string.Empty;
            input_string = serialPort1.ReadLine();
            //string line = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(process_answer));
        }

        private void process_answer(object sender, EventArgs e)
        {
            string result = input_string;
            if (input_string == "Connect")
            {
                label6.Text = "Connected";
                //FlagFirstTime = false;
                timer_HandShake.Enabled = false;
                //FlagConnect = true;
            }
            
            if (FlagResData)
            {
                string[] result_Prameters = result.Split(';');
                //textBox15.Text = result_Prameters[0];
                //textBox16.Text = result_Prameters[1];
                //textBox17.Text = result_Prameters[2];
                //if (int.Parse(result_Prameters[3]) == 1) LimitationAlarm = true; else LimitationAlarm = false;            
                //if (LimitationAlarm) MessageBox.Show("  Tissue resistance is more than 3000 Ohm.\n\n Please restart GUI and Interface to continue.", "    Alarm!!!");
                BatVolt = float.Parse(result_Prameters[0]);
                int BatPercent = (int)(200 * (BatVolt - 3.3));
                if (BatPercent > 100) BatPercent = 100;
                if (BatPercent < 0) BatPercent = 0;
                BatLevelBar.Value = BatPercent;
                BatLevelBar.Tag = "10";
                VltLbl.Text = (BatPercent.ToString() + " %");

                FlagResData = false;

                if (LoggingFlag==true)
                {
                    log = File.AppendText(path);
                    //string str = textBox15.Text + ";" + textBox16.Text + ";" + textBox17.Text + ";" + ExpTimer + ";" + DateTime.Now;
                    //log.WriteLine(str);
                    log.WriteLine();
                    log.Close();
                }
 
            }

            if (input_string == "SendingData")
            {
                FlagResData = true;
            }
            
        }
 
        private void button_RunStop_Click(object sender, EventArgs e)
        {
            try
            {
                T = Int32.Parse(textBox1.Text);
                if(T != 0)
                {
                    button_RunStop.BackColor = Color.Red;
                    button_RunStop.Text = "Stop";
                    //groupBox1.Enabled = false;
                    
                    // Runs the Code
                    send_string("Wave1Frequency:" + Wave1Frequency.ToString());
                    System.Threading.Thread.Sleep(50);
                    send_string("Wave1Amplitude:" + Wave1Amplitude.ToString());
                    System.Threading.Thread.Sleep(50);
                    send_string("Wave2Frequency:" + Wave2Frequency.ToString());
                    System.Threading.Thread.Sleep(50);
                    send_string("Wave2Amplitude:" + Wave2Amplitude.ToString());
                    System.Threading.Thread.Sleep(50);
                    send_string("RunStop:" + "1");
                    LoggingTimer.Enabled = true;
                    System.Threading.Thread.Sleep(50);

                    if (statePort == 1)
                    {
                        //Waits 1 second * T
                        RunT.Enabled = true;
                        RunT.Interval = 1000 * T;
                    }
                }
                else
                {

                    RunStop = !RunStop;
                    if (RunStop)
                    {
                        button_RunStop.BackColor = Color.Red;
                        button_RunStop.Text = "Stop";
                        //groupBox1.Enabled = false;

                        send_string("Wave1Frequency:" + Wave1Frequency.ToString());
                        System.Threading.Thread.Sleep(50);
                        send_string("Wave1Amplitude:" + Wave1Amplitude.ToString());
                        System.Threading.Thread.Sleep(50);
                        send_string("Wave2Frequency:" + Wave2Frequency.ToString());
                        System.Threading.Thread.Sleep(50);
                        send_string("Wave2Amplitude:" + Wave2Amplitude.ToString());
                        System.Threading.Thread.Sleep(50);
                        send_string("RunStop:" + "1");
                        System.Threading.Thread.Sleep(50);
                        LoggingTimer.Enabled = true;
                        System.Threading.Thread.Sleep(50); 

                    }
                    else
                    {
                        send_string("RunStop:" + "0");
                        button_RunStop.BackColor = Color.Green;
                        button_RunStop.Text = "Run";
                        LoggingTimer.Enabled = false;
                        RunT.Enabled = false;
                        statePort = 0;
                        ExpTimer = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error, Please check timer input is a valid input");

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //New Comment
            RealTimeChange = !RealTimeChange;
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LoggingFlag==false)
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    MessageBox.Show("Data will be saved in this directory: \n" + path); //custom messageBox to show error  
                }
                textBox5.Text = path;
                Btn_Save.BackColor = Color.Yellow;
                LoggingFlag = true;  
                
            }
            else
            {
                Btn_Save.BackColor = Color.Green;
                LoggingFlag = false;

            }
                

        }


        private void LoggingTimer_Tick(object sender, EventArgs e)
        {
                ExpTimer++;
                label1.Text =ExpTimer.ToString();
              
        }


        // wave 1 Frequency
        private void radioButton_W1F960_Click(object sender, EventArgs e)
        {
            Wave1Frequency = 960;
            if (RunStop && RealTimeChange) send_string("Wave1Frequency:" + Wave1Frequency.ToString()); 
        }

        private void radioButton_W1F1000_Click(object sender, EventArgs e)
        {
            Wave1Frequency = 1000;
            if (RunStop && RealTimeChange) send_string("Wave1Frequency:" + Wave1Frequency.ToString());
        }
        
        private void radioButton_W1F1020_Click(object sender, EventArgs e)
        {
            Wave1Frequency = 1020;
            if (RunStop && RealTimeChange) send_string("Wave1Frequency:" + Wave1Frequency.ToString());
        }

        private void radioButton_W1F2000_Click(object sender, EventArgs e)
        {
            Wave1Frequency = 2000;
            if (RunStop && RealTimeChange) send_string("Wave1Frequency:" + Wave1Frequency.ToString());
        }

        // wave 1 Amplitude (micro Amp)
        private void radioButton_W1A0_5_Click(object sender, EventArgs e)
        {
            Wave1Amplitude = 500;
            if (RunStop && RealTimeChange) send_string("Wave1Amplitude:" + Wave1Amplitude.ToString());
        }

        private void radioButton_W1A1_Click(object sender, EventArgs e)
        {
            Wave1Amplitude = 1000;
            if (RunStop && RealTimeChange) send_string("Wave1Amplitude:" + Wave1Amplitude.ToString());
        }

        private void radioButton_W1A1_5_Click(object sender, EventArgs e)
        {
            Wave1Amplitude = 2000;
            if (RunStop && RealTimeChange) send_string("Wave1Amplitude:" + Wave1Amplitude.ToString());
        }

        private void radioButton_W1A2_Click(object sender, EventArgs e)
        {
            Wave1Amplitude = 5000;
            if (RunStop && RealTimeChange) send_string("Wave1Amplitude:" + Wave1Amplitude.ToString());
        }

        // wave 2 Frequency
        private void radioButton_W2F960_Click(object sender, EventArgs e)
        {
            Wave2Frequency = 960;
            if (RunStop && RealTimeChange) send_string("Wave2Frequency:" + Wave2Frequency.ToString());
        }

        private void radioButton_W2F1000_Click(object sender, EventArgs e)
        {
            Wave2Frequency = 1000;
            if (RunStop && RealTimeChange) send_string("Wave2Frequency:" + Wave2Frequency.ToString());
        }

        private void radioButton_W2F1020_Click(object sender, EventArgs e)
        {
            Wave2Frequency = 1020;
            if (RunStop && RealTimeChange) send_string("Wave2Frequency:" + Wave2Frequency.ToString());
        }

        private void radioButton_W2F2000_Click(object sender, EventArgs e)
        {
            Wave2Frequency = 2020;
            if (RunStop && RealTimeChange) send_string("Wave2Frequency:" + Wave2Frequency.ToString());
        }

        // wave 2 Amplitude (micro Amp)
        private void radioButton_W2A0_5_Click(object sender, EventArgs e)
        {
            Wave2Amplitude = 500;
            if (RunStop && RealTimeChange) send_string("Wave2Amplitude:" + Wave2Amplitude.ToString());
        }

        private void radioButton_W2A1_Click(object sender, EventArgs e)
        {
            Wave2Amplitude = 1000;
            if (RunStop && RealTimeChange) send_string("Wave2Amplitude:" + Wave2Amplitude.ToString());
        }

        private void radioButton_W2A1_5_Click(object sender, EventArgs e)
        {
            Wave2Amplitude = 2000;
            if (RunStop && RealTimeChange) send_string("Wave2Amplitude:" + Wave2Amplitude.ToString());
        }

        private void radioButton_W2A2_Click(object sender, EventArgs e)
        {
            Wave2Amplitude = 5000;
            if (RunStop && RealTimeChange) send_string("Wave2Amplitude:" + Wave2Amplitude.ToString());
        }

        private void radioButton_W1F960_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_W2F2000_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            button_RunStop.BackColor = Color.Green;
            button_RunStop.Text = "Run";
            LoggingTimer.Enabled = false;
            RunT.Enabled = false;
            statePort = 0;
            ExpTimer = 0;

        }
    }
}
