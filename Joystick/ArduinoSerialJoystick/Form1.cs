using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace ArduinoSerialJoystick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serial1.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
            serial1.Open();
            serial1.BaseStream.Flush();
            serial1.DiscardInBuffer();
        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string[] koords = serial1.ReadExisting().Split(' ');
            Point punkt = new Point();
            try
            {
                punkt.X = Convert.ToInt32(koords[0]);
                punkt.Y = Convert.ToInt32(koords[1]);
            }
            catch
            {
                punkt.X = 129;
                punkt.Y = 129;
            }
            pnlPos.Invoke(new Action(() =>
            {
                pnlPos.Location = punkt;
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial1.Close();
            serial1 = null;
        }
    }
}
