using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("control de versiones");
            vectorinicialzar();
            Console.ReadKey();
        }

        public static void vectorinicialzar()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1]= 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //imprimir vector
            Console.WriteLine("\nElementos del vector\n========\n");
            for (int i=0;i<8;i++)
            {
                Console.WriteLine("Elemento indice {0}-->{1}", (i + 1),x[i]);
            }
            //sumatoria de los elementos del vector
            int suma=0;
            for (int i = 0; i < x.Length; i++)
            {
                suma=suma+ x[i];

            }
            Console.WriteLine("La sumatoria es {0}", suma);
            Console.WriteLine("La promedio es {0}", suma/x.Length);
        }
    }
}
