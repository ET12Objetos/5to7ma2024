using EjemploComplejos;

NumeroComplejo numero1 = new NumeroComplejo(parteReal: -3, parteImaginaria: 2);
NumeroComplejo numero2 = new NumeroComplejo(parteReal: 5, parteImaginaria: -3);
numero1.Sumar(numero2);
Console.WriteLine(numero1.ParteReal);
Console.WriteLine(numero1.ParteImaginaria);
