namespace EjercicioListas3;

public class Asignatura
{
    public required string Nombre { get; set; }

    public List<Calificacion> Calificaciones = new List<Calificacion>();

    public void AgregarCalificacion()
    {
        Console.Write("Ingrese nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());
        Validacion.ValidarNota(nota, "No se puede asignar el valor ingresado");

        var nuevaCalificacion = new Calificacion()
        {
            Asignatura = this,
            Nota = nota
        };

        Calificaciones.Add(nuevaCalificacion);
    }
}