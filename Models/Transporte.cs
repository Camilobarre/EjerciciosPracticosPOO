using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Transporte
{
    public virtual void IniciarViaje()
    {
        Console.WriteLine("El viaje ha comenzado.");
    }

    public virtual void DetenerViaje()
    {
        Console.WriteLine("El viaje ha terminado.");
    }

    public virtual string ObtenerDetallesViaje()
    {
        return "Detalles del viaje: Transporte genérico.";
    }
}
