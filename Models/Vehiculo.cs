using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Vehiculo
{
    public virtual bool Arrancar()
    {
        Console.WriteLine("El vehículo está arrancando.");
        return true;
    }
}