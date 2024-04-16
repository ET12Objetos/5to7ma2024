Console.Write("Ingresar un numero: ");
int numeroLeido = Convert.ToInt32(Console.ReadLine());

string signo = DeterminarSigno(numeroLeido);

Console.Write(signo);

string DeterminarSigno(int numero)
{
    if (numero > 0)
    {
        return "Numero positivo";
    }
    else if (numero == 0)
    {
        return "Numero neutro";
    }
    else
    {
        return "Numero negativo";
    }
}

string DeterminarSigno2(int numero) => numero == 0 ? "neutro" : numero > 0 ? "positivo" : "negativo";

// void DeterminarSigno(int numero)
// {
//     if (numero > 0)
//     {
//         Console.Write("Numero positivo");
//     }
//     else if (numero == 0)
//     {
//         Console.Write("Numero neutro");
//     }
//     else
//     {
//         Console.Write("Numero negativo");
//     }
// }