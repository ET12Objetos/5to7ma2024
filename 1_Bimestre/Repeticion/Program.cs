//Ciclos de repeticion - Bucles 

//for
//uso habitual
// for (int i = 0; i < 5; i++)
//     Console.WriteLine("Mensaje" + (i + 1));

// for (int i = 0; i < 6; i++)
// {
//     Console.WriteLine(i + 1);
//     Console.WriteLine("Mensaje");
// }

// for (int i = 10; i > 6; i--) // i-- equivale a i = i - 1
// {
//     Console.WriteLine(i);
//     Console.WriteLine("Mensaje");
// }

// for (int i = 0; i <= 10; i = i + 2)
//     Console.WriteLine(i);

//uso poco usual
//for (int i = 0; i < 5; i++) ;

//for (; ; );

//while
// condicion es verdadera
// while(condicion) => condicion tiene un valor de verdad
// {
//      condicion es falsa
// }

// int i = 10;
// int j = 1;
// while (i < 10 && j > 0) //&& = and ; || = or
// {
//     Console.WriteLine(i);
//     i++;
// }


//do-while
// do {
//      condicion es falsa
// } while (condicion) => se ejecuta mientras la condicion es verdadera

// int i = 1;
// do
// {
//     Console.WriteLine(i);
//     i++;
// } while (i < 10);


//Ejercicio 1
// Realizar un algoritmo que informe por pantalla todos los números enteros del 100 al 200
// for (int numero = 100; numero <= 200; numero++)
//     Console.WriteLine(numero);

// for (int numero = 200; numero >= 100; numero--)
//     Console.WriteLine(numero);

//Ejercicio 5
// Realizar un algoritmo que informe por pantalla todos los números naturales desde el 1 (uno) hasta 
// el número natural que el usuario ingrese por teclado.
// int numero, i = 1;
// Console.Write("Ingrese un numero: ");
// numero = Convert.ToInt32(Console.ReadLine());

// while (i < numero)
// {
//     Console.WriteLine(i);
//     i++;
// }

//Ejercicio 11
//Hacer un algoritmo para mostrar por pantalla los números del 20 al 200 en orden creciente

int i = 20;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 200);