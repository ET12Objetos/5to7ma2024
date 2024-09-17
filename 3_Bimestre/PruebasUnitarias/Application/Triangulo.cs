namespace Application;

public class Triangulo(int a, int b, int c)
{
    public bool EsTriangulo()
    {
        // if (a <= c && b <= c && a + b > c)
        //     return true;
        // if (a <= b && c <= b && a + c > b)
        //     return true;
        // if (b <= a && c <= a && b + c > a)
        //     return true;
        // return false;
        List<int> lados = new List<int>();
        lados.Add(a);
        lados.Add(b);
        lados.Add(c);

        return lados.OrderBy(x => x).Take(2).Sum() > lados.Max() ? true : false; 
    }

    public string QueTrianguloSos()
    {
        if (!EsTriangulo())
            return "No forma un triangulo";

        List<int> lados = new List<int>();
        lados.Add(a);
        lados.Add(b);
        lados.Add(c);

        int lado = lados.First();

        if (lados.Where(x => x == lado).Count() == 3)
            return "Equilatero";

        int repetido = lados.OrderBy(x => x).ToList()[1];

        if (lados.Where(x => x == repetido).Count() == 2)
            return "Isosceles";

        return "Escaleno";
    }
}