using System;

namespace _14Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe Calculo
            var calculo = new Calculo();

            // Atribuindo valor ao numero1 e ao numero2
            Console.Write("Digite o numero um: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero dois: ");
            var numero2 = int.Parse(Console.ReadLine());

            // Chamar os métodos Somar() e Subtrair()
            calculo.Somar(numero1, numero2);
            calculo.Subtrair(numero1, numero2);
        }
    }
}
