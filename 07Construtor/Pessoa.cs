using System;

class Pessoa
{
    // Construtor
    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    // Posso ter vários construtor desde que ele tenha características diferentes ou parâmetros diferentes

    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá: {nome}");
    }
}