using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Producto
{
    public string Nombre { get; set; }
    public double PrecioBase { get; set; }

    public Producto(string nombre, double precioBase)
    {
        Nombre = nombre;
        PrecioBase = precioBase;
    }

    public virtual double CalcularPrecioFinal()
    {
        return PrecioBase;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio Base: {PrecioBase:C}");
    }
}