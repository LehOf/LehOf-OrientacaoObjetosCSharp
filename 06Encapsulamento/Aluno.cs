using System;
using System.Globalization;

class Aluno
{
    // Atributos
    private double _nota1, _nota2; // outras classes não terão acesso

    // Métodos Média
    private double Media()
    {
        return (_nota1 + _nota2) / 2;
    }

    // Método Mensagem neste caso pública
    public void Mensagem()
    {
        Console.Write("Informe a primeira nota: ");
        _nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe a segunda nota: ");
        _nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"A média é {Media().ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
