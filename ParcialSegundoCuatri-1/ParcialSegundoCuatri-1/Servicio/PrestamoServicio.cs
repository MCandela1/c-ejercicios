using BibliotecaUTN.Dominio.Dominio;

namespace BibliotecaUTN.Servicios
{
    public class PrestamoServicio
    {
        private static List<Prestamo> _prestamoExistentes = new List<Prestamo>();

        internal static bool Actualizar(Prestamo prestamo)
        {
            var prestamoExistente = _prestamoExistentes.FirstOrDefault(p => p.Id == prestamo.Id);
            if (prestamoExistente != null)
            {
                prestamoExistente.RegistrarDevolucion();
                Console.WriteLine("Devolución registrada correctamente.");
                return true;
            }
            else
            {
                Console.WriteLine("No existe tal devolución.");
                return false;

            }
        }

        internal static bool Crear(Prestamo prestamo)
        {
            if (_prestamoExistentes.Any(p => p.Id == prestamo.Id))
            {
                Console.WriteLine("Ya existe tal prestamo.");
                return false;

            }
            _prestamoExistentes.Add(prestamo);
            Console.WriteLine($"Préstamo registrado: {prestamo.Alumno.Nombre} - {prestamo.Copia.Libro.Titulo}");
            return true;
        }

        internal static void Listar()
        {
            var deudores = _prestamoExistentes.Where(p => !p.EsDevuelto())
                                                .Select(p => p.Alumno)
                                                .Distinct()
                                                .ToList();
            Console.WriteLine("Todos los alumnos con deuda atrasada");
            foreach (var alumno in deudores)
            {
                Console.WriteLine($"- {alumno.Nombre} {alumno.Apellido} (Legajo: {alumno.Legajo})");
            }
        }
    }
}
