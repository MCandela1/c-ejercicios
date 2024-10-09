using BibliotecaUTN.Dominio.Dominio;

namespace BibliotecaUTN.Servicios
{
    internal class LibroServicio
    {
        private static List<Libro> _librosExistentes = new List<Libro>();

        internal static bool Crear(Libro libro)
        {
            if (_librosExistentes.Any(l => l.ISBN == libro.ISBN))
            {
                Console.WriteLine("El libro ya existe en el sistema.");
                return false;
            }
            _librosExistentes.Add(libro);

            Console.WriteLine($"Libro registrado: {libro.Titulo} (ISBN: {libro.ISBN})");
            return true;
        }
        public static List<Libro> ObtenerLibros()
        {
            return _librosExistentes;
        }
    }
}
