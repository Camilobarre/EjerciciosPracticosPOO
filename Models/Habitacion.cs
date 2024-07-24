using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Habitacion
{
    public Guid Id { get; set; }
    public string? Tipo { get; set; }
    public Habitacion(string tipo)
    {
        this.Id = new Guid();
        this.Tipo = tipo;
    }
}