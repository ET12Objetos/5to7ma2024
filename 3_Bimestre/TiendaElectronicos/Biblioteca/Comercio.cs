namespace Biblioteca;

public class Comercio
{
    public List<Electrodomestico> inventario { get; set; } = new List<Electrodomestico>();
    public List<Cliente> clientes { get; set; } = new List<Cliente>();
    public List<Factura> facturas { get; set; } = new List<Factura>();
}