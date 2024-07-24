using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Reserva
{
    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }
    public Habitacion Habitacion { get; set; }

    public Reserva(DateOnly fechaInicio, DateOnly fechaFin, Habitacion habitacion)
    {
        this.FechaInicio = fechaInicio;
        this.FechaFin = fechaFin;
        this.Habitacion = habitacion;
    }
    public void MostrarHabitacion()
    {
        Console.WriteLine($"Fecha Inicio: {FechaInicio} - Fecha Fin: {FechaFin} Habitacion: {Habitacion.Id} - {Habitacion.Tipo}");
    }
}