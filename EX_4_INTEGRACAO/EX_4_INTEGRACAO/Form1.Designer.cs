namespace EX_4_INTEGRACAO
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
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.Location = new System.Drawing.Point(137, 117);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(109, 13);
            this.lbl_nota1.TabIndex = 0;
            this.lbl_nota1.Text = "Digite a primeira nota:";
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(140, 133);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 20);
            this.txt_nota1.TabIndex = 1;
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(140, 195);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 20);
            this.txt_nota2.TabIndex = 3;
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.Location = new System.Drawing.Point(137, 179);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(114, 13);
            this.lbl_nota2.TabIndex = 2;
            this.lbl_nota2.Text = "Digite a segunda nota:";
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(140, 265);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(100, 20);
            this.txt_nota3.TabIndex = 5;
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.Location = new System.Drawing.Point(137, 249);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(108, 13);
            this.lbl_nota3.TabIndex = 4;
            this.lbl_nota3.Text = "Digite a terceira nota:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(320, 195);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 8;
            this.txt_resultado.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sua média é:";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 493);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.lbl_nota3);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.lbl_nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

