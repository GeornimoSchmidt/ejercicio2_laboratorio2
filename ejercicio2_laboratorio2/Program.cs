using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dos dados a la vez 1-10 y otro 11-20
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 11);
            int aleatorio2 = dado.Next(11, 21);
            Console.WriteLine("El num del 1° dado es {0}", aleatorio1);
            Console.WriteLine("El num del 2° dado es {0}", aleatorio2);
            Console.ReadKey();
        }
    }
}
