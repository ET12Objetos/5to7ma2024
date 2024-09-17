namespace EjemploHerencia;

public abstract class Persona : IPersona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public int CalcularEdad()
    {
        DateTime FechaActual = DateTime.Now;
        int edad = FechaActual.Year - FechaNacimiento.Year;
        return edad;
    }

    public void InformarNombreCompleto()
    {
        Console.WriteLine($"{Apellido}, {Nombre}");
    }
}