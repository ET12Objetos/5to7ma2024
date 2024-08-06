namespace Biblioteca;

public class Electrodomestico
{
    public required string nombre { get; set; }
    public required string codigo { get; set; }
    public string descripcion { get; set; } = "";
    public int stock { get; set; }
    public decimal precio { get; set; }
}
