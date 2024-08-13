namespace EjemploHerencia;

public class Persona
{
    public string Nombre { get; set; }    
    public string Apellido { get; set; }    
    public string Email { get; set; }

    public void InformarNombreCompleto()
    {
        Console.WriteLine($"{Apellido}, {Nombre}");
    }
}