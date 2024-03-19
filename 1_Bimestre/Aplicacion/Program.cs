//Comentarios
// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hola mundo!");
linea1
linea2
*/
//nombre = input("Ingrese un nombre")

//declarar una variable de tipo string
string nombre;

//asignar un valor a la variable 'nombre'
nombre = "Jose";

//informa por consola un mensaje al usuario
Console.WriteLine("Ingrese un nombre: ");

//lee el nombre ingresado por consola
nombre = Console.ReadLine();

//informa el valor ingresado previamente
Console.WriteLine("Nombre: " + nombre);

Console.WriteLine("Ingrese edad: ");
// string lectura = Console.ReadLine();
// int edad = Convert.ToInt32(lectura);
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Edad: " + edad);

// bool esMayorDeEdad = false;

// if (edad >= 18)
//     esMayorDeEdad = true;

// System.Console.WriteLine(esMayorDeEdad);

if (edad > 0)
{
    if (edad >= 18)
        Console.WriteLine("Es mayor de edad");
    else
        Console.WriteLine("No es mayor de edad");
}
else
    Console.WriteLine("Edad incorrecta");


//operador ternario ? :
//Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "No es mayor de edad");

