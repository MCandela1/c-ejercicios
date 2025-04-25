using System;
using System.Collections.Generic;

public class Bateria
{
    public int mAh { get; set; }
    public string MarcaBateria { get; set; }

    public void MostrarDatos()
    {
        Console.WriteLine($"Batería: {mAh} mAh - Marca: {MarcaBateria}");
    }
}

public enum Empresa
{
    Claro,
    Personal,
    Movistar
}

public class Chip
{
    public Empresa Empresa { get; set; }

    public Chip(Empresa empresa)
    {
        Empresa = empresa;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Chip de empresa: {Empresa}");
    }
}

public class CelPhone
{
    public string Numero { get; set; }
    public Bateria Bateria { get; private set; }
    public List<Chip> Chips { get; private set; }
    public int nroChips => Chips.Count;

    public CelPhone(Bateria bateria)
    {
        if (bateria == null)
        {
            throw new ArgumentException("El celular debe tener una batería.");
        }

        Bateria = bateria;
        Chips = new List<Chip>();
    }

    public void AgregarChip(Chip chip)
    {
        if (nroChips < 3)
        {
            Chips.Add(chip);
        }
        else
        {
            Console.WriteLine("No se pueden agregar más de 3 chips.");
        }
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"Número: {Numero}");
        Bateria.MostrarDatos();
        Console.WriteLine($"Cantidad de Chips: {nroChips}");
        foreach (var chip in Chips)
        {
            chip.MostrarDatos();
        }
    }
}

public class SmartPhone : CelPhone
{
    public string Modelo { get; set; }
    public bool Wifi { get; set; }
    public int CantMPCamara { get; set; }

    public SmartPhone(Bateria bateria) : base(bateria) { }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Modelo: {Modelo} | Wifi: {(Wifi ? "Sí" : "No")} | Cámara: {CantMPCamara} MP");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bateria bateria = new Bateria { mAh = 4000, MarcaBateria = "Samsung" };
        SmartPhone sp = new SmartPhone(bateria)
        {
            Numero = "123456789",
            Modelo = "Galaxy S22",
            Wifi = true,
            CantMPCamara = 108
        };

        sp.AgregarChip(new Chip(Empresa.Claro));
        sp.AgregarChip(new Chip(Empresa.Movistar));

        sp.MostrarDatos();
    }
}