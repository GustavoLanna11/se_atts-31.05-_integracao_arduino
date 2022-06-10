using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_4_INTEGRACAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo cl = new calculo();

            double nota1, nota2, nota3;
            nota1 = double.Parse(txt_nota1.Text);
            nota2 = double.Parse(txt_nota2.Text);
            nota3 = double.Parse(txt_nota3.Text);

            txt_resultado.Text = cl.calculo_soma(nota1, nota2, nota3).ToString();


            serialPort1.Open();
            serialPort1.Write(txt_resultado.ToString());
            serialPort1.Close();
      



        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
