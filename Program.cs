using EjerciciosPracticosPOO.Models;

Console.Clear();

var miPrimerObjeto = new Basica("Camilo Barreneche", 28);
miPrimerObjeto.Saludar();

var miPrimerEstudiante= new Estudiante("Camilo",28,"Inactivo");
var miSegundoEstudiante = new Estudiante("Juan",25,"Activo");
miPrimerEstudiante.AgregarEstudiante(miPrimerEstudiante);
miSegundoEstudiante.AgregarEstudiante(miSegundoEstudiante);
Estudiante.MostrarEstudiantes();

var miPrimerHabitacion = new Habitacion("Doble");
var miSegundaHabitacion = new Habitacion("Familiar");

var miPrimerReserva = new Reserva(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(1)), miPrimerHabitacion);
var miSegundaReserva = new Reserva(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), DateOnly.FromDateTime(DateTime.Now.AddDays(3)), miSegundaHabitacion);

miPrimerReserva.MostrarHabitacion();
miSegundaReserva.MostrarHabitacion();