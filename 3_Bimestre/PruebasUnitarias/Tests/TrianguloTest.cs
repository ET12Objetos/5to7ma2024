using Application;

namespace Tests;

public class TrianguloTest
{
    // [Theory]
    // [InlineData(3, 3, 3)] //equilatero
    // [InlineData(3, 3, 5)] //isos
    // [InlineData(3, 5, 3)]
    // [InlineData(5, 3, 3)]
    // [InlineData(3, 4, 5)] //esca
    // [InlineData(3, 5, 4)]
    // [InlineData(4, 3, 5)]
    // [InlineData(4, 5, 3)]
    // [InlineData(5, 3, 4)]
    // [InlineData(5, 4, 3)]
    // public void CuandoSeIngresenTresValores_DebeRetornarTrueSiEsTriangulo(int a, int b, int c)
    // {
    //     Triangulo triangulo = new Triangulo(a, b, c);

    //     bool resultado = triangulo.EsTriangulo();

    //     Assert.True(resultado);
    // }

    [Theory]
    [InlineData(3, 3, 3)] //equilatero
    public void CuandoTrianguloEsEquilatero(int a, int b, int c)
    {
        Triangulo triangulo = new Triangulo(a, b, c);

        string resultado = triangulo.QueTrianguloSos();

        Assert.Equal("Equilatero", resultado);
    }

    [Theory]
    [InlineData(3, 4, 5)] //esca
    [InlineData(3, 5, 4)]
    [InlineData(4, 3, 5)]
    [InlineData(4, 5, 3)]
    [InlineData(5, 3, 4)]
    [InlineData(5, 4, 3)]
    public void CuandoTrianguloEsEscaleno(int a, int b, int c)
    {
        Triangulo triangulo = new Triangulo(a, b, c);

        string resultado = triangulo.QueTrianguloSos();

        Assert.Equal("Escaleno", resultado);
    }

    [Theory]
    [InlineData(3, 3, 5)] //isos
    [InlineData(3, 5, 3)]
    [InlineData(5, 3, 3)]
    public void CuandoTrianguloEsIsosceles(int a, int b, int c)
    {
        Triangulo triangulo = new Triangulo(a, b, c);

        string resultado = triangulo.QueTrianguloSos();

        Assert.Equal("Isosceles", resultado);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, -1, -1)]
    [InlineData(3, 1, 1)]
    [InlineData(1, 3, 1)]
    [InlineData(1, 1, 3)]
    [InlineData(1, 2, 5)]
    [InlineData(2, 1, 5)]
    [InlineData(1, 5, 2)]
    [InlineData(2, 5, 1)]
    [InlineData(5, 2, 1)]
    [InlineData(5, 1, 2)]
    public void CuandoSeIngresenTresValores_DebeRetornarFalseSiEsTriangulo(int a, int b, int c)
    {
        Triangulo triangulo = new Triangulo(a, b, c);

        bool resultado = triangulo.EsTriangulo();

        Assert.False(resultado);
    }
}