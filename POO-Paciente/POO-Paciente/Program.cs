using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Paciente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Ingrese los datos del doctor:");
            Console.Write("Legajo: ");
            doctor.Legajo = int.Parse(Console.ReadLine());
            Console.Write("Años de experiencia: ");
            doctor.Experiencia = short.Parse(Console.ReadLine());
            Console.Write("Apellido: ");
            doctor.Apellido = Console.ReadLine();
            Console.Write("Nombre: ");
            doctor.Nombre = Console.ReadLine();
            Console.Write("Especialidad: ");
            doctor.Especialidad = Console.ReadLine();

            Paciente[] pacientes = new Paciente[4];

            for (int i = 0; i < pacientes.Length; i++)
            {
                Console.WriteLine($"\nIngrese los datos del paciente {i + 1}:");
                pacientes[i] = new Paciente();

                Console.Write("DNI: ");
                pacientes[i].DNI = long.Parse(Console.ReadLine());
                Console.Write("Apellido: ");
                pacientes[i].Apellido = Console.ReadLine();
                Console.Write("Nombre: ");
                pacientes[i].Nombre = Console.ReadLine();
                Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
                pacientes[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.Write("Edad: ");
                pacientes[i].Edad = int.Parse(Console.ReadLine());
                Console.Write("Obra social: ");
                pacientes[i].ObraSocial = Console.ReadLine();
            }

            Console.Clear();
            doctor.MostrarDatos();

            foreach (Paciente p in pacientes)
            {
                Console.WriteLine();
                p.MostrarDatos();
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
