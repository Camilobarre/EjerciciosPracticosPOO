using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Coche : Vehiculo
{
    public override bool Arrancar()
    {
        Console.WriteLine("El coche arranca...");
        return base.Arrancar();
    }
}