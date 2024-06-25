
namespace EjemploColeccionista;

public class Coleccionista
{
    public required string Nombre { get; set; }

    public List<Disco> Discos { get; set; } = new List<Disco>();

    internal void AgregarUn(Disco disco)
    {
        Discos.Add(disco);
    }

    public void EliminarUn(string nombreDisco)
    {
        var disco = Discos.FirstOrDefault(x => x.Nombre == nombreDisco);

        Discos.Remove(disco);
    }

    public bool Buscar(string nombreDisco)
    {
        return Discos.Any(x => x.Nombre == nombreDisco);
    }

    public int CantidadDiscos() => Discos.Count;
}