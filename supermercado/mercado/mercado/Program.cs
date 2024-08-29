using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Producto
{
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    public int Stock { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, string codigo, int stock, decimal precio)
    {
        Nombre = nombre;
        Codigo = codigo;
        Stock = stock;
        Precio = precio;
    }

    public void ActualiuzarStock(int cantidad)
    {
        Stock = cantidad;
    }
}

class OrdenCompra
{
    private List<Producto> _productos;

    public OrdenCompra()
    {
        _productos = new List<Producto>();
    }
    public void AgregarProducto(Producto producto)
    {
        _productos.Add(producto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach(var producto in _productos)
        {
            total += producto.Precio;
        }
        return total;
    }

    public void MostrarDetalleOrden ()
    {
        Console.WriteLine("Detalle de la factura");
        foreach(var producto in _productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}\n" +
                $"Precio: {producto.Precio:C}\n");
        }
        Console.WriteLine($"Total de la compre: {CalcularTotal():C}");
    }
}

class Program
{
    static void Main()
    {
        Producto manzana = new Producto("Manzana", "102A",150,155);

        OrdenCompra ordenCompra = new OrdenCompra();
        ordenCompra.AgregarProducto(manzana);

        ordenCompra.MostrarDetalleOrden();
    }
}
