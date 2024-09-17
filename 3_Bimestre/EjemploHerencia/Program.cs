using EjemploHerencia;

Empleado empleado1 = new Empleado();

Jefe jefe = new Jefe();

jefe.Nombre = "Josu";
jefe.Apellido = "Duran";
jefe.FechaNacimiento = Convert.ToDateTime("2006-9-21");
Console.WriteLine($"Edad: {jefe.CalcularEdad()}");

// jefe.InformarNombreCompleto();

Persona empleado2 = new Empleado();

Console.WriteLine(empleado2.Email);

IPersona empleado3 = new Empleado();

//Console.WriteLine(empleado3.);


//la clase abstracta no se puede instanciar un objeto
//Persona persona = new Persona();