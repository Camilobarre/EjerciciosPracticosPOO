using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Moto : Vehiculo
{
    public override bool Arrancar()
    {
        Console.WriteLine("La moto arranca...");
        return base.Arrancar();
    }
}