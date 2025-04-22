using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Paciente
{
    internal class Doctor
    {
        public int Legajo { get; set; }
        public short Experiencia { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine("=== DATOS DEL DOCTOR ===");
            Console.WriteLine($"Legajo: {Legajo}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Años de experiencia: {Experiencia}");
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }
}
