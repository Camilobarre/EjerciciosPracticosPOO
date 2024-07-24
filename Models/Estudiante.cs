using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Estudiante
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public string? Matricula { get; set; }
    public Estudiante(string nombre, int edad, string matricula)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Matricula = matricula;
    }
    public static void MostrarEstudiantes(List<Estudiante> estudiantes)
    {
        Console.WriteLine("Estudiantes:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Hola {estudiante.Nombre}, tienes {estudiante.Edad} años y tienes matricula {estudiante.Matricula}");
        }
    }
}