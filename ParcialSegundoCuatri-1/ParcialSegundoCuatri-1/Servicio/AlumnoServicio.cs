using BibliotecaUTN.Dominio.Dominio;


namespace BibliotecaUTN.Servicios
{
    public class AlumnoServicio
    {
        private static List<Alumno> _alumnoExistentes = new List<Alumno>();

        internal static bool Crear(Alumno alumno)
        {
            if (_alumnoExistentes.Any(a => a.Legajo == alumno.Legajo))
            {
                Console.WriteLine("Ya existe el alumno.");
                return false;
            }
            _alumnoExistentes.Add(alumno);
            Console.WriteLine($" Nuevo alumno registrado: {alumno.Legajo}- {alumno.Nombre} {alumno.Apellido}");
            return true;
        }
        public static List<Alumno> ObtenerAlumnos()
        {
            return _alumnoExistentes;
        }
    }
}
