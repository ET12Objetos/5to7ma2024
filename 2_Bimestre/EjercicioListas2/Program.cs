// Escribir un programa que almacene las asignaturas de un curso 
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y 
// su calificación asociada. Informar por pantalla las asignaturas con sus respectivas 
// notas todo ordenado de forma descendente por nota.


using ConsoleTables;
using EjercicioListas2;

Console.Write("Ingrese asignatura: ");
string asignatura = Console.ReadLine();

List<Calificacion> calificaciones = new List<Calificacion>();

while (asignatura != "")
{
    Console.Write("Ingrese nota: ");
    int nota = Convert.ToInt32(Console.ReadLine());

    var calificacion = new Calificacion()
    {
        Asignatura = asignatura,
        Nota = nota
    };

    calificaciones.Add(calificacion);

    Console.Write("Ingrese asignatura: ");
    asignatura = Console.ReadLine();
}

//Informar lista con foreach
// foreach (Calificacion cal in calificaciones)
// {
//     Console.WriteLine($"Asignatura: {cal.Asignatura}");
//     Console.WriteLine($"Nota: {cal.Nota}");
// }


//informar lista en formato tabla
var tabla = new ConsoleTable("Asignatura", "Nota");


foreach (Calificacion cal in calificaciones)
{
    tabla.AddRow(cal.Asignatura, cal.Nota);
}

tabla.Write(Format.Minimal);