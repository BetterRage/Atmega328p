using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using System.IO;
using System.IO.Ports;

namespace Oszilloskop
{
    public partial class Form1 : Form
    {
        readonly Stopwatch time;
        List<Point> points;
        public delegate void USARTLesen();
        public USARTLesen USARTLesenPtr;
        bool stop = false;
        public Form1()
        {
            InitializeComponent();
            points = new List<Point>();
            
            time = new Stopwatch();
        }
        private void Ladekurve()
        {
            string input = "0";
            if (!stop)
            {
                input = serialPort1.ReadLine();
            }
            
            int ykoord = (int)500-(Convert.ToInt16(input)*500/1023);
            int xkoord = (int)time.ElapsedMilliseconds;
            if(ykoord<500)
            {
                points.Add(new Point(xkoord, ykoord));
                
            }
            else
                time.Stop();
            
            label1.Text = (500-ykoord).ToString();
            if(ykoord<=0)
            {
                DatenSpeichern();
                stop = true;
            }
            if(!stop)
            {
                serialPort1.WriteLine("1");
            }
                
            
        }
        
        private void DatenSpeichern()
        {
            
            Point[] pointsarray = points.ToArray();
            float xmaxfaktor = pointsarray[pointsarray.Length - 1].X / 1000f;
            for(int i=0;i<pointsarray.Length;i++)
            {
                pointsarray[i].X = Convert.ToInt16(pointsarray[i].X / xmaxfaktor);
            }
            Bitmap bild = new Bitmap(1000, 500);

            Graphics graph = Graphics.FromImage(bild);

            Pen stift = new Pen(Color.Red, 2);
            graph.Clear(Color.White);
            graph.DrawCurve(stift, pointsarray);
            pictureBox1.Image = bild;
            bild.Save(Path.Combine(Environment.CurrentDirectory, "bild.bmp"));
            stop = true;
            serialPort1.DiscardInBuffer();
            serialPort1.BaseStream.Flush();
            serialPort1.Close();

        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.BeginInvoke(USARTLesenPtr);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            cmbPort.DataSource = ports;
        }

        private void cmbPort_SelectionChangeCommitted(object sender, EventArgs e)
        { 
            serialPort1.PortName = cmbPort.SelectedText;
            
        }
        private void btnLadekurve_Click(object sender, EventArgs e)
        {

            USARTLesenPtr = new USARTLesen(Ladekurve);
            serialPort1.Open();
            serialPort1.WriteLine("1");
            time.Start();
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           