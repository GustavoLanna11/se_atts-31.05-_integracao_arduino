using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_3_integracao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ligar_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("K");
            serialPort1.Close();
        }

        private void btn_piscar_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("P");
            serialPort1.Close();
        }
    }
}
