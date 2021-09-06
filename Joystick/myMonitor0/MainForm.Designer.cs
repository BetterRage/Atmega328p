﻿/*
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
            this.gpb1 = new System.Windows.Forms.GroupBox();
            this.pnlPos = new System.Windows.Forms.Panel();
            this.gpb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(11, 11);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(98, 30);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // textBoxCOM
            // 
            this.textBoxCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCOM.Location = new System.Drawing.Point(11, 45);
            this.textBoxCOM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCOM.Name = "textBoxCOM";
            this.textBoxCOM.Size = new System.Drawing.Size(52, 23);
            this.textBoxCOM.TabIndex = 1;
            this.textBoxCOM.Text = "COM4";
            // 
            // textBoxIN
            // 
            this.textBoxIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIN.Location = new System.Drawing.Point(113, 11);
            this.textBoxIN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIN.Multiline = true;
            this.textBoxIN.Name = "textBoxIN";
            this.textBoxIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIN.Size = new System.Drawing.Size(176, 286);
            this.textBoxIN.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(11, 267);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(98, 30);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 57600;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
            // 
            // gpb1
            // 
            this.gpb1.Controls.Add(this.pnlPos);
            this.gpb1.Location = new System.Drawing.Point(294, 12);
            this.gpb1.Name = "gpb1";
            this.gpb1.Size = new System.Drawing.Size(300, 300);
            this.gpb1.TabIndex = 5;
            this.gpb1.TabStop = false;
            // 
            // pnlPos
            // 
            this.pnlPos.BackColor = System.Drawing.Color.Red;
            this.pnlPos.Location = new System.Drawing.Point(0, 7);
            this.pnlPos.Name = "pnlPos";
            this.pnlPos.Size = new System.Drawing.Size(45, 45);
            this.pnlPos.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 323);
            this.Controls.Add(this.gpb1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxIN);
            this.Controls.Add(this.textBoxCOM);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "myMonitor0";
            this.gpb1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.GroupBox gpb1;
        private System.Windows.Forms.Panel pnlPos;
    }
}