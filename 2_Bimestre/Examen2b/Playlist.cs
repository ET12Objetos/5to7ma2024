namespace Examen2b;

public class Playlist
{
    public required string Nombre { get; set; }
    public required string Usuario { get; set; }
    public List<Pelicula> Peliculas { get; set; } = new List<Pelicula>();

    public void Agregar(Pelicula pelicula)
    {
        Validacion.ValidarRango(pelicula.Año, "El año ingresado no se encuentra en el rango");

        Validacion.ValidarRango(pelicula.Duracion, "La duracion ingresado no se encuentra en el rango");

        Peliculas.Add(pelicula);
    }

    public List<string> PeliculasOrdenadasPorNombre()
    {
        return Peliculas.OrderBy(pelicula => pelicula.Nombre).Select(x => x.Nombre).ToList();
    }

    public List<Pelicula> PelicularOrdenadasPorAñoEstreno()
    {
        return Peliculas.Where(x => x.Duracion > 120).OrderByDescending(x => x.Año).ToList();
    }
}