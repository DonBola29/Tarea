using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, impar = 0, par = 0;

            for (i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("Los numeros pares son: {0}", i);
                    impar++;

                }
            }
        }
    }
}
