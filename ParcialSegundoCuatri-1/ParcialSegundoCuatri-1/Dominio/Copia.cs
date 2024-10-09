
namespace BibliotecaUTN.Dominio.Dominio
{
    public class Copia
    {
        private bool _disponible;
        private Libro _libro;

        public Copia(Libro libro)
        {
            _libro = libro;
            _disponible = true;
        }

        public bool EstaDisponible()
        {
            return _disponible;
        }

        public Libro Libro => _libro;

        public void MarcarComoPrestada()
        {
            _disponible = false;
        }

        public void MarcarComoDisponible()
        {
            _disponible = true;
        }
    }
}
