using EjemploCafetera;

Console.Write("Cantidad actual: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

Cafetera cafetera = new Cafetera(cantidad);

cafetera.Vaciar();
cafetera.Informar();
cafetera.Hacer();
cafetera.Servir(300);
cafetera.Informar();