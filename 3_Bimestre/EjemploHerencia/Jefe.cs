namespace EjemploHerencia;

public class Jefe : Persona
{
    public int Edad { get; set; }    
    public decimal Sueldo { get; set; }

    public void InformarNombreCompleto()
    {
        Console.WriteLine($"{Nombre.ToUpper()} {Apellido.ToUpper()}");
    }
}