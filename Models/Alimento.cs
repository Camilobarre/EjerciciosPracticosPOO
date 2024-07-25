using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Alimento : Producto
{
    private const double Impuesto = 0.05;

    public Alimento(string nombre, double precioBase) : base(nombre, precioBase)
    {
    }

    public override double CalcularPrecioFinal()
    {
        return PrecioBase * (1 + Impuesto);
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Alimento: {Nombre}, Precio Base: {PrecioBase:C}, Precio Final: {CalcularPrecioFinal():C}");
    }
}