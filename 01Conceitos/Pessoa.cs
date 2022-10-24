using System;

class Pessoa
{
    // Atributos
    public string Nome;
    public int Idade;

    // Métodos
    public void Mensagem()
    {
        Console.WriteLine($"Olá {Nome} você têm {Idade} anos");
    }
}