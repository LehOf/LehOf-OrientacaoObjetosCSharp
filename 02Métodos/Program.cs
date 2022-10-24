using System;

namespace _02Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();

            //Pegando dados
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            var idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("MOSTRANDO PRIMEIRO MÉTODO");
            pessoa.Apresentar();
            Console.WriteLine();

            Console.WriteLine("MOSTRANDO SEGUNDO MÉTODO: ");
            pessoa.Apresentar(nome);
            Console.WriteLine();

            Console.WriteLine("MOSTRANDO TERCEIRO MÉTODO: ");
            pessoa.Apresentar(nome, idade);
            Console.WriteLine();
        }
    }
}
