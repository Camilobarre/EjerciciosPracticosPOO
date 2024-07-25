using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Rectangulo : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalcularArea()
    {
        return Ancho * Alto;
    }
}