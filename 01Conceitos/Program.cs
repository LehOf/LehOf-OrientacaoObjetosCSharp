using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto
            var pessoa = new Pessoa();
            pessoa.Nome = "Leila";
            pessoa.Idade = 21;
            pessoa.Mensagem();          
        }
    }
}
