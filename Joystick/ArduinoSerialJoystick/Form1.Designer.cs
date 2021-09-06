
namespace ArduinoSerialJoystick
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPos = new System.Windows.Forms.Panel();
            this.serial1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // pnlPos
            // 
            this.pnlPos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlPos.ForeColor = System.Drawing.Color.Crimson;
            this.pnlPos.Location = new System.Drawing.Point(114, 74);
            this.pnlPos.Name = "pnlPos";
            this.pnlPos.Size = new System.Drawing.Size(32, 30);
            this.pnlPos.TabIndex = 0;
            // 
            // serial1
            // 
            this.serial1.PortName = "COM3";
            this.serial1.RtsEnable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(412, 337);
            this.Controls.Add(this.pnlPos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPos;
        private System.IO.Ports.SerialPort serial1;
    }
}

