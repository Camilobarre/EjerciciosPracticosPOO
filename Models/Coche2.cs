using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Coche2 : Transporte
{
    public override void IniciarViaje()
    {
        Console.WriteLine("El viaje en coche ha comenzado.");
    }

    public override void DetenerViaje()
    {
        Console.WriteLine("El viaje en coche ha terminado.");
    }

    public override string ObtenerDetallesViaje()
    {
        return "Detalles del viaje: Este es un coche.";
    }
}