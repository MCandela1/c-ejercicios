class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string TipoDeMotor { get; set; }
    public int Potencia { get; set; }
    public string Transmision { get; set; }

    public Vehiculo(string marca, string modelo, string tipoDeMotor, int potencia, string transmision)
    {
        Marca = marca;
        Modelo = modelo;
        TipoDeMotor = tipoDeMotor;
        Potencia = potencia;
        Transmision = transmision;
    }  

    protected void MostrarDetalle()
    {
        Console.WriteLine($"Marca: {Marca},Modelo: {Modelo}");
        Console.WriteLine($"Tipo de Motor: {TipoDeMotor}");
        Console.WriteLine($"Potencia: {Potencia} HP");
        Console.WriteLine($"Transmisión: {Transmision}");
    }
}

class Auto : Vehiculo
{
    public int NumeroDePuertas { get; set; }
    public int AñoDeFabricacion { get; set; }
    public string Color { get; set; }
    public int VelocidadMaxima { get; set; }
    public double ConsumoCombustible { get; set; }
    public string TipoDeNehumaticos{ get; set; }
    public bool TieneSistemaDeNavegacion { get; set; }

    public Auto(string marca, string modelo, string tipoDeMotor, int potencia, int v, string transmision,int numeroDePuertas, int añoDeFabricacion, string color, int velocidadMaxima, double consumoCombustible, string tipoDeNehumaticos, bool tieneSistemaDeNavegacion) : base (marca, modelo, tipoDeMotor, potencia, transmision)
    {
        NumeroDePuertas = numeroDePuertas;
        AñoDeFabricacion = añoDeFabricacion;
        Color = color;
        VelocidadMaxima = velocidadMaxima;
        ConsumoCombustible = consumoCombustible;
        TipoDeNehumaticos = tipoDeNehumaticos;
        TieneSistemaDeNavegacion = tieneSistemaDeNavegacion;
    }

    public void MostrarDetalleAuto()
    {
        MostrarDetalle();
        Console.WriteLine($"Numero de puertas: {NumeroDePuertas}");
        Console.WriteLine($"Año de fabricación: {AñoDeFabricacion}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Velocidad máxima: {VelocidadMaxima} km/h");
        Console.WriteLine($"Consumo de combustible: {ConsumoCombustible} l/100 km");
        Console.WriteLine($"Tipo de nehumáticos: {TipoDeNehumaticos}");
        Console.WriteLine($"Sistema de navegación:  {(TieneSistemaDeNavegacion ? "Sí" : "No")}");
    }
}

class Program
{
    static void Main()
    {
        Auto miAuto = new Auto("Ferrari", "F2004", "Ferrari 053 3.0 V10", 730, 1000, "Semi-Automático", 0, 2004, "Rojo y blanco", 400, 85, "Bridgestone", true);
        miAuto.MostrarDetalleAuto();
    }
}