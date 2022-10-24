using System;
using System.Globalization;

class Aluno
{
    // Atributos
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    // Métodos Média
    public double Media()
    {
        return (Nota1+Nota2)/2;
    }

    // Métodos Situação
    public string Situacao()
    {
        return Media() >= 7 ? "Aprovado" : " Reprovado"; 
    }

    // Métodos Mensagem
    public void Mensagem()
    {
        Console.WriteLine($"O aluno {Nome} foi {Situacao()} com média {Media().ToString("F2", CultureInfo.InvariantCulture)}");
    }
}