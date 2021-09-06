using System;
using System.Drawing;
using System.Windows.Forms;

namespace Voltmeter
{
	public partial class Form1 : Form
	{
		public delegate void USARTLesen();
		public USARTLesen USARTLesenPtr;
		public Form1()
		{
			InitializeComponent();
			USARTLesenPtr = new USARTLesen(StringLesen);
			buttonConnect.BackColor = Color.Coral;
		}
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			this.Invoke(USARTLesenPtr);
		}
		private void StringLesen()
		{
			string eingabe = serialPort1.ReadLine();
			textBoxIN.Text = eingabe;
		}
		void ButtonConnectClick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen == false)
			{
				try
				{
					serialPort1.PortName = textBoxCOM.Text;
					serialPort1.Open();
					serialPort1.DiscardInBuffer();
					serialPort1.BaseStream.Flush();
					buttonConnect.Text = "disconnect";
					buttonConnect.BackColor = Color.LightGreen;
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
				buttonConnect.BackColor = Color.Coral;
			}
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Willst du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes && serialPort1.IsOpen)
			{
				serialPort1.DiscardInBuffer();
				serialPort1.BaseStream.Flush();
				serialPort1.Close();
			}
			else if (dialogResult == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
		void ButtonResetClick(object sender, EventArgs e)
		{
			textBoxIN.Text = "";
		}
    }
}
