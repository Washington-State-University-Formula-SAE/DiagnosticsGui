using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace FSAE_Diagnostics_Tool
{

    public class FixedSizedQueue<T>
    {
        ConcurrentQueue<T> q = new ConcurrentQueue<T>();
        private object lockObject = new object();

        public int Limit { get; set; }
        public void Enqueue(T obj)
        {
            q.Enqueue(obj);
            lock (lockObject)
            {
                T overflow;
                while (q.Count > Limit && q.TryDequeue(out overflow)) ;
            }
        }
    }

    public partial class Form1 : Form
    {
        static FixedSizedQueue<ushort> circbuf;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // list names of available ports in array
            portComboBox.Items.AddRange(ports); // add array to combobox
            portComboBox.SelectedIndex = 0;
            closeButton.Enabled = false;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); // subscribe to data received event

            serialPort2.RtsEnable = true;
            serialPort2.Open();

            circbuf = new FixedSizedQueue<ushort>();
            circbuf.Limit = 2;

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openButton.Enabled = false;
            closeButton.Enabled = true;
            try // try and open the selected port
            {
                serialPort1.PortName = portComboBox.Text;
                serialPort1.RtsEnable = true;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            openButton.Enabled = true;
            closeButton.Enabled = false;
            try // try and close the selected port
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] dataBuffer;
            
            int bytes = sp.BytesToRead; // get number of incoming bytes
            dataBuffer = new byte[bytes]; // create buffer to hold incoming data

            sp.Read(dataBuffer, 0, bytes);

            SendData(dataBuffer);
        }

        delegate void SendDataCallback(string data);

        private void SendData(byte[] dataBuffer) // Method to put data in textbox
        {

            string temp = "";
            for(int i = 0; i < dataBuffer.Length; i++)
            {
                circbuf.Enqueue(dataBuffer[i]);
                temp += Convert.ToString((int)dataBuffer[i]) + " ";
            }

            MessageBox.Show(temp);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); // close port if it's still open

                serialPort2.Close(); // DELETE ME!
            }
        }

        delegate void SplitDataCallback(string data);

        private void SplitData(string data) // Method to split data into different categories
        {
            if (this.receiveTextBox.InvokeRequired)
            {
                SplitDataCallback d = new SplitDataCallback(SplitData);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                string[] pattern = { @"(?<=A)[0-9]+", @"(?<=B)[0-9]+", @"(?<=C)[0-9]+" }; // change the # to the delimiter used @"(?<=#)[0-9]+"
                for (int i = 1; i < 4; i++)
                {
                    Regex r = new Regex(pattern[i - 1]);
                    MatchCollection mc1 = r.Matches(data);
                    int j = 0;
                    foreach (Match matches in mc1)
                    {
                        TextBox delimTextbox = (TextBox)this.Controls.Find("delim" + i + "TextBox", true).FirstOrDefault();
                        delimTextbox.Text += mc1[j] + Environment.NewLine;
                        j++;
                    }
                }
            }
        }

            // TEST BUTTON DELETE ME!
            private void testButton_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[3];
            data[0] = 0xFF;
            data[1] = 0x01;
            data[2] = 0xFE;

            string test = textBox1.Text;
            serialPort2.Write(data, 0, 3);
        }

        private void receiveTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
