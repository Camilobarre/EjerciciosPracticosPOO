using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public abstract class Personal
{
    public string Nombre { get; set; }
    public double SalarioBase { get; set; }

    protected Personal(string nombre, double salarioBase)
    {
        Nombre = nombre;
        SalarioBase = salarioBase;
    }

    public abstract double CalcularSalario();

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario Base: {SalarioBase:C}");
    }
}