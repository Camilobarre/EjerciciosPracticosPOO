using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Electronico : Producto
{
    private const double Impuesto = 0.15;

    public Electronico(string nombre, double precioBase) : base(nombre, precioBase)
    {
    }

    public override double CalcularPrecioFinal()
    {
        return PrecioBase * (1 + Impuesto);
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Electrónico: {Nombre}, Precio Base: {PrecioBase:C}, Precio Final: {CalcularPrecioFinal():C}");
    }
}
