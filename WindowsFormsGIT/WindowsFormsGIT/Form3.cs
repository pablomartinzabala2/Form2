using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGIT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int Monto = 7500;
            int c = 0;
            int expensa = 4000;
            int[] vector = new int[24];
            int total = 0;
            for (int i=0;i<24;i++)
            {
                vector[i] = Monto;
                c++;
                if (c ==6)
                {
                    Monto = Monto + Monto * 15 / 100;
                    c = 0;
                }
                total = total + Monto + expensa;
            }
            string msj = "Total pagado " + Monto.ToString ();
            MessageBox.Show(msj);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
