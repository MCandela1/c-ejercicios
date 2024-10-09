using BibliotecaUTN.Dominio.Dominio;

namespace BibliotecaUTN
{
    public class FactoryObjects
    {
        /**
         * 
         * Este metodo permite obtener una lista de objetos de tipo Alumno
         * 
         */
        public static List<Alumno> GenerarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("Manuel", "Fernandez", "43003986", "12980"));
            alumnos.Add(new Alumno("Javiera", "Gonzalez", "41055391", "12981"));
            alumnos.Add(new Alumno("Veronica", "Zarate", "29703786", "12982"));
            return alumnos;
        }

        public static List<Prestamo> GenerarPrestamos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            prestamos.Add(new Prestamo(GenerarAlumnos().First(), GenerarCopias().First(), DateTime.Today.AddDays(-20)));
            return prestamos;
        }


        /**
         * 
         * Estos son los libros que existen actualmente 
         * 
         */
        public static List<Libro> GenerarLibros()
        {
            List<Libro> libros = new List<Libro> {
              new Libro("Clean Code: A Handbook of Agile Software Craftsmanship", "0132350882", "Robert C. Martin", "Este libro es una guía definitiva para escribir código limpio, mantenible y eficiente. Indispensable para todo programador que busque la excelencia en su trabajo.", 3),
              new Libro("The Pragmatic Programmer: From Journeyman to Master", "9780201616224", "Hunt Andrew, Thomas David", "Este libro es una guía para el desarrollo de software que enfatiza un enfoque pragmático, flexible y adaptable. Indispensable para cualquier programador que busque mejorar su productividad y calidad de su trabajo.",5),
              new Libro("Head First Design Patterns: A Brain-Friendly Guide", "9781449331498", "Eric Freeman", "Este libro hace que el aprendizaje de patrones de diseño sea divertido y comprensible, utilizando un enfoque visual y conversacional. Esencial para cualquier programador que busque dominar los patrones de diseño.", 5),
              new Libro("Refactoring: Improving the Design of Existing Code", "9780134757599", "Martin Fowler", "Este libro es una guía definitiva para mejorar el diseño y la estructura de tu código existente. Un recurso indispensable para cualquier desarrollador que quiera mejorar su código y hacerlo más eficiente.", 5),
              new Libro("Clean Architecture: A Craftsman’s Guide to Software Structure and Design", "9780134494166", "Robert C. Martin", "Este libro aboga por el diseño de software enfocado a minimizar la dependencia y maximizar la flexibilidad, con numerosos ejemplos y estudios de casos. Una guía indispensable para crear software de calidad.",8),
              new Libro("Code Complete: A Practical Handbook of Software Construction", "1556154844", "Steve McConnell ", "Este libro es una recopilación exhaustiva de las mejores prácticas de la programación, abordando todos los aspectos del desarrollo de software. Esencial para cualquier desarrollador que busque mejorar sus habilidades.", 9),
              new Libro("Ingeniería del Software", "9786071503145", "Roger Pressman", "Una guía completa y definitiva sobre la ingeniería del software, cubriendo todos los aspectos del proceso de desarrollo. Este libro es un recurso valioso para cualquier profesional del software.", 4),
             };
            return libros;
        }

        /**
         * 
         * Estas son las copias existentes por cada libro, necesariamente por cada libro deberia existir una copia o de lo contrario no existe el libro
         * 
         */
        public static List<Copia> GenerarCopias()
        {
            List<Copia> copias = new List<Copia>();
            foreach (var libro in GenerarLibros())
            {
                copias.AddRange(libro.Copias); // asumo que cada libro ya inicializa sus propias copias en su constructor
            }
            return copias;
        }

    }
}
