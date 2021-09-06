/*
 * Created by SharpDevelop.
 * User: Josef Pedevilla
 * Date: 20.10.2020
 * Time: 22:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace myMonitor0
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.TextBox textBoxCOM;
		private System.Windows.Forms.Button buttonReset;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox textBoxIN;
		private System.Windows.Forms.CheckBox checkBoxOverwrite;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxR;
		private System.Windows.Forms.TextBox textBoxCWert;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCWert2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxR2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxHoch;
		private System.Windows.Forms.TextBox textBoxKlein;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxTief2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxHoch2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TrackBar trackBarX;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TrackBar trackBarY;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TrackBar trackBarY2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TrackBar trackBarX2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBoxTau2;
		private System.Windows.Forms.TextBox textBoxTau;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button buttonBerechnen2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button buttonBerechnen;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxCOM = new System.Windows.Forms.TextBox();
            this.textBoxIN = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCWert2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHoch = new System.Windows.Forms.TextBox();
            this.textBoxKlein = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTief2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxHoch2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBarY2 = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBarX2 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxTau2 = new System.Windows.Forms.TextBox();
            this.textBoxTau = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonBerechnen2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxCWert = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(22, 20);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(124, 29);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // textBoxCOM
            // 
            this.textBoxCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCOM.Location = new System.Drawing.Point(22, 66);
            this.textBoxCOM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCOM.Name = "textBoxCOM";
            this.textBoxCOM.Size = new System.Drawing.Size(52, 23);
            this.textBoxCOM.TabIndex = 1;
            this.textBoxCOM.Text = "COM3";
            // 
            // textBoxIN
            // 
            this.textBoxIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIN.Location = new System.Drawing.Point(28, 458);
            this.textBoxIN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIN.Multiline = true;
            this.textBoxIN.Name = "textBoxIN";
            this.textBoxIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIN.Size = new System.Drawing.Size(125, 287);
            this.textBoxIN.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Aqua;
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(22, 135);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(124, 29);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOverwrite.Location = new System.Drawing.Point(22, 101);
            this.checkBoxOverwrite.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(92, 22);
            this.checkBoxOverwrite.TabIndex = 4;
            this.checkBoxOverwrite.Text = "overwrite";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(217, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 591);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Widerstandswert eingeben:";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR.Location = new System.Drawing.Point(28, 280);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(125, 26);
            this.textBoxR.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kondensatorwert:";
            // 
            // textBoxCWert2
            // 
            this.textBoxCWert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCWert2.Location = new System.Drawing.Point(1028, 197);
            this.textBoxCWert2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCWert2.Name = "textBoxCWert2";
            this.textBoxCWert2.ReadOnly = true;
            this.textBoxCWert2.Size = new System.Drawing.Size(125, 26);
            this.textBoxCWert2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1028, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kondensatorwert:";
            // 
            // textBoxR2
            // 
            this.textBoxR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR2.Location = new System.Drawing.Point(1028, 135);
            this.textBoxR2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(125, 26);
            this.textBoxR2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1028, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Widerstandswert eingeben:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(1217, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(794, 591);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(217, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Graph 1:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1217, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Graph 2:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1028, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Graph 1:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1028, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Höchster Wert:";
            // 
            // textBoxHoch
            // 
            this.textBoxHoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoch.Location = new System.Drawing.Point(1028, 358);
            this.textBoxHoch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHoch.Name = "textBoxHoch";
            this.textBoxHoch.Size = new System.Drawing.Size(125, 24);
            this.textBoxHoch.TabIndex = 19;
            // 
            // textBoxKlein
            // 
            this.textBoxKlein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKlein.Location = new System.Drawing.Point(1028, 418);
            this.textBoxKlein.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKlein.Name = "textBoxKlein";
            this.textBoxKlein.Size = new System.Drawing.Size(125, 24);
            this.textBoxKlein.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1028, 396);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kleinster Wert:";
            // 
            // textBoxTief2
            // 
            this.textBoxTief2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTief2.Location = new System.Drawing.Point(1028, 566);
            this.textBoxTief2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTief2.Name = "textBoxTief2";
            this.textBoxTief2.ReadOnly = true;
            this.textBoxTief2.Size = new System.Drawing.Size(125, 24);
            this.textBoxTief2.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1028, 545);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kleinster Wert:";
            // 
            // textBoxHoch2
            // 
            this.textBoxHoch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoch2.Location = new System.Drawing.Point(1028, 507);
            this.textBoxHoch2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHoch2.Name = "textBoxHoch2";
            this.textBoxHoch2.Size = new System.Drawing.Size(125, 24);
            this.textBoxHoch2.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1028, 486);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Höchster Wert:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1028, 462);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Graph 2:";
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(217, 665);
            this.trackBarX.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarX.Minimum = 1;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(214, 45);
            this.trackBarX.TabIndex = 27;
            this.trackBarX.Value = 5;
            this.trackBarX.Scroll += new System.EventHandler(this.TrackBarXScroll);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(220, 644);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "X-Skalierung:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(484, 644);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 19);
            this.label14.TabIndex = 30;
            this.label14.Text = "Y-Skalierung:";
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(482, 665);
            this.trackBarY.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarY.Minimum = 1;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(214, 45);
            this.trackBarY.TabIndex = 29;
            this.trackBarY.Value = 1;
            this.trackBarY.Scroll += new System.EventHandler(this.TrackBarYScroll);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1487, 644);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "Y-Skalierung:";
            // 
            // trackBarY2
            // 
            this.trackBarY2.Location = new System.Drawing.Point(1484, 665);
            this.trackBarY2.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarY2.Minimum = 1;
            this.trackBarY2.Name = "trackBarY2";
            this.trackBarY2.Size = new System.Drawing.Size(214, 45);
            this.trackBarY2.TabIndex = 33;
            this.trackBarY2.Value = 1;
            this.trackBarY2.Scroll += new System.EventHandler(this.TrackBarY2Scroll);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1217, 644);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 19);
            this.label16.TabIndex = 32;
            this.label16.Text = "X-Skalierung:";
            // 
            // trackBarX2
            // 
            this.trackBarX2.Location = new System.Drawing.Point(1217, 665);
            this.trackBarX2.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarX2.Minimum = 1;
            this.trackBarX2.Name = "trackBarX2";
            this.trackBarX2.Size = new System.Drawing.Size(214, 45);
            this.trackBarX2.TabIndex = 31;
            this.trackBarX2.Value = 5;
            this.trackBarX2.Scroll += new System.EventHandler(this.TrackBarX2Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1028, 238);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 19);
            this.label17.TabIndex = 35;
            this.label17.Text = "Zeitkonstante Tau:";
            // 
            // textBoxTau2
            // 
            this.textBoxTau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTau2.Location = new System.Drawing.Point(1028, 259);
            this.textBoxTau2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTau2.Name = "textBoxTau2";
            this.textBoxTau2.ReadOnly = true;
            this.textBoxTau2.Size = new System.Drawing.Size(125, 26);
            this.textBoxTau2.TabIndex = 36;
            // 
            // textBoxTau
            // 
            this.textBoxTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTau.Location = new System.Drawing.Point(28, 408);
            this.textBoxTau.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTau.Name = "textBoxTau";
            this.textBoxTau.ReadOnly = true;
            this.textBoxTau.Size = new System.Drawing.Size(125, 26);
            this.textBoxTau.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 387);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 19);
            this.label18.TabIndex = 37;
            this.label18.Text = "Zeitkonstante Tau:";
            // 
            // buttonBerechnen2
            // 
            this.buttonBerechnen2.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBerechnen2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerechnen2.Location = new System.Drawing.Point(1028, 59);
            this.buttonBerechnen2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBerechnen2.Name = "buttonBerechnen2";
            this.buttonBerechnen2.Size = new System.Drawing.Size(184, 38);
            this.buttonBerechnen2.TabIndex = 39;
            this.buttonBerechnen2.Text = "Kondensator";
            this.buttonBerechnen2.UseVisualStyleBackColor = false;
            this.buttonBerechnen2.Click += new System.EventHandler(this.ButtonBerechnen2Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1028, 38);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(184, 19);
            this.label19.TabIndex = 40;
            this.label19.Text = "Berechnen:";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 187);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 19);
            this.label20.TabIndex = 44;
            this.label20.Text = "Berechnen:";
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBerechnen.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerechnen.Location = new System.Drawing.Point(22, 208);
            this.buttonBerechnen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(184, 38);
            this.buttonBerechnen.TabIndex = 43;
            this.buttonBerechnen.Text = "Kondensator";
            this.buttonBerechnen.UseVisualStyleBackColor = false;
            this.buttonBerechnen.Click += new System.EventHandler(this.ButtonBerechnenClick);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(156, 346);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 19);
            this.label21.TabIndex = 45;
            this.label21.Text = "uF";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(156, 284);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 19);
            this.label22.TabIndex = 46;
            this.label22.Text = "Ohm";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(156, 411);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 19);
            this.label23.TabIndex = 47;
            this.label23.Text = "ms";
            // 
            // textBoxCWert
            // 
            this.textBoxCWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCWert.Location = new System.Drawing.Point(28, 343);
            this.textBoxCWert.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCWert.Name = "textBoxCWert";
            this.textBoxCWert.Size = new System.Drawing.Size(125, 26);
            this.textBoxCWert.TabIndex = 48;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1156, 138);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 19);
            this.label24.TabIndex = 49;
            this.label24.Text = "Ohm";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1156, 201);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 19);
            this.label25.TabIndex = 50;
            this.label25.Text = "uF";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1156, 262);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 19);
            this.label26.TabIndex = 51;
            this.label26.Text = "ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2032, 752);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBoxCWert);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonBerechnen2);
            this.Controls.Add(this.textBoxTau);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxTau2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.trackBarY2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.trackBarX2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.textBoxTief2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxHoch2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxKlein);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHoch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxCWert2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxOverwrite);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxIN);
            this.Controls.Add(this.textBoxCOM);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "myMonitor0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
