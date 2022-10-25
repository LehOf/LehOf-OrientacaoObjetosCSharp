using System;

class Calculo : IPadrao
{
    // Implementando o método Soma()
    public void Somar(int numero1, int numero2)
    {
        Console.WriteLine($"A soma é: {numero1 + numero2}");
    }

    // Implementando o método Subtrair()
     public void Subtrair(int numero1, int numero2)
    {
        Console.WriteLine($"A Subtração é: {numero1 - numero2}");
    }
}