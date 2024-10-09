using BibliotecaUTN.Servicios;
using BibliotecaUTN.Dominio.Dominio;
using System.Linq;
using System;

namespace BibliotecaUTN
{
    public class Program
    {

        static List<Alumno> alumnos = new List<Alumno>();
        static List<Copia> copias = new List<Copia>();
        static List<Prestamo> prestamos = new List<Prestamo>();
        private static List<Libro> libros;

        /**
         * Esta es la funcion principal, contiene la logica para mostrar el menu y luego enviar a cada implementacion lo que se haya requerido.
         * Las opciones posibles para la ejercitacion es Crear el archivo plano, Agregar un nuevo valor y Listar todos los valores existentes. 
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int selectedIndex = 0;
            bool salir = false;
            Console.CursorVisible = false;

            alumnos = FactoryObjects.GenerarAlumnos();
            copias = FactoryObjects.GenerarCopias();
            prestamos = FactoryObjects.GenerarPrestamos();


            while (!salir)
            {
                Console.Clear();
                Console.ResetColor();

                Logo.Show();

                Console.WriteLine();
                Console.WriteLine("Seleccione una opción con las flechas {0} o {1}", (char)24, (char)25);
                Console.WriteLine("-----------------------------------------------------");

                for (int i = 0; i < Constants.menuOptions.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write((char)2 + " ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write("  ");
                    }

                    Console.WriteLine(Constants.menuOptions[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(Constants.menuOptions.Length - 1, selectedIndex + 1);
                        break;

                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                        if (selectedIndex == Constants.menuOptions.Length - 1)
                            salir = true;

                        else
                            HandleMenuOption(Constants.menuOptions[selectedIndex]);
                        break;
                }
            }
        }

        /**
         * Este metodo esta encargado de recibir la opcion de menu deseada por el usuario 
         * Por cada opcion del menu, ejecutaremos Crear, Agregar o Listar según se haya solicitado dicha acción.
         * Las opciones que arroja excepciones en tiempo de ejecucion, deben ser controladas para que el usuario resuelva dicho caso.
         */
        public static void MenuAsync(string userInput)
        {
            switch (userInput)
            {
                case "Ingresar nuevo alumno":
                    Console.WriteLine("Ingresar los datos del alumno:");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("DNI: ");
                    string dni = Console.ReadLine();
                    Console.Write("Legajo: ");
                    string legajo = Console.ReadLine();

                    var nuevoAlumno = new Alumno(nombre, apellido, dni, legajo);
                    bool alumnoCreado = AlumnoServicio.Crear(nuevoAlumno);

                    Console.WriteLine(alumnoCreado ? "Alumno registrado correctamente" : "El alumno ya existe.");
                    Console.ReadKey();
                    break;

                case "Alquilar libros":
                    Console.WriteLine("Ingresar legajo del alumno:");
                    string legajoAlquiler = Console.ReadLine();

                    Alumno alumnoAlquiler = AlumnoServicio.ObtenerAlumnos().FirstOrDefault(a => a.Legajo == legajoAlquiler);

                    if (alumnoAlquiler == null)
                    {
                        Console.WriteLine("Alumno no encontrado.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Libros disponibles:");
                   // foreach (var libro in libros)
                   // {
                   //     Console.WriteLine($"Título: {libro.Titulo}, ISBN: {libro.ISBN}");
                    //}
                   
                    MostrarLibros(); //  llamo al método que muestra los libros


                    Console.WriteLine("Seleccione un libro (Ingrese el ISBN):");
                    string isbSeleccionado = Console.ReadLine();

                    var libroSeleccionado = LibroServicio.ObtenerLibros().FirstOrDefault(l => l.ISBN == isbSeleccionado.Trim());

                    if (libroSeleccionado != null)
                    {
                        var copiaDisponible = libroSeleccionado.ObtenerCopiaDisponible();
                        if (copiaDisponible != null)
                        {
                            var exitoAlquiler = PrestamoServicio.Crear(new Prestamo(alumnoAlquiler, copiaDisponible, DateTime.Now));
                            Console.WriteLine(exitoAlquiler ? "Préstamo registrado." : "No se pudo registrar el préstamo.");
                           // copiaDisponible.MarcarComoPrestada(); // Marco la copia como prestada
                        }
                        else
                        {
                            Console.WriteLine("No hay copias disponibles de ese libro.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Libro no encontrado.");
                    }
                    Console.ReadKey();
                    break;


                case "Registrar devolución de libros":
                    Console.WriteLine("Ingresar el legajo del alumno:");
                    string legajoDevolucion = Console.ReadLine();
                    Alumno alumnoDevolucion = alumnos.FirstOrDefault(a => a.Legajo == legajoDevolucion);
                    if (alumnoDevolucion == null)
                    {
                        Console.WriteLine("Alumno no encontrado.");
                        Console.ReadKey();
                        break;
                    }

                    Console.WriteLine("Ingresar el ISBN del libro a devolver:");
                    string isbDevolucion = Console.ReadLine();

                    var prestamoDevolucion = prestamos.FirstOrDefault(p => p.Copia.Libro.ISBN == isbDevolucion && p.Alumno == alumnoDevolucion && !p.EsDevuelto());

                    if (prestamoDevolucion != null)
                    {
                        prestamoDevolucion.RegistrarDevolucion();
                        alumnoDevolucion.RegistrarDevolucion(prestamoDevolucion);
                        Console.WriteLine("Devolución registrada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un préstamo activo para el libro especificado.");
                    }
                    Console.ReadKey();
                    break;

                case "Informar alumnos con deudas retrasadas":

                    PrestamoServicio.Listar();
                    Console.ReadKey();
                    break;

                case "Agregar nuevo libro":
                    if (!AlumnoServicio.ObtenerAlumnos().Any())
                    {
                        Console.WriteLine("No hay alumnos registrado. Registrar al alumno primero.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Ingresar los datos del nuevo libro:");
                    Console.Write("Titulo: ");
                    string titulo = Console.ReadLine();
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine().Trim();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Descripción: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Cantidad de copias: ");
                    int cantidadCopias;

                    while (!int.TryParse(Console.ReadLine(), out cantidadCopias))
                    {
                        Console.WriteLine("Por favor, ingrese un número válido para la cantidad de copias:");
                    }

                    var nuevoLibro = new Libro(titulo, isbn, autor, descripcion, cantidadCopias);

                    bool libroCreado = LibroServicio.Crear(nuevoLibro);
                    Console.WriteLine(libroCreado ? "Libro registrado correctamente." : "El libro ya existe.");
                    Console.WriteLine("Libros registrados actualmente:");
                    foreach (var libro in LibroServicio.ObtenerLibros())
                    {
                        Console.WriteLine($"- {libro.Titulo} (ISBN: {libro.ISBN})");
                    }
                    Console.ReadKey();
                    break;

            }
        }
        public static void MostrarLibros()
        {
            foreach (var libro in LibroServicio.ObtenerLibros()) // que andeeeeeeeee
            {
                Console.WriteLine($"Título: {libro.Titulo}, ISBN: {libro.ISBN}");
            }
        }
        /**
         * Este metodo se encarga de obtener la opcion y mostrar cual fue la opcion de menu deseada.  
         * Luego llamaremos al método Menú quien contiene las acciones que llaman a las implementaciones. 
         */
        static void HandleMenuOption(string option)
        {
            // Aquí puedes implementar la lógica para manejar cada opción del menú
            Console.Clear();
            Console.WriteLine($"Seleccionaste: {option}");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            MenuAsync(option);
        }

    }
}