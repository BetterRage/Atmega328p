/*
 * Created by SharpDevelop.
 * User: Josef Pedevilla
 * Date: 20.10.2020
 * Time: 22:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace myMonitor0
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public delegate void USARTLesen();
		public USARTLesen USARTLesenPtr;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			USARTLesenPtr = new USARTLesen(StringLesen);
			buttonConnect.BackColor=Color.Coral;
			
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			this.BeginInvoke(USARTLesenPtr);	
		}
		
		private void StringLesen()
		{
			string text = serialPort1.ReadLine();
			string[] koords = text.Split(' ');
			Point punkt = new Point();
			try
			{
				punkt.X = Convert.ToInt32(koords[0]);
				punkt.Y = 255-Convert.ToInt32(koords[1]);
			}
			catch
			{
				punkt.X = 129;
				punkt.Y = 129;
			}
			pnlPos.Location = punkt;
			textBoxIN.Text=text;

			serialPort1.WriteLine("1");
		}
		
		void ButtonConnectClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen==false)
			{
				try
				{
					serialPort1.PortName = textBoxCOM.Text;
					serialPort1.Open();
					serialPort1.DiscardInBuffer();
					serialPort1.BaseStream.Flush();
					serialPort1.WriteLine("1");
					buttonConnect.Text = "disconnect";
					buttonConnect.BackColor=Color.LightGreen;
				}
				catch
				{
					MessageBox.Show("Bitte den richtigen COM-PORT auswählen!");
				}
						
			}				
			else
			{

				serialPort1.DiscardInBuffer();
				serialPort1.BaseStream.Flush();
				serialPort1.Close();
				buttonConnect.Text = "Connect";
				buttonConnect.BackColor=Color.Coral;
			}			
		}
		
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
    		DialogResult dialogResult = MessageBox.Show("Willst du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes&&serialPort1.IsOpen)
			{

				serialPort1.DiscardInBuffer();
				serialPort1.BaseStream.Flush();
				serialPort1.Close();
			}
			else if (dialogResult == DialogResult.No)
			{
				e.Cancel=true;
			}
   		}
		
		void ButtonResetClick(object sender, EventArgs e)
		{
			textBoxIN.Text="";	
		}
	}
}
