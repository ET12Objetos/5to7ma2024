
namespace EjemploComplejos;

public class NumeroComplejo
{
    public NumeroComplejo(int parteReal, int parteImaginaria)
    {
        ParteReal = parteReal;
        ParteImaginaria = parteImaginaria;
    }

    public int ParteReal { get; }
    public int ParteImaginaria { get; }

    public void Sumar(NumeroComplejo numero2)
    {
        int sumaReal = ParteReal + numero2.ParteReal;
        int sumaImaginaria = ParteImaginaria + numero2.ParteImaginaria;
        Console.WriteLine($"Parte real: {sumaReal}, Parte imaginaria: {sumaImaginaria}");
    }
}