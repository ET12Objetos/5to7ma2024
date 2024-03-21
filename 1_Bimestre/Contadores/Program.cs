//Contador

//Incremento
Console.WriteLine("Ingrese un numero:");
int numero = Convert.ToInt32(Console.ReadLine());
int numerosPares = 0; //inicializacion del contador
if (numero % 2 == 0)
    numerosPares = numerosPares + 1; //incremento de valor en el contador
                                     //numerosPares++; incremento en una unidad
Console.WriteLine(numerosPares);

//decremento
Console.WriteLine("Ingrese un numero:");
numero = Convert.ToInt32(Console.ReadLine());
numero = numero - 1; //decremento en una unidad
Console.WriteLine(numero);
numero--; //decremento en una unidad
Console.WriteLine(numero);