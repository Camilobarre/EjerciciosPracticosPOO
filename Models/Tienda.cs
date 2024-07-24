using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Tienda
{
    public List<Prenda> Prendas { get; set; }
    public Tienda()
    {
        Prendas = new List<Prenda>();
    }
    public void AgregarPrenda(Prenda prenda)
    {
        Prendas.Add(prenda);
    }

    public Prenda BuscarPrendaPorNombre(string nombre)
    {
        foreach (var prenda in Prendas)
        {
            if (prenda.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                return prenda;
            }
        }
        return null;
    }
    public void MostrarPrendas()
    {
        foreach (var prenda in Prendas)
        {
            Console.WriteLine("Prenda: " + prenda.Nombre + " Talla: " + prenda.Talla + " Precio: " + prenda.Precio);
        }
    }
}