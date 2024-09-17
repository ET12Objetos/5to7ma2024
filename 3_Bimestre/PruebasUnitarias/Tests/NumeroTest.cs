using Application;

namespace Tests;

public class NumeroTest
{
    Numero numero;
    public NumeroTest()
    {
        //Act
        numero = new Numero();
    }

    [Theory]
    [InlineData(2, 4, 6)]
    [InlineData(-1, -3, -4)]
    [InlineData(2, -3, -1)]
    [InlineData(-2, 9, 7)]
    [InlineData(7, 0, 7)]
    [InlineData(0, -9, -9)]
    [InlineData(0, 0, 0)]
    public void CuandoSeSumeDosNumerosEnteros_DebeRetornarLaSuma(int a, int b, int expected)
    {
        //Act

        //Arrange
        int resultado = numero.Sumar(a, b);

        //Assert
        Assert.Equal(expected, resultado);
    }

    [Fact]
    public void CuandoSeDivideDosNumerosEnteros_DebeRetornarLaDivision()
    {
        //Act

        //Arrange
        int resultado = numero.Dividir(8, 4);

        //Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void CuandoSeDivideDosNumerosEnteros_DebeRetornarLaDivision2()
    {
        //Act
        //Number numero = new Number();

        //Arrange
        float resultado = numero.Dividir(3f, 4f);

        //Assert
        Assert.Equal(0.75, resultado);
    }

    [Fact]
    public void CuandoSeDivideDosNumerosYDividoPorCero_DebeRetornarUnaExcepcion()
    {
        //Act
        //Number numero = new Number();

        //Arrange
        //float resultado = numero.Dividir(3f, 0);

        //Assert
        Assert.Throws<DivideByZeroException>(() => numero.Dividir(3f, 0));
    }
}