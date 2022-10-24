using System;
using System.Globalization;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();

            // dados da pessoa
            Console.Write("Digite seu peso: ");
            var peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite sua altura: ");
            var altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Atribuir os dados a classe
            pessoa.Altura = altura;
            pessoa.Peso = peso;

            // Chamando os métodos
            pessoa.Mensagem();
        }
    }
}
