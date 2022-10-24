using System;
using System.Globalization;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo várias formas

            // Pegar o valor do salário
            Console.Write("Digite seu salário: ");
            var salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Instanciando Gerente
            var gerente = new Gerente();

            gerente.ValeAlimentação(salario);
            gerente.ValeTransporte(salario);
            Console.WriteLine("-------------------------------------------");

            // Instanciando Atendente
            var atendente = new Atendente();

            atendente.ValeAlimentação(salario);
            atendente.ValeTransporte(salario);
            Console.WriteLine("-------------------------------------------");

            // Instanciando Estagiário
            var estagiario = new Estagiario();

            estagiario.ValeAlimentação(salario);
            estagiario.ValeTransporte(salario);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
