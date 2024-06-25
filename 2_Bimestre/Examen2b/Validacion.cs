namespace Examen2b;

public static class Validacion
{
    public static void ValidarRango(int valor, string mensajeError)
    {
        if (valor < 0)
            throw new Exception(mensajeError);
    }
}