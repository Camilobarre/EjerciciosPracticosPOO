using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Gerente : Empleado2
{
    public override void Trabajar()
    {
        base.Trabajar();
        // Console.WriteLine("El gerente está gestionando el equipo.");
    }
}