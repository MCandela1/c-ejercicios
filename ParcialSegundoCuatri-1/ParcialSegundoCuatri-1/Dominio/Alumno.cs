using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUTN.Dominio.Dominio
{
    public class Alumno : Identificable
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _legajo;
        private bool _deuda;
        public List<Prestamo> _prestamos;

        public Alumno(String nombre, String apellido, String dni, String legajo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _legajo = legajo;
            _deuda = false; // porque se incia sin deudas
            _prestamos = new List<Prestamo>();
        }
        public string Legajo => _legajo;

        public string Nombre => _nombre;
        public string Apellido => _apellido;

        public void AgregarPrestamo(Prestamo prestamo)
        {
            _prestamos.Add(prestamo);
            ActualizarEstadoDeuda();
        }

        private void ActualizarEstadoDeuda()
        {
            _deuda = _prestamos.Any(p => !p.EsDevuelto()); //verifico si hay prestamos que no han sido devueltos
        }

        public void RegistrarDevolucion(Prestamo prestamo)
        {
            if (_prestamos.Remove(prestamo))
            {
                ActualizarEstadoDeuda();
            }
        }
    }

}
