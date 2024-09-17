namespace Application;

public class Numero
{
    public int Sumar(int a, int b) => a + b;

    public int Multiplicar(int a, int b) => a * b;

    public int Dividir(int a, int b) => a / b;

    public float Dividir(float a, float b)
    {
        if (b != 0)
            return a / b;
        throw new DivideByZeroException("Escuchame no se puede dividir por zero");
    }
}
