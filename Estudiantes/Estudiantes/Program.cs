class Estudiante
{
    private string _nombre;
    private int _legajo;
    private double _notaFinal;
    private int _contador;
    public Estudiante(string nombre, int legajo)
    {
        _nombre = nombre;
        _legajo = legajo;
        _notaFinal = 0;
        _contador = 0;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int Legajo
    {
        get { return _legajo; }
        set { _legajo = value; }
    }

    

    public void AgregarNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            _notaFinal += nota;
            _contador++;
            Console.WriteLine($"La nota {nota} fue agregada. ");
        }
        else
        {
            Console.WriteLine($"La nota debe ser entre 0 y 10.");
        }
    }
    public double CalcularPromedio()
    {
        if (_contador == 0)
            return 0;
        return _notaFinal/_contador;
    }
    public void Promedio()
    {
        double promedio = CalcularPromedio();
        Console.WriteLine($"El promedio del estudiante es: {promedio:F2}");
    }
}

class Program
{
    static void Main()
    {
        Estudiante unEstudiante = new Estudiante("Catalina Gómez", 14852);
        unEstudiante.AgregarNota(8.5);
        unEstudiante.AgregarNota(4.2);
        unEstudiante.AgregarNota(6.6);

        unEstudiante.Promedio(); 

        Console.WriteLine($"Nombre del estudiante: {unEstudiante.Nombre}");
        Console.WriteLine($"Legajo del estudiante: {unEstudiante.Legajo}");

    }
}