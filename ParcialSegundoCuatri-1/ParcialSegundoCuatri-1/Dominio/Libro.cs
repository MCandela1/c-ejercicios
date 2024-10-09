using System.Collections.Generic;
using System.Linq;

namespace BibliotecaUTN.Dominio.Dominio
{
    public class Libro : Identificable
    {
        private string _isbn;
        private string _titulo;
           public string Autor { get; set; }
        public string Descripcion { get; set; }
        public int CantidadCopias { get; set; }
        private List<Copia> _copias;

        public Libro(string titulo, string isbn, string autor, string descripcion, int cantidadCopias) : base()
        {
            _titulo = titulo;
            _isbn = isbn;
            _copias = new List<Copia>();

            InicializarCopias(cantidadCopias);
        }

        public string ISBN => _isbn;
        public string Titulo => _titulo;

        public List<Copia> Copias => _copias; 
        public void AgregarCopia(Copia copia)
        {
            _copias.Add(copia);
        }
        private void InicializarCopias(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Copia nuevaCopia = new Copia(this);
                _copias.Add(nuevaCopia);
            }
        }

        public Copia ObtenerCopiaDisponible() 
        {
            return _copias.FirstOrDefault(c => c.EstaDisponible());
        }
    }
}


