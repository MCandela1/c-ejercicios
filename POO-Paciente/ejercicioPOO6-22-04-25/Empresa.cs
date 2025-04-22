using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPOO6_22_04_25
{
    internal class Empresa
    {
        private string razonSocial;
        private string cuit;
        private List<Empleado> empleados;

        public Empresa(string razonSocial, string cuit)
        {
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            this.empleados = new List<Empleado>();
        }
        public string RazonSocial => razonSocial;
        public string CUIT => cuit;

        public void ContratarEmpleado(Empleado nuevoEmpleado)
        {
            empleados.Add(nuevoEmpleado);
            Console.WriteLine($"Empleado {nuevoEmpleado.Nombre} {nuevoEmpleado.Apellido} contratado.");
        }
        public void MostrarEmpleados()
        {
            Console.WriteLine($"--- Empleados de la empresa {razonSocial} ---");
            foreach (Empleado emp in empleados)
            {
                emp.MostrarDatos();
            }
        }

        public void MostrarDatosEmpresa()
        {
            Console.WriteLine("Datos de la empresa:");
            Console.WriteLine($"Razón Social: {razonSocial}");
            Console.WriteLine($"CUIT: {cuit}");
            Console.WriteLine("----");
        }

    }
}
