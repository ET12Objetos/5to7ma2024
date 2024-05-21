//Escribir un programa en donde el usuario ingrese asignaturas de un curso 
//(por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista 
//y la informe por pantalla en orden alfabético.

Console.Write("Ingrese una asignatura: ");
string asignatura = Console.ReadLine();

List<string> asignaturas = new List<string>();

while (asignatura != "")
{
    asignaturas.Add(asignatura); //AGREGACION, elemento a una lista
    Console.Write("Ingrese una asignatura: ");
    asignatura = Console.ReadLine();
}

//ORDENAMIENTO 

//forma clásica - no recomendada
//asignaturas.Sort();

//LINQ - recomendada
var asignaturasOrdenadas = asignaturas.OrderBy(asignatura => asignatura);

//primer y ultimo elemento de la lista First y Last
var primeraAsignatura = asignaturas.First();
var ultimaAsignatura = asignaturas.Last();

//ELIMINACION

//eliminar - Remove
asignaturas.Remove(primeraAsignatura);

//foreach - ciclo de repetición 
//leer cosas de la lista
foreach (string asig in asignaturasOrdenadas)
{
    Console.WriteLine(asig);
}

//BUSQUEDA

//buscar elementos en la lista con una UNICA condición
var asignaturasFiltradas = asignaturas
    .Where(asignatura => asignatura.Length > 5);

foreach (string asig in asignaturasFiltradas)
{
    Console.WriteLine(asig);
}

//buscar elementos en la lista con mas de una condición
var asignaturasFiltradas2 = asignaturas
    .Where(asignatura => asignatura.Length > 5 && asignatura.Length < 10);

var asignaturasFiltradas3 = asignaturas
    .Where(asignatura => asignatura.Length > 5)
    .Where(asignatura => asignatura.Length < 10);
