using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPOO6_22_04_25
{
    internal class Empleado
    {
        private string nombre;
        private string apellido;
        private string cuil;
        private DateTime fechaNacimiento;

        public Empleado(string nombre, string apellido, string cuil, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Nombre => nombre;
        public string Apellido => apellido;
        public string CUIL => cuil;
        public DateTime FechaNacimiento => fechaNacimiento;

        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (DateTime.Now < fechaNacimiento.AddYears(edad))
                    edad--;
                return edad;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Empleado:");
            Console.WriteLine($"Nombre completo: {nombre} {apellido}");
            Console.WriteLine($"CUIL: {cuil}");
            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine("----");
        }
    }
}
