using Application;

System.Console.Write("Ingrese un lado: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ingrese un lado: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ingrese un lado: ");
int c = Convert.ToInt32(Console.ReadLine());

Triangulo triangulo = new Triangulo(a, b, c);

Console.WriteLine(triangulo.QueTrianguloSos());