using EjerciciosPracticosPOO.Models;

Console.Clear();

var miPrimerObjeto = new Basica("Camilo Barreneche", 28);
miPrimerObjeto.Saludar();

var miPrimerEstudiante= new Estudiante("Camilo",28,"Inactivo");
var miSegundoEstudiante = new Estudiante("Juan",25,"Activo");
miPrimerEstudiante.AgregarEstudiante(miPrimerEstudiante);
miSegundoEstudiante.AgregarEstudiante(miSegundoEstudiante);
Estudiante.MostrarEstudiantes();