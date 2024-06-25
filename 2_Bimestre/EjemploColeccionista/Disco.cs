
namespace EjemploColeccionista;

public class Disco
{
    public required string Nombre { get; set; }
    public int Lanzamiento { get; set; }
    public string Genero { get; set; } = "";
    public required Artista Artista { get; set; }
    public List<Tema> Temas { get; set; } = new List<Tema>();
    public required string SelloDiscografico { get; set; }

    internal void AgregarUn(Tema tema)
    {
        Temas.Add(tema);
    }
}