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
            int n;
            string linea;
            Console.Write("Ingrese multiplicador: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; i <= 15; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
            Console.ReadKey();
            float num;

            Console.Write("Ingrese número:");
            num = float.Parse(Console.ReadLine());

            if (num == 0)
                Console.Write("El {0} no es negativo ni positivo es neutro", num);

            if (num > 0)
                Console.Write("El {0} es positivo", num);
            if (num < 0)
                Console.Write("El {0} es negativo", num);

            Console.Read();
        }
       
        }
    }










