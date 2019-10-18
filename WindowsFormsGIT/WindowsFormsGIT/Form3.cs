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
            Randown();
            int Monto = 7500;
            int c = 0;
            int expensa = 4000;
            int[] vector = new int[24];
            int total = 0;
            for (int i = 0; i < 24; i++)
            {
                vector[i] = Monto;
                c++;
                if (c == 6)
                {
                    Monto = Monto + Monto * 15 / 100;
                    c = 0;
                }
                total = total + Monto + expensa;
            }
            string msj = "Total pagado " + Monto.ToString();
            MessageBox.Show(msj);
        }

       


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Randown()
        {
            Random r = new Random();
            int[] vec = new int[37];
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = 0;
            }
            int c = 0;
            int numero = 0;
            while (c < 1000)
            {
                numero = r.Next(0, 37);
                vec[numero] = vec[numero] + 1;
                c++;
            }
            string msj = "";
            for (int i = 0; i < vec.Length; i++)
            {
                msj = "numero " + i.ToString();
                msj = msj + " CANTIDAD " + vec[i].ToString();
                MessageBox.Show(msj);
            }
        }
    }
}
