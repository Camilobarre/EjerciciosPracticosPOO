using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Administrativo : Personal
{
    private const double Bonificacion = 300;

    public Administrativo(string nombre, double salarioBase) : base(nombre, salarioBase)
    {
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonificacion;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Administrativo: {Nombre}, Salario Base: {SalarioBase:C}, Salario Final: {CalcularSalario():C}");
    }
}