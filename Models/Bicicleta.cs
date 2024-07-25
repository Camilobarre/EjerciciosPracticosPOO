using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Bicicleta : Transporte
{
    public override void IniciarViaje()
    {
        Console.WriteLine("El viaje en bicicleta ha comenzado.");
    }

    public override void DetenerViaje()
    {
        Console.WriteLine("El viaje en bicicleta ha terminado.");
    }

    public override string ObtenerDetallesViaje()
    {
        return "Detalles del viaje: Esta es una bicicleta.";
    }
}
