using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cua = new Cuadrado(color.azul,12,ubicacion.arriba);
            Rectangulo rec = new Rectangulo(color.rojo, 10, 5, ubicacion.derecha);

            Console.WriteLine("***** Datos del Cuadrado *****");
            Console.WriteLine(cua.colorRelleno);
            Console.WriteLine(cua.ladoA.ToString());
            Console.WriteLine(cua.posicion);

            Console.WriteLine("***** Datos del Rectangulo *****");
            Console.WriteLine(rec.colorRelleno);
            Console.WriteLine(rec.ladoA.ToString());
            Console.WriteLine(rec.ladoB.ToString());
            Console.WriteLine(rec.posicion);

            Console.ReadKey();
        }
    }
}
