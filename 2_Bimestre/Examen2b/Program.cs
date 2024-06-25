using ConsoleTables;
using Examen2b;

System.Console.Write("Ingrese Nombre Playlist: ");
string nombre = Console.ReadLine();

System.Console.Write("Ingrese Usuario Playlist: ");
string usuario = Console.ReadLine();

Playlist playlist = new Playlist() { Nombre = nombre, Usuario = usuario };

System.Console.Write("Ingrese Nombre Pelicula: ");
string nombrePelicula = Console.ReadLine();

while (nombrePelicula != "")
{
    System.Console.Write("Ingrese Año Pelicula: ");
    int añoPelicula = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Ingrese Duración Pelicula: ");
    int duracionPelicula = Convert.ToInt32(Console.ReadLine());

    playlist.Agregar(new Pelicula
    {
        Nombre = nombrePelicula,
        Año = añoPelicula,
        Duracion = duracionPelicula
    });

    System.Console.Write("Ingrese Nombre Pelicula: ");
    nombrePelicula = Console.ReadLine();
}

//informar

var puntoUno = playlist.PeliculasOrdenadasPorNombre();

var table = new ConsoleTable("Nombre");

foreach (string nombreP in puntoUno)
{
    table.AddRow(nombreP);
}

table.Write();

var puntoDos = playlist.PelicularOrdenadasPorAñoEstreno();

var table2 = new ConsoleTable("Nombre", "Año", "Duración");

puntoDos.ForEach(pelicula => table2.AddRow(pelicula.Nombre, pelicula.Año, pelicula.Duracion));

table2.Write();