public class Instrumento
{
    public string NombreInstrumento {  get; set; }
    public string TipoInstrumento { get; set; }

    public Instrumento (string nombreInstrumento, string tipoInstrumento)
    {
        NombreInstrumento = nombreInstrumento;
        TipoInstrumento = tipoInstrumento;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre del instrumento musical: {NombreInstrumento} \nTipo de instrumento: {TipoInstrumento}");
    }
}

public class InstrumentoViento : Instrumento
{
    public string Material {  get; set; }
    public InstrumentoViento(string nombreInstrumento, string tipoInstrumento, string material) : base (nombreInstrumento,tipoInstrumento)    {
      Material = material;
    }
    public void MostrarInformacionViento()
    {
        MostrarInformacion();
        Console.WriteLine($"Material del instrumento es: {Material}");
    }
}

public class InstrumentoCuerda : Instrumento
{

    public int Cuerda { get; set; }
    public InstrumentoCuerda(string nombreInstrumento, string tipoInstrumento, int cuerda) : base(nombreInstrumento, tipoInstrumento)    {
        Cuerda = cuerda;
    }
    public void MostrarInformacionCuerda()
    {
        MostrarInformacion();
        Console.WriteLine($"Cantidad de cuerdas que tiene es : {Cuerda}");
    }
}

public class InstrumentoPersecucion : Instrumento
{
    public string TipoAfinacion { get; set; }
    public InstrumentoPersecucion (string nombreInstrumento, string tipoInstrumento, string tipoAfinacion) : base(nombreInstrumento, tipoInstrumento)
    {
        TipoAfinacion = tipoAfinacion;
    }
    public void MostrarInformacionPersecucion()
    {
        MostrarInformacion();
        Console.WriteLine($"Tipo de afinidad: {TipoAfinacion}");
    }
}
class Program
{
    static void Main()
    {
        InstrumentoViento instrumentoDeViento = new InstrumentoViento("Saxofón", "Viento", "Latón");
        instrumentoDeViento.MostrarInformacionViento();

        InstrumentoCuerda instrumentoDeCuerda = new InstrumentoCuerda("Piano de cola", "Cuerda", 240);
        instrumentoDeCuerda.MostrarInformacionCuerda();

        InstrumentoPersecucion instrumentoDePersecucion = new InstrumentoPersecucion("Bateria acustica", "Persecución", "No afinado");
        instrumentoDePersecucion.MostrarInformacionPersecucion();
    }
}


