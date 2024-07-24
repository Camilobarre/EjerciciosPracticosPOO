using EjerciciosPracticosPOO.Models;

Console.Clear();

var miPrimerObjeto = new Basica("Camilo Barreneche", 28);
miPrimerObjeto.Saludar();

var Estudiantes = new List<Estudiante>();
var miPrimerEstudiante= new Estudiante("Camilo",28,"Inactivo");
var miSegundoEstudiante = new Estudiante("Juan",25,"Activo");
Estudiantes.Add(miPrimerEstudiante); 
Estudiantes.Add(miSegundoEstudiante); 
Estudiante.MostrarEstudiantes(Estudiantes);

var miPrimerHabitacion = new Habitacion("Doble");
var miSegundaHabitacion = new Habitacion("Familiar");
var miPrimerReserva = new Reserva(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(1)), miPrimerHabitacion);
var miSegundaReserva = new Reserva(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), DateOnly.FromDateTime(DateTime.Now.AddDays(3)), miSegundaHabitacion);
miPrimerReserva.MostrarHabitacion();
miSegundaReserva.MostrarHabitacion();