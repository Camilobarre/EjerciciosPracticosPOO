using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Empresa
{
    public List<Empleado> Empleados { get; set; }
    public Empresa()
    {
        Empleados = new List<Empleado>();
    }
    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
    }
    public Empleado BuscarEmpleadoPorNombre(string nombre)
    {
        foreach (var empleado in Empleados)
        {
            if (empleado.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                return empleado;
            }
        }
        return null;
    }
    public void MostrarEmpleados()
    {
        foreach (var empleado in Empleados)
        {
            Console.WriteLine("Nombre: " + empleado.Nombre + " Cargo: " + empleado.Cargo + " Salario: " + empleado.Salario);
        }
    }
}
