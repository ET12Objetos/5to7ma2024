namespace Biblioteca;

public class ItemFactura
{
    public required Electrodomestico electrodomestico { get; set; }
    public int cantidad { get; set; }
    public decimal subtotal { get; set; }

    public decimal Subtotal()
    {
        subtotal = cantidad * electrodomestico.precio;
        
        return subtotal;
    }
}