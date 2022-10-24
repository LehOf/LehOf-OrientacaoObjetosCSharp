using System;

namespace _12Estático
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quando utilizamos o atributo ou método estático nâo precisamos instanciar o objeto
            Console.Write("Digite o primeiro valor: ");
            var numero1 = int.Parse(Console.ReadLine());
             Console.Write("Digite o segundo valor: ");
            var numero2 = int.Parse(Console.ReadLine());

            // Atrbuindo valores ao parâmetro do método estático Soma()
            Exemplo.Soma(numero1, numero2);

            // Atributo estático
            Console.WriteLine($"Olá: {Exemplo.nome}");
        }
    }
}
