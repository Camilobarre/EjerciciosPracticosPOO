using EjerciciosPracticosPOO.Models;

Console.Clear();

var miPrimerObjeto = new Basica("Camilo Barreneche", 28);
miPrimerObjeto.Saludar();

//Estudiante y Mostrar Estudiantes
var Estudiantes = new List<Estudiante>();
var miPrimerEstudiante = new Estudiante("Camilo", 28, "Inactivo");
var miSegundoEstudiante = new Estudiante("Juan", 25, "Activo");
Estudiantes.Add(miPrimerEstudiante);
Estudiantes.Add(miSegundoEstudiante);
Estudiante.MostrarEstudiantes(Estudiantes);

//Habitacion y Reserva
var miPrimerHabitacion = new Habitacion("Doble");
var miSegundaHabitacion = new Habitacion("Familiar");
var miPrimerReserva = new Reserva(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(1)), miPrimerHabitacion);
var miSegundaReserva = new Reserva(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), DateOnly.FromDateTime(DateTime.Now.AddDays(3)), miSegundaHabitacion);
miPrimerReserva.MostrarHabitacion();
miSegundaReserva.MostrarHabitacion();

//Tienda y Prenda
Tienda tienda = new Tienda();
Prenda prenda1 = new Prenda { Nombre = "Camisa", Talla = "M", Precio = 19.99 };
Prenda prenda2 = new Prenda { Nombre = "Pantalón", Talla = "L", Precio = 29.99 };
tienda.AgregarPrenda(prenda1);
tienda.AgregarPrenda(prenda2);
tienda.MostrarPrendas();
Prenda encontrada = tienda.BuscarPrendaPorNombre("Camisa");
if (encontrada != null)
{
    Console.WriteLine("Prenda encontrada: " + encontrada.Nombre + " Talla: " + encontrada.Talla + " Precio: " + encontrada.Precio);
}
else
{
    Console.WriteLine("Prenda no encontrada");
}

//Empresa y Empleado
Empresa empresa = new Empresa();
Empleado empleado1 = new Empleado { Nombre = "Camilo", Cargo = "Ingeniero", Salario = 500.000 };
Empleado empleado2 = new Empleado { Nombre = "Juan", Cargo = "Doctor", Salario = 200.000 };
empresa.AgregarEmpleado(empleado1);
empresa.AgregarEmpleado(empleado2);
empresa.MostrarEmpleados();
Empleado encontrado = empresa.BuscarEmpleadoPorNombre("Camilo");
if (encontrado != null)
{
    Console.WriteLine("Empleado encontrado: " + encontrado.Nombre + " Cargo: " + encontrado.Cargo + " Salario: " + encontrado.Salario);
}
else
{
    Console.WriteLine("Empleado no encontrado");
}