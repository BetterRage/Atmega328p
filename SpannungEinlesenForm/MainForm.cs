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
			this.Invoke(USARTLesenPtr);	
		}
		
		private void StringLesen()
		{
			string eingabe;
			int eingabeint;
			eingabe = serialPort1.ReadLine() + "\n";
			textBoxIN.Text = eingabe;
			eingabeint = Convert.ToInt32(eingabe);
			textBoxIN.AppendText (" " + (eingabeint * 4.524 / 255).ToString());
		}
		
		void ButtonConnectClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen==false)
				{
					try
					{
						serialPort1.PortName = textBoxCOM.Text;
						serialPort1.Open();
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
					serialPort1.Close();
					buttonConnect.Text = "Connect";
					buttonConnect.BackColor=Color.Coral;
				}			
		}
		
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
    		//if (e.CloseReason == CloseReason.WindowsShutDown) return;
    		DialogResult dialogResult = MessageBox.Show("Willst du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
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
