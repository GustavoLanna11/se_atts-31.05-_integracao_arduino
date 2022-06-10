namespace ex_3_integracao
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
            this.btn_piscar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btn_ligar
            // 
            this.btn_ligar.Location = new System.Drawing.Point(290, 164);
            this.btn_ligar.Name = "btn_ligar";
            this.btn_ligar.Size = new System.Drawing.Size(75, 23);
            this.btn_ligar.TabIndex = 0;
            this.btn_ligar.Text = "LIGAR";
            this.btn_ligar.UseVisualStyleBackColor = true;
            this.btn_ligar.Click += new System.EventHandler(this.btn_ligar_Click);
            // 
            // btn_piscar
            // 
            this.btn_piscar.Location = new System.Drawing.Point(290, 221);
            this.btn_piscar.Name = "btn_piscar";
            this.btn_piscar.Size = new System.Drawing.Size(75, 23);
            this.btn_piscar.TabIndex = 1;
            this.btn_piscar.Text = "PISCAR";
            this.btn_piscar.UseVisualStyleBackColor = true;
            this.btn_piscar.Click += new System.EventHandler(this.btn_piscar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 413);
            this.Controls.Add(this.btn_piscar);
            this.Controls.Add(this.btn_ligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ligar;
        private System.Windows.Forms.Button btn_piscar;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

