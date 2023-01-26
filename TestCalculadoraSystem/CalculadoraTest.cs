using SystemCalculadora;
using Xunit;

namespace TestCalculadoraSystem;

public class CalculadoraTest
{
    [Fact]
    public void Sumar_EnvioVacio_ReciboCero()
    {
        // arrange

        var calculadorda = new CalculadoraSystem();


        // act 

        var resultado = calculadorda.Sumar("");

        // assert
        Assert.Equal(0, resultado);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("3,4", 7)]
    [InlineData("5,6", 11)]

    public void Suma_NumerosSeparadosPorComa_DevuelveSumaDeLosNumeros(string valores, int sumaValores)
    {
        // arrange

        var calculadorda = new CalculadoraSystem();


        // act 

        var resultado = calculadorda.Sumar(valores);

        // assert
        Assert.Equal(sumaValores, resultado);
    }
    [Theory]
    [InlineData("1;2", 3)]
    [InlineData("3;4", 7)]
    [InlineData("5/6", 11)]

    public void Suma_NumerosSeparadosPorCualquierDelimitador_DevuelveSumaDeLosNumeros(string valores, int sumaValores)
    {
        // arrange

        var calculadorda = new CalculadoraSystem();


        // act 

        var resultado = calculadorda.SumarConDistintosDelimitadores(valores);

        // assert
        Assert.Equal(sumaValores, resultado);
    }

    [Theory]
    [InlineData("-1")]
    [InlineData("-2")]
    [InlineData("-3")]

    public void nroNegativos_DevuelveExeption(string nroNegativo)
    {
        // arrange

        var calculadorda = new CalculadoraSystem();


        // act 

       // var numeroNegativoIngresado = calculadorda.ValidarNumerosNegativos(nroNegativo);

        // assert
        Assert.Throws<Exception>(() => calculadorda.ValidarNumerosNegativos(nroNegativo));

    }
    [Theory]
    [InlineData("a")]
    [InlineData("4")]
    [InlineData("c")]

    public void ExeptionCaracterIngresadoComoNumero(string caracterIngresado)
    {
        // arrange

        var calculadorda = new CalculadoraSystem();


        // act 

       // var resultado = calculadorda.CaracterEnviadoComoNumeroSeparadoPorComa(nro);

        // assert
        Assert.Throws<Exception>(() => calculadorda.CaracterEnviadoComoNumeroSeparadoPorComa(caracterIngresado));
    }

    // theory para numeros mayores a 100

    [Theory]
    [InlineData("101")]
    [InlineData("102")]
    [InlineData("103")]

    public void nroMayoresACien_DevuelveExeption(string nroMayorACien)
    {
        // arrange

        var calculadorda = new CalculadoraSystem();


        // act 

        // var numeroNegativoIngresado = calculadorda.ValidarNumerosNegativos(nroNegativo);

        // assert
        Assert.Throws<Exception>(() => calculadorda.ValidarNumerosMayorACien(nroMayorACien));

    }

}

