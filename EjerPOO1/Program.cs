using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona p1 = new persona();
            p1.nombre = "juan";
            p1.edad = 13430;

            Console.WriteLine($"Su nombre es: {p1.nombre}");
            Console.WriteLine($"Su edad es: {p1.edad}");


            Bolilla bol = new Bolilla();
            bol.color = "AZUL";
            bol.numero = 10;

            Console.WriteLine($"Su color es: {bol.color}");
            Console.WriteLine($"Su numero es: {bol.numero}");


            Console.ReadKey();
        }
    }
}
