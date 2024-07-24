using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Escuela
{
    public List<Curso> Cursos { get; set; }
    public Escuela()
    {
        Cursos = new List<Curso>();
    }
    public void AgregarCurso(Curso curso)
    {
        Cursos.Add(curso);
    }
        public Curso BuscarCursoPorNombre(string nombre)
    {
        foreach (var curso in Cursos)
        {
            if (curso.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                return curso;
            }
        }
        return null;
    }
    public void MostrarCursos()
    {
        foreach (var curso in Cursos)
        {
            Console.WriteLine("Nombre: " + curso.Nombre + " Codigo: " + curso.Codigo + " Duracion: " + curso.Duracion);
        }
    }
}