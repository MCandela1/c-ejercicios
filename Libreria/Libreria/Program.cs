class Publicacion
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public Publicacion (string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($" Titulo: {Titulo} , Autor: {Autor}");
    }
}

class Libro : Publicacion
{
    public string Genero { get; set; }

    public int NumPag { get; set; }

    public Libro(string titulo, string autor, string genero, int numPag) : base( titulo, autor)
    {
        Genero = genero;
        NumPag = numPag;
    }
    public void MostrarInformacionLibro()
    {
        MostrarInformacion();
        Console.WriteLine($"Genero: {Genero}, Numero de pagina{NumPag}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el titulo del libro: ");
        string Titulo = Console.ReadLine();

        Console.WriteLine("Ingrese el autor del libro: ");
        string Autor = Console.ReadLine();

        Console.WriteLine("Ingrese el genero del libro: ");
        string Genero = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de paginas del libro: ");
        int NumPag = int.Parse(Console.ReadLine());

        Libro unLibro = new Libro (Titulo, Autor, Genero, NumPag);
        unLibro.MostrarInformacionLibro();
        Console.ReadLine();

    }
}
