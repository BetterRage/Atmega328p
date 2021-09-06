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
using Diagramme;
using System.Diagnostics; //Damit ein richtiger Timer eingefügt werden kann

namespace myMonitor0
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public delegate void USARTLesen();
		public USARTLesen USARTLesenPtr;
		CDiagramme Zeitverlauf;
		PointF[] Messwerte;
		CDiagramme Zeitverlauf2;
		PointF[] Messwerte2;
		Stopwatch zeit; //Deklaration   //Zeit ist ein Objekt vom Typ Stopwatch
		Stopwatch zeit2;
		int i = 1;
		float t = 0;
		int i2 = 1;
		int skip=0;
		float[] Stellen={0,0};
		float[] Stellen2={0,0};
		int skip2=0;
		bool first=false;
		bool first2=false;
		float Hoch=0;
		float Tief=5;
		float Hoch2=0;
		float Tief2=5;
		string[] Werte = new string[2];
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			USARTLesenPtr = new USARTLesen(StringLesen);
			buttonConnect.BackColor=Color.Coral;
			
			Zeitverlauf = new CDiagramme(pictureBox1,"Zeitdiagramm");
			Messwerte = new PointF[10000];
			Zeitverlauf.PositionUrsprung = "unten-links";
			Zeitverlauf.Anzahl_Teilungen_Y = 10;
			Zeitverlauf.Teilung_Y = 0.5f;
			Zeitverlauf.XEndwert = 50;
			
			Zeitverlauf2 = new CDiagramme(pictureBox2,"Zeitdiagramm");
			Messwerte2 = new PointF[10000];
			Zeitverlauf2.PositionUrsprung = "unten-links";
			Zeitverlauf2.Anzahl_Teilungen_Y = 10;
			Zeitverlauf2.Teilung_Y = 0.5f;
			Zeitverlauf2.XEndwert = 50;
			
			pictureBox1.BackColor=Color.LightSlateGray; //Hintergrund der pictureBox
			pictureBox2.BackColor=Color.LightSlateGray; //Hintergrund der pictureBox
			
			zeit = new Stopwatch();
			zeit2 = new Stopwatch();
			
			//Tau=R*C=10uF*220kOhm=2.2s -> somit werden 22 Punkte pro Tau angegeben
		}
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			this.Invoke(USARTLesenPtr);	
		}
		
		private void StringLesen()
		{	
			string Geschickt = serialPort1.ReadLine();
			Werte = Geschickt.Split(' ');
			try
			{
				Messwerte[i].Y = (float)(Convert.ToDouble(Werte[0])/1023*4.58);
				Messwerte2[i2].Y = (float)(Convert.ToDouble(Werte[1])/1023*4.58);
			}
			catch(Exception probe)
			{
				//MessageBox.Show(string.Format("probe{0}",probe));
			}
			
			Zeitverlauf.XAnfangswert=0;
			Zeitverlauf.XEndwert=(float)(trackBarX.Value)*10;
			Zeitverlauf.Teilung_Y=(float)(trackBarY.Value)/2;
			
			Zeitverlauf2.XAnfangswert=0;
			Zeitverlauf2.XEndwert=(float)(trackBarX2.Value)*10;
			Zeitverlauf2.Teilung_Y=(float)(trackBarY2.Value)/2;
			
			Messwerte[i].X = t;
			//Messwerte[i].Y = (float)(Convert.ToDouble(serialPort1.ReadLine())/1023*4.81);	//Type casting: Wert in einen bestimmten Typen umwandeln
			Messwerte[0].X = i;
			//textBoxIN.Text = Messwerte[i].Y.ToString();
			if(Messwerte[0].X>1)
				Zeitverlauf.Zeitdiagrammzeichnen(Messwerte);
			
			//Höchsten Wert berechnen
			if(Messwerte[i].Y>Hoch)
			{
				Hoch=Messwerte[i].Y;
			}
			
			//Tief Wert berechnen
			if(Messwerte[i].Y<Tief)
			{
				Tief=Messwerte[i].Y;
			}
			
			textBoxHoch.Text = Hoch.ToString("0.00000000");
			textBoxKlein.Text = Tief.ToString("0.00000000");
			
			//Kondensator berechnen
			//Bei T1=R*C 63% von Umax=4.81V	//4.81V*0.63=3.03V
			if(Messwerte[i].Y<=0.03)
			{
				zeit.Stop();
				zeit.Reset();
				zeit.Start();
				//timer1.Start();
				
				//Stellen[0]=Messwerte[i].X;
				skip=0;
				first=true;
			}
			
			if(Messwerte[i].Y>=3.03 && skip!=1)
			{
				zeit.Stop();
				//timer1.Stop();
				
				if(first==true && buttonBerechnen.Text=="Kondensator" && textBoxR.Text!="")
				{
					float R = (float)(Convert.ToDouble(textBoxR.Text));
					textBoxCWert.Text = (1000f*zeit.ElapsedMilliseconds/R).ToString();
				}
				else if(first==true && buttonBerechnen.Text=="Widerstand" && textBoxCWert.Text!="")
				{
					float C = (float)(Convert.ToDouble(textBoxCWert.Text));
					textBoxR.Text = (1000f*zeit.ElapsedMilliseconds/C).ToString();
				}
					
				textBoxTau.Text = (zeit.ElapsedMilliseconds).ToString();
				
				/*Stellen[1]=Messwerte[i].X;
				float Tau = Stellen[1]-Stellen[0];
				float R = (float)(Convert.ToDouble(textBoxR.Text));
				if(first==true)
					textBoxCWert.Text = (1000000*Tau/R).ToString()+"uF";*/
				zeit.Reset();
				skip=1;
			}				
			i++;
			//t+=0.05f;	//f: Type casting einer einzelnen Zahl	//0.1 weil alle 100ms=0.1s von Microcontroller ein Wert geschickt wird
			
			
			Messwerte2[i2].X = t;
			//Messwerte2[i2].Y = (float)(Convert.ToDouble(serialPort1.ReadLine())/1023*4.81);	//Type casting: Wert in einen bestimmten Typen umwandeln
			Messwerte2[0].X = i2;
			//textBoxIN.Text = Messwerte2[i2].Y.ToString();
			if(Messwerte2[0].X>1)
				Zeitverlauf2.Zeitdiagrammzeichnen(Messwerte2);
			
			//Höchsten Wert berechnen
			if(Messwerte2[i2].Y>Hoch2)
			{
				Hoch2=Messwerte2[i2].Y;
			}
			
			//Tief Wert berechnen
			if(Messwerte2[i2].Y<Tief2)
			{
				Tief2=Messwerte2[i2].Y;
			}
			
			textBoxHoch2.Text = Hoch2.ToString("0.00000000");
			textBoxTief2.Text = Tief2.ToString("0.00000000");
			
			//Kondensator berechnen
			//Bei T1=R*C 63% von Umax=4.81V	//4.81V*0.63=3.03V
			if(Messwerte2[i2].Y<=0.03)
			{
				zeit2.Stop();
				zeit2.Reset();
				zeit2.Start();
				//timer1.Start();
				
				//Stellen[0]=Messwerte[i].X;
				skip2=0;
				first2=true;
			}
			
			if(Messwerte2[i2].Y>=3.03 && skip2!=1 && textBoxR2.Text!="")
			{
				zeit2.Stop();
				//timer1.Stop();
				
				if(first2==true && buttonBerechnen2.Text=="Kondensator" && textBoxR2.Text!="")
				{
					float R2 = (float)(Convert.ToDouble(textBoxR2.Text));
					textBoxCWert2.Text = (1000f*zeit2.ElapsedMilliseconds/R2).ToString();
				}
				else if(first2==true && buttonBerechnen2.Text=="Widerstand" && textBoxCWert2.Text!="")
				{
					float C2 = (float)(Convert.ToDouble(textBoxCWert2.Text));
					textBoxR2.Text = (1000f*zeit2.ElapsedMilliseconds/C2).ToString();
				}
					
				textBoxTau.Text = (zeit.ElapsedMilliseconds).ToString();
				
				/*Stellen[1]=Messwerte[i].X;
				float Tau = Stellen[1]-Stellen[0];
				float R = (float)(Convert.ToDouble(textBoxR.Text));
				if(first==true)
					textBoxCWert.Text = (1000000*Tau/R).ToString()+"uF";*/
				zeit2.Reset();
				skip2=1;
			}
			i2++;
			t+=0.05f;	//f: Type casting einer einzelnen Zahl	//0.1 weil alle 100ms=0.1s von Microcontroller ein Wert geschickt wird			
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
			textBoxHoch.Clear();
			textBoxKlein.Clear();
			textBoxHoch2.Clear();
			textBoxTief2.Clear();
			Hoch=0;
			Tief=5;
			Hoch2=0;
			Tief2=5;
			Zeitverlauf.diagrammLöschen();
			i=1;
			t=0;
			Zeitverlauf2.diagrammLöschen();
			i2=1;
		}
		void TrackBarXScroll(object sender, EventArgs e)
		{
			Zeitverlauf.koordinaten_OK=false;
		}
		void TrackBarX2Scroll(object sender, EventArgs e)
		{
			Zeitverlauf2.koordinaten_OK=false;
		}
		void TrackBarY2Scroll(object sender, EventArgs e)
		{
			Zeitverlauf2.koordinaten_OK=false;
		}
		void TrackBarYScroll(object sender, EventArgs e)
		{
			Zeitverlauf.koordinaten_OK=false;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			textBoxIN.Text = zeit.ElapsedMilliseconds.ToString();
		}
		void ButtonBerechnenClick(object sender, EventArgs e)
		{
			if(buttonBerechnen.Text=="Kondensator")
			{
				buttonBerechnen.Text = "Widerstand";
				buttonBerechnen.BackColor = Color.MediumSlateBlue;
				textBoxCWert.ReadOnly = false;
				textBoxR.ReadOnly = true;
			}
			else if(buttonBerechnen.Text=="Widerstand")
			{
				buttonBerechnen.Text = "Kondensator";
				buttonBerechnen.BackColor = Color.OrangeRed;
				textBoxCWert.ReadOnly = true;
				textBoxR.ReadOnly = false;
			}
		}
		void ButtonBerechnen2Click(object sender, EventArgs e)
		{
			if(buttonBerechnen2.Text=="Kondensator")
			{
				buttonBerechnen2.Text = "Widerstand";
				buttonBerechnen2.BackColor = Color.MediumSlateBlue;
				textBoxCWert2.ReadOnly = false;
				textBoxR2.ReadOnly = true;
			}
			else if(buttonBerechnen2.Text=="Widerstand")
			{
				buttonBerechnen2.Text = "Kondensator";
				buttonBerechnen2.BackColor = Color.OrangeRed;
				textBoxCWert2.ReadOnly = true;
				textBoxR2.ReadOnly = false;
			}
		}
    }
}
