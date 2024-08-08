class Estudiante
{
    private string _nombre;
    private int _legajo;
    private double _promedio;
    
    public Estudiante(string nombre, int legajo, double promedio)
    {
        _nombre = nombre;
        _legajo = legajo;
        _promedio = promedio;
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

    public double Promedio
    {
        get { return _promedio; }
        set { _promedio = value; }
    }

    public void Actualizacion(double promedioActualizado)
    {
        if (promedioActualizado >= 0 && promedioActualizado <= 10)
        {
            Promedio += promedioActualizado;
            Console.WriteLine($"El promedio se actualizó. \nEl nuevo promedio es: {Promedio}");
        }
        else
        {
            Console.WriteLine($"El promedio debe ser entre 0 y 10.");
        }
    }
}

class Program
{
    static void Main()
    {
        Estudiante unEstudiante = new Estudiante("Catalina Gómez", 14852, 5.0);
        unEstudiante.Actualizacion(8.5);

        Console.WriteLine($"Nombre del estudiante: {unEstudiante.Nombre}");
        Console.WriteLine($"Legajo del estudiante: {unEstudiante.Legajo}");
        Console.WriteLine($"Promedio del estudiante: {unEstudiante.Promedio}");

    }
}