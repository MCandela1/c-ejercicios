using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPOO6_22_04_25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empresa miEmpresa = new Empresa("Soluciones Integrales SRL", "30-12345678-9");
            miEmpresa.MostrarDatosEmpresa();

            Empleado emp1 = new Empleado("Juan", "Pérez", "20-12345678-3", new DateTime(1990, 5, 15));
            Empleado emp2 = new Empleado("María", "Gómez", "27-87654321-8", new DateTime(1985, 12, 2));
            Empleado emp3 = new Empleado("Micaela","Rossi","22-41782365-5",new DateTime(1999, 4, 18));
            Empleado emp4 = new Empleado("Facundo","Flores","27-40256148-1", new DateTime(1998, 3, 23));
            Empleado emp5 = new Empleado("Milo","Caseres","22-42369451-5", new DateTime(2000, 6, 23));
           
            miEmpresa.ContratarEmpleado(emp1);
            miEmpresa.ContratarEmpleado(emp2);
            miEmpresa.ContratarEmpleado(emp3);
            miEmpresa.ContratarEmpleado(emp4);
            miEmpresa.ContratarEmpleado(emp5);

            miEmpresa.MostrarEmpleados();

            Console.ReadKey();
        }
    }
}
