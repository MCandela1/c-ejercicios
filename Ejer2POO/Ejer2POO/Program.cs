using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          Cuadrado cuad = new Cuadrado();

          Console.WriteLine("El Color seleccionado fue: " + cuad.color);

          cuad.lado = 20;
          Console.WriteLine("El Lado mide: " + cuad.lado);

          Console.WriteLine("El Perimetro mide: " + cuad.perimetro);
          */

            Humano h1 = new Humano();
            h1.fechanac = new DateTime(1990, 10, 17);
            Console.WriteLine($"Edad {h1.edad}");

            Console.ReadKey();
        }
    }
}
