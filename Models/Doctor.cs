using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Doctor : Personal
{
    private const double Bonificacion = 2000;

    public Doctor(string nombre, double salarioBase) : base(nombre, salarioBase)
    {
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonificacion;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Doctor: {Nombre}, Salario Base: {SalarioBase:C}, Salario Final: {CalcularSalario():C}");
    }
}