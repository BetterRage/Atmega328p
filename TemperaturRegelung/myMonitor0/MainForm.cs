/*
 * Created by SharpDevelop.
 * User: Josef Pedevilla
 * Date: 20.10.2020
 * Time: 22:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace myMonitor0
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private delegate void USARTLesen();
		private USARTLesen USARTLesenPtr;
		private List<temperaturDataObj> temperaturDaten;
		
		private bool senden = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			USARTLesenPtr = new USARTLesen(StringLesen);
			btnConnect.BackColor=Color.Coral;
			temperaturDaten = new List<temperaturDataObj>();
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			this.Invoke(USARTLesenPtr);	
		}
		
		private void StringLesen()
		{
			temperaturDaten.Add(new temperaturDataObj(serialPort1.ReadLine(),ckbLog.Checked,DateTime.Now));
			textBoxIN.AppendText(temperaturDaten[temperaturDaten.Count-1].TemperaturString + "° ");
			textBoxIN.AppendText(temperaturDaten[temperaturDaten.Count - 1].Zeit.TimeOfDay.ToString("hh\\:mm\\:ss\\.ff")+" ");
			textBoxIN.AppendText(temperaturDaten[temperaturDaten.Count - 1].Logged ? "✓\r\n" : "\r\n");
		}
		
		void btnConnect_Click(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen==false)
				{
					try
					{
						serialPort1.PortName = txtCOM.Text;
						serialPort1.Open();
						btnConnect.Text = "disconnect";
						btnConnect.BackColor=Color.LightGreen;
						
					}
					catch
					{
						MessageBox.Show("Bitte den richtigen COM-PORT auswählen!");
					}
						
				}				
			else
			{
				senden = false;
				btnStart.Text = "start";
				serialPort1.Write("b");
				serialPort1.Close();
				btnConnect.Text = "connect";
				btnConnect.BackColor=Color.Coral;
			}			
		}
		
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
    		//if (e.CloseReason == CloseReason.WindowsShutDown) return;
    		DialogResult dialogResult = MessageBox.Show("Willst du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				if(serialPort1.IsOpen)
                {
					serialPort1.Write("b");
					serialPort1.Close();
                }

			}
			else if (dialogResult == DialogResult.No)
			{
				e.Cancel=true;
			}
   		}
		
		void btnReset_Click(object sender, EventArgs e)
		{
			textBoxIN.Text="";	
		}

        private void btnStart_Click(object sender, EventArgs e)
        {
			if(serialPort1.IsOpen)
            {
                if (senden)
                {
					serialPort1.Write("b");
					btnStart.Text = "start";
				}
				else
                {
					serialPort1.Write("s");
					btnStart.Text = "stop";
				}
				senden = !senden;
			}
			
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
			if(serialPort1.IsOpen)
            {
				DialogResult dialogResult = MessageBox.Show("COM-Port schließen?", "COM-Port", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					senden = false;
					btnStart.Text = "start";
					serialPort1.Write("b");
					serialPort1.Close();
					btnConnect.Text = "connect";
					btnConnect.BackColor = Color.Coral;
				}
				else return;
			}
			StreamWriter csv = new StreamWriter("Werte" + "_" + DateTime.Today.ToString("dd-MM-yyyy") + ".csv",false,Encoding.GetEncoding("Windows-1252"));
			csv.Write("Zeit;Temperatur;");
			csv.WriteLine();
			for (int i=0;i<temperaturDaten.Count;i++)
			{
				if (temperaturDaten[i].Logged)
				{

					csv.Write(temperaturDaten[i].Zeit.TimeOfDay.ToString("hh\\:mm\\:ss\\.ff") + ";");
					csv.Write(temperaturDaten[i].TemperaturString+";");
					csv.WriteLine();
					csv.Flush();
				}
			}
			csv.Close();


		}
    }
}
