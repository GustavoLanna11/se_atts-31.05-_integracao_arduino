using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_1_INTEGRACAO
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
            serialPort1.Write("L");
            serialPort1.Close();
        }

        private void btn_desligar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
