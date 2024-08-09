class Animal
{
    public string Nombre { get; set; }
    protected int Edad {  get; set; }
    private string _tipo;

    public Animal (string nombre, int edad, string tipo)
    {
        Nombre = nombre;
        Edad = edad;
        _tipo = tipo;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Datos: {this.Nombre}\n{this.Edad}\n{this._tipo}");


    }

}

class Perro : Animal 
{
    public string Raza { get; set; }
    public Perro(string nombre, int edad, string tipo, string raza) : base (nombre, edad, tipo)
    {
        Raza = raza;

    }

    public void MostrarInfoPerro()
    {
        Console.WriteLine(Nombre);
    }

}

class Program
{

    static void Main()
    {
        Animal perro = new Perro("pipi", 45, "canino", "dálmata");
        perro.MostrarInformacion();

    }

}
