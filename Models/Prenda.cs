using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Prenda
{
    public string? Nombre { get; set; }
    public string? Talla { get; set; }
    public double Precio { get; set; }

    public Prenda(string nombre, string talla, double precio)
    {
        this.Nombre = nombre;
        this.Talla = talla;
        this.Precio = precio;
    }
}