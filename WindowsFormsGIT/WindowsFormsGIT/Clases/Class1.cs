using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGIT.Clases
{
    public class Class1
    {
        public int Suma(int a,int b)
        {
            int c = a + b;
            return c;
        }

        public int Resta(int a,int b)
        {
            int c = a - b;
            return c;
        }

        public int Producto(int a,int b)
        {
            int c = a * b;
            return c;
        }

        public int Division(int a,int b)
        {
            int c = a / b;
            return c;
        }

        public int[] Ordenar(int[] vec)
        {
            int aux = 0;
            for (int i=0;i< vec.Length - 1;i++)
            {
                for (int j=i+1;j<vec.Length;j++)
                {
                    if (vec[j]>vec[i])
                    {
                        aux = vec[j];
                        vec[j] = vec[i];
                        vec[i] = aux; 
                    }
                }
            }
            return vec;
        }

    }
}
