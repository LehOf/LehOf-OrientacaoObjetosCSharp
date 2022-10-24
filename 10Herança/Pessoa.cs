using System;

class Pessoa
{
    // Atributos 
    protected string nome;
    protected int idade;

    // Método
    protected void MensagemPessoa()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade} anos");
    }
}