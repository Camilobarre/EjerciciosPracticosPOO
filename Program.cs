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

//Escuela y Curso
Escuela escuela = new Escuela();
Curso curso1 = new Curso { Nombre = "Matematicas", Codigo = 2, Duracion = "8 horas" };
Curso curso2 = new Curso { Nombre = "Ingles", Codigo = 7, Duracion = "4 horas" };
escuela.AgregarCurso(curso1);
escuela.AgregarCurso(curso2);
escuela.MostrarCursos();
Curso encontradoCurso = escuela.BuscarCursoPorNombre("Matematicas");
if (encontradoCurso != null)
{
    Console.WriteLine("Curso encontrado: " + encontradoCurso.Nombre + " Codigo: " + encontradoCurso.Codigo + " Duracion: " + encontradoCurso.Duracion);
}
else
{
    Console.WriteLine("Curso no encontrado");
}

//Calcular area de Circulo y Rectangulo
Figura circulo = new Circulo(5);
Figura rectangulo = new Rectangulo(4, 6);
Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());

//Arrancar Vehiculo de Coche y Moto
Vehiculo moto = new Moto();
Vehiculo coche = new Coche();
moto.Arrancar();
coche.Arrancar();

//Manejo de trabajos como Desarrollador y Gerente
Empleado2 desarrollador = new Desarrollador();
Empleado2 gerente = new Gerente();
desarrollador.Trabajar();
gerente.Trabajar();

// Jerarquia de clases en Transporte (Coche2, Bicicleta, Autobus)
Transporte coche2 = new Coche2();
Transporte bicicleta = new Bicicleta();
Transporte autobus = new Autobus();
coche2.IniciarViaje();
Console.WriteLine(coche2.ObtenerDetallesViaje());
coche2.DetenerViaje();
bicicleta.IniciarViaje();
Console.WriteLine(bicicleta.ObtenerDetallesViaje());
bicicleta.DetenerViaje();
autobus.IniciarViaje();
Console.WriteLine(autobus.ObtenerDetallesViaje());
autobus.DetenerViaje();

//Jerarquia de clases en Producto (Electronico, Ropa, Alimento)
Producto electronico = new Electronico("Laptop", 1000);
Producto ropa = new Ropa("Camiseta", 50);
Producto alimento = new Alimento("Pan", 2);
electronico.MostrarDetalles();
ropa.MostrarDetalles();
alimento.MostrarDetalles();

//Jerarquia de clases en Personal (Doctor, Enfermera, Administrativo)
Personal doctor = new Doctor("Dr. Barreneche", 5000);
Personal enfermera = new Enfermera("Enfermera Clara", 3000);
Personal administrativo = new Administrativo("Administrador Pepito", 2500);
doctor.MostrarDetalles();
enfermera.MostrarDetalles();
administrativo.MostrarDetalles();