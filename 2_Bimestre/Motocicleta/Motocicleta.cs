namespace EjemploMotocicleta;

public class Motocicleta
{
    public required string Color { get; set; }
    public required string Patente { get; set; }
    public required string Modelo { get; set; }

    //Constructor Por defecto (vacio)
    // public Motocicleta()
    // {

    // }

    //Contructor
    // public Motocicleta(string color, string patente, string modelo)
    // {
    //     Color = color;
    //     Patente = patente;
    //     Modelo = modelo;
    // }

    private bool EstadoMotor = false;

    public void Prender()
    {
        if (EstadoMotor == false)
            EstadoMotor = true;
        else
            Console.WriteLine("Ya está prendido.");
    }

    public void Apagar()
    {
        if (EstadoMotor == true)
            EstadoMotor = false;
        else
            Console.WriteLine("Ya está apagado.");
    }

    public void Informar()
    {
        Console.WriteLine($"Motocicleta de modelo: {Modelo} con patente: {Patente} y de color {Color}");
    }
}