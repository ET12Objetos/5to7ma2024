/*Ejercicio 1
Realizar un algoritmo que permita ingresar un número por teclado y nos informe si es positivo o negativo o neutro.
*/
Console.WriteLine("Ingrese un numero");
int numero = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numero = 0 ? "Es neutro" : (numero > 0 ? "Es positivo" : "Es Negativo")) 
if (numero > 0)
    Console.WriteLine("El numero es positivo");
else
{
    if (numero == 0)
        Console.WriteLine("El numero es Neutro");
    else
        Console.WriteLine("El numero es negativo");
}

/*Ejercicio 2
Realizar un algoritmo en el cual se introduzca un número entero por teclado
y nos informe si es par o impar o neutro.
*/

Console.WriteLine("Ingrese un numero");
int numero1 = Convert.ToInt16(Console.ReadLine());

if (numero1 == 0)
    Console.WriteLine("Numero neutro");
else
{
    if (numero1 % 2 == 0)
        Console.WriteLine("Numero es par");
    else
        Console.WriteLine("Numero es impar");
}

// Ejercicio 3
// Realizar un programa en el que se ingrese 2 (dos) números enteros y 
// se imprima por pantalla si cada número ingresado es par y positivo.

Console.WriteLine("Ingrese un numero");
int numero2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Ingrese un numero");
int numero3 = Convert.ToInt16(Console.ReadLine());

if (numero2 > 0 && numero2 % 2 == 0)
    Console.WriteLine(numero2);

if (numero3 > 0 && numero3 % 2 == 0)
    Console.WriteLine(numero3);

//Ejercicio 4
//Realizar un algoritmo que permita al usuario ingresar un número entero positivo menor o 
//igual a 10, caso contrario se debe informar por pantalla “Número ingresado incorrecto”. 

Console.WriteLine("Ingrese un numero");

int numero4 = Convert.ToInt32(Console.ReadLine());

if (numero4 <= 0 || numero4 > 10)
    Console.WriteLine("Número ingresado incorrecto");

