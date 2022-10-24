using System;
using System.Globalization;

class Pessoa
{
    //Atributos
    public double Peso { get; set; }
    public double Altura { get; set; }

    // Método 1 retornar cálculo imc
    private double ResultadoImc()
    {
        return Peso / Math.Pow(Altura, Altura);
    }

    // Método 2 retornar situação do imc 
    private string Situacao()
    {
        var resultado = "";

        if (ResultadoImc() < 18.5)
        {
            resultado = "Abaixo do peso";
        }
        else if (ResultadoImc() < 25)
        {
            resultado = "Peso normal";
        }
        else if(ResultadoImc() < 30)
        {
            resultado = "Acima do peso";
        }
        else if(ResultadoImc() < 35)
        {
            resultado = "Obesidade I";
        }
        else if(ResultadoImc() < 40)
        {
            resultado = "Obesidade II";
        }
        else if(ResultadoImc() >= 40)
        {
            resultado = "Obesidade III";
        }

        return resultado;
    }

    // Método 3 Mensagem
    public void Mensagem()
    {
        Console.WriteLine($"O Imc é: {ResultadoImc().ToString("F2", CultureInfo.InvariantCulture)} e sua situação é: {Situacao()}");
    }
}