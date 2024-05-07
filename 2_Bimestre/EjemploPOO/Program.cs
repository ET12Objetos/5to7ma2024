// Realizar un programa que pida la estatura (en metros) y
// edad de un número indeterminado de personas. Posteriormente se debe informar por pantalla 
// la estatura media de las personas mayores a 21 años y la estatura más alta de las 
// personas menores a 21 años.

int estatura, edad;

Console.Write("Ingrese una estatura: ");
estatura = Convert.ToInt32(Console.ReadLine());
List<Persona> personas = new List<Persona>();
Persona persona = new Persona();

while (estatura != 0)
{
    Console.Write("Ingrese una edad: ");
    edad = Convert.ToInt32(Console.ReadLine());

    persona = new Persona { Estatura = estatura, Edad = edad };

    personas.Add(persona);

    Console.Write("Ingrese una estatura: ");
    estatura = Convert.ToInt32(Console.ReadLine());
}

double estaturaMedia = persona.CalcularEstaturaMedia(personas);

int estaturaMasAlta = personas
    .Where(persona => persona.Edad < 21)
    .Max(persona => persona.Estatura);

System.Console.WriteLine($"Estatura media > 21: {estaturaMedia}");

System.Console.WriteLine($"Estatura mas alta < 21: {estaturaMasAlta}");

public class Persona
{
    public int Edad { get; set; }
    public int Estatura { get; set; }

    public double CalcularEstaturaMedia(List<Persona> personas)
        => personas
            .Where(persona => persona.Edad > 21)
            .Average(persona => persona.Estatura);
}