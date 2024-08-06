namespace Biblioteca;

public class Factura
{
    public int id { get; set; }
    public required Cliente cliente { get; set; }
    public List<ItemFactura> items { get; set; } = new List<ItemFactura>();
    public decimal total { get; set; }
}