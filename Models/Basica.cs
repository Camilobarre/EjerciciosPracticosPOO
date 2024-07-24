using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPracticosPOO.Models;
public class Basica
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public byte Edad { get; set; }

    //Creamos un constructor
    public Basica(string nombre, byte edad)
    {
        this.Id= new Guid();
        this.Nombre = nombre;
        this.Edad = edad;
    }

    //Creamos un método
    public void Saludar(){
        Console.WriteLine($"Hola {Nombre}, tienes {Edad} años.");
    }
}