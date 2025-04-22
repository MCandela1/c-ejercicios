using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Paciente
{
    internal class Paciente
    {
        public long DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string ObraSocial { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine("=== DATOS DEL PACIENTE ===");
            Console.WriteLine($"DNI: {DNI}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Obra social: {ObraSocial}");
        }
    }
}
