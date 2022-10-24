using System;
using System.Globalization;

class Colaborador : Pessoa
{
    // Atributos
    private double _salario;

    // Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        _salario = salario;

        MensagemPessoa();
        MensagemColaborador();
    }

    // Método
    private void MensagemColaborador()
    {
        Console.WriteLine($"Salário: {_salario.ToString("C2")}");
    }
}