using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUTN.Dominio.Dominio
{
    public class Prestamo : Identificable
    {
        public Alumno Alumno { get; private set; }
        public Copia Copia { get; private set; }
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucion;
        private bool _devuelto;

        public Prestamo(Alumno alumno, Copia copia, DateTime fechaPrestamo)
        {
            if (copia.EstaDisponible())
            {
                Alumno = alumno;
                Copia = copia;
                _fechaPrestamo = fechaPrestamo;
                _fechaDevolucion = CalcularFechaDevolucion(fechaPrestamo, Constants.DIAS_PRESTAMO);
                copia.MarcarComoPrestada(); //marco la copia como prestada
                alumno.AgregarPrestamo(this);
                _devuelto = false;
            }
            else
            {
                throw new InvalidOperationException(" La copia no se encuentra disponible para realizar un préstamo.");
            }
        }

        public DateTime CalcularFechaDevolucion(DateTime fechaDesde, int dias)
        {
            return fechaDesde.AddDays(dias);
        }

        public bool EsDevuelto()
        {
            return _devuelto;
        }

        public void RegistrarDevolucion()
        {
            _devuelto = true;
            Copia.MarcarComoDisponible(); // marco la copia como disponible
        }
    }
}
