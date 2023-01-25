using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCalculadora;

public class CalculadoraSystem
{
    public int Sumar(string nro)
    {
        if (string.IsNullOrEmpty(nro))
            return 0;

        var resultadoFinal = 0;
        var valoresParaSumar = new List<int>();
        var valores = nro.Split(",");

        foreach (var valor in valores)
        {

            var valorEntero = int.Parse(valor);
            valoresParaSumar.Add(valorEntero);

        }

        foreach (var i in valoresParaSumar)
        {
            resultadoFinal = resultadoFinal + i;
        }

        return resultadoFinal;

    }

    public int SumarConDistintosDelimitadores(string nro)
    {
        if (string.IsNullOrEmpty(nro))
            return 0;
        var resultadoFinal = 0;
        var valoresParaSumar = new List<int>();
        var valores = nro.Split(',',';','/');

        foreach (var valor in valores)
        {

            var valorEntero = int.Parse(valor);
            valoresParaSumar.Add(valorEntero);

        }

        foreach (var i in valoresParaSumar)
        {
            resultadoFinal = resultadoFinal + i;
        }

        return resultadoFinal;
    }



    //Punto 5)

    public string ValidarNumerosNegativos(string nro)
    {
        var nroNegativo = int.Parse(nro);

        if (nroNegativo < 0)
            throw new Exception("el numero es negativo");

        return nro;
    }

    //Punto 6

    public string CaracterEnviadoComoNumeroSeparadoPorComa(string nro)
    {
        var caracterIngresado = int.Parse(nro);
        var x = 2;

        if(caracterIngresado != x)

        throw new Exception("SOLO numeros");

        return nro;

    }

    //metodo para numeros mayores a 100
}

