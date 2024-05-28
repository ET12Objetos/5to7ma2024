// Escribir un programa que almacene las asignaturas de un curso 
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y 
// su calificación asociada. Informar por pantalla las asignaturas con sus respectivas 
// notas todo ordenado de forma descendente por nota.

using EjercicioListas3;

var curso = new Curso
{
    Año = 5,
    Division = 7,
    Turno = "Tarde",
    Especialidad = "Computacion",
    CicloLectivo = 2024
};

curso.LeerAsignatura();

curso.CargarCalificaciones();

curso.InformarAsignaturas();

