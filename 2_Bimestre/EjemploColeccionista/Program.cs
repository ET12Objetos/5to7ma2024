using EjemploColeccionista;

System.Console.Write("Ingrese nombre: ");
string nombre = Console.ReadLine();

var coleccionista = new Coleccionista() { Nombre = nombre };

Console.Write("Ingrese Nombre Disco: ");
var nombreDisco = Console.ReadLine();

while (nombreDisco != "")
{
    Console.Write("Ingrese Genero Disco: ");
    var generoDisco = Console.ReadLine();

    Console.Write("Ingrese Sello Discografico Disco: ");
    var selloDiscograficoDisco = Console.ReadLine();

    Console.Write("Ingrese Año Lanzamiento Disco: ");
    var añoLanzamientoDisco = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese Nombre Artista: ");
    var nombreArtista = Console.ReadLine();

    var artista = new Artista { Nombre = nombreArtista };

    var disco = new Disco
    {
        Nombre = nombreDisco,
        Genero = generoDisco,
        Lanzamiento = añoLanzamientoDisco,
        SelloDiscografico = selloDiscograficoDisco,
        Artista = artista
    };

    Console.Write("Ingrese Nombre Tema: ");
    var nombreTema = Console.ReadLine();

    while (nombreTema != "")
    {
        Console.Write("Ingrese Duracion Tema");
        var duracionTema = Convert.ToInt32(Console.ReadLine());

        var tema = new Tema { Nombre = nombreTema, Duracion = duracionTema };

        disco.AgregarUn(tema);

        Console.Write("Ingrese Nombre Tema");
        nombreTema = Console.ReadLine();
    }

    coleccionista.AgregarUn(disco);

    Console.Write("Ingrese Nombre Disco");
    nombreDisco = Console.ReadLine();
}