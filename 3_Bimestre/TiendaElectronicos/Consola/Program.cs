using Biblioteca;

Electrodomestico electrodomestico = new Electrodomestico
{
    nombre = "Plancha",
    codigo = "ABC123",
    precio = 2000
};

ItemFactura item = new ItemFactura
{
    electrodomestico = electrodomestico,
    cantidad = 3
};

decimal valor = item.Subtotal();
System.Console.WriteLine(valor);