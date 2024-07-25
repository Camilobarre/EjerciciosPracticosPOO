using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Autobus : Transporte
{
    public override void IniciarViaje()
    {
        Console.WriteLine("El viaje en autobús ha comenzado.");
    }

    public override void DetenerViaje()
    {
        Console.WriteLine("El viaje en autobús ha terminado.");
    }

    public override string ObtenerDetallesViaje()
    {
        return "Detalles del viaje: Este es un autobús.";
    }
}