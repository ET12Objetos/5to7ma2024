using ConsoleTables;
using Validation;

namespace EjercicioListas3;

public class Curso
{
    public int Año { get; set; }
    public int Division { get; set; }
    public int CicloLectivo { get; set; }
    public required string Turno { get; set; }
    public required string Especialidad { get; set; }
    public int CantidadAlumnos { get; set; } = 18;
    public int CantidadAsigturas { get; set; } = 10;
    public List<Asignatura> Asignaturas = new List<Asignatura>();

    public void LeerAsignatura()
    {
        for (int i = 0; i < CantidadAsigturas; i++)
        {
            Console.Write("Ingrese asignatura: ");
            string asignatura = Console.ReadLine();

            Validacion.ValidarCadena(asignatura, "Asignatura incorrecta");
            //Requires.NotNullOrEmpty(asignatura, "Asignatura incorrecta");

            Asignaturas.Add(new Asignatura { Nombre = asignatura });
        }
    }

    public void CargarCalificaciones()
    {
        foreach (Asignatura asignatura in Asignaturas)
        {
            for (int i = 0; i < CantidadAlumnos; i++)
            {
                asignatura.AgregarCalificacion();
            }
        }
    }

    public void InformarAsignaturas()
    {
        foreach (Asignatura asignatura in Asignaturas)
        {
            Console.WriteLine(asignatura.Nombre);

            var tabla = new ConsoleTable("Asignatura", "Nota");

            foreach (Calificacion cal in asignatura.Calificaciones)
                tabla.AddRow(cal.Asignatura.Nombre, cal.Nota);

            tabla.Write(Format.Minimal);
        }
    }
}