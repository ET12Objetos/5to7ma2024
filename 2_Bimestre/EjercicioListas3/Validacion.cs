namespace EjercicioListas3;

public static class Validacion
{
    public static void ValidarCadena(string cadena, string mensajeError)
    {
        if (string.IsNullOrEmpty(cadena))
            throw new Exception(mensajeError);
    }

    public static void ValidarNota(int nota, string mensajeError)
    {
        if (nota < 0 || nota > 10)
            throw new Exception(mensajeError);
    }
}