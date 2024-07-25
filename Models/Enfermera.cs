using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Enfermera : Personal
{
    private const double Bonificacion = 500;

    public Enfermera(string nombre, double salarioBase) : base(nombre, salarioBase)
    {
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonificacion;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Enfermera: {Nombre}, Salario Base: {SalarioBase:C}, Salario Final: {CalcularSalario():C}");
    }
}