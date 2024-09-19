Console.Write("Ingrese un numero entero: ");

int numeroEntero = 0;

try
{
    numeroEntero = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("El valor ingresado es incorrecto");
}

Console.WriteLine(numeroEntero);