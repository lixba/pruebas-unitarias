using Calculadora;
namespace Calculadora.Tests;

public class OperacionesMatematicasTests
{
    private readonly OperacionesMatematicas _operacionesMatematicas = new();

    [Fact]
    public void Sumar_DosPositivos_RetornaLaSuma()
    {
        //arrange       
        int a = 3 ;
        int b = 5;
        
        //act
        var resultado = _operacionesMatematicas.Sumar(a, b);
        
        //assert
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void Sumar_NegativoMasPositivo_RegresaValorCorrecto()
    {
        
        int a = -3 ;
        int b = 5;
        
        //act
        var resultado = _operacionesMatematicas.Sumar(a, b);
        
        //assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Sumar_ceroMasCero_regresaCero()
    {
        int a = 0 ;
        int b = 0;
        
        //act
        var resultado = _operacionesMatematicas.Sumar(a, b);
        
        //assert
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void Restar_DosPositivos_RetornaLaResta()
    {
        //arrange       
        int a = 3 ;
        int b = 5;
        
        //act
        var resultado = _operacionesMatematicas.Restar(a, b);
        
        //assert
        Assert.Equal(-2, resultado);
    }

    [Fact]
    public void restar_NegativoMasPositivo_RegresaValorCorrecto()
    {
        
        int a = -3 ;
        int b = 5;
        
        //act
        var resultado = _operacionesMatematicas.Restar(a, b);
        
        //assert
        Assert.Equal(-8, resultado);
    }
}