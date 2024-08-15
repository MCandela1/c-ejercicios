public class Empleado
{
    private string nombre;
    private decimal salario;

    protected decimal Salario
    {
        get
        {
            return salario;
        }
        set
        {
            salario = value;
        }
    }
    public Empleado(string nombreEmpleado, decimal salario)
    {
        nombre = nombreEmpleado;
        Salario = salario;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nomre:  {nombre}, Salario{salario:C}");//C --> el número en este caso el valor del salario se formatea como una moneda
    }
}
public class Gerente : Empleado
{
    private string departamento;
    public Gerente(string nombreEmpleado, decimal salario, string departamentoGerente) : base (nombreEmpleado, salario)
    {
        departamento = departamentoGerente;
    }
    public void MostrarInformacionGerente()
    {
        MostrarInformacion();
        Console.WriteLine($"Departamento: {departamento}");
    }
}

class Program
{
    static void Main()
    {
        Empleado unEmpleado = new Empleado("Nicolás Re", 560000);
        unEmpleado.MostrarInformacion();

        Gerente unGerente = new Gerente("Raúl López", 890000, "Logística");
        unGerente.MostrarInformacionGerente();
    }
}