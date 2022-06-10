namespace ex_2_integracao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ligar = new System.Windows.Forms.Button();
            this.btn_desligar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btn_ligar
            // 
            this.btn_ligar.Location = new System.Drawing.Point(197, 132);
            this.btn_ligar.Name = "btn_ligar";
            this.btn_ligar.Size = new System.Drawing.Size(75, 23);
            this.btn_ligar.TabIndex = 0;
            this.btn_ligar.Text = "LIGAR";
            this.btn_ligar.UseVisualStyleBackColor = true;
            this.btn_ligar.Click += new System.EventHandler(this.btn_ligar_Click);
            // 
            // btn_desligar
            // 
            this.btn_desligar.Location = new System.Drawing.Point(197, 196);
            this.btn_desligar.Name = "btn_desligar";
            this.btn_desligar.Size = new System.Drawing.Size(75, 23);
            this.btn_desligar.TabIndex = 1;
            this.btn_desligar.Text = "DESLIGAR";
            this.btn_desligar.UseVisualStyleBackColor = true;
            this.btn_desligar.Click += new System.EventHandler(this.btn_desligar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 383);
            this.Controls.Add(this.btn_desligar);
            this.Controls.Add(this.btn_ligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ligar;
        private System.Windows.Forms.Button btn_desligar;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

