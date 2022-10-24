using System;
using System.Globalization;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno();

            // Pegando dados
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Digite o valor da primeira nota: ");
            var nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor da segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Atribuir os dados a classe
            aluno.Nome = nome;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;

            // Chamando os métodos
            aluno.Mensagem();
        }
    }
}
