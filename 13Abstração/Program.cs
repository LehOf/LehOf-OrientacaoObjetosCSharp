using System;

namespace _13Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quando temos um método abstrato é obrigatório implementar e intansciar utilizando ele
            
            // Instanciando a classe PessoaFisica e PessoaJuridica
            var pessoaFisica = new PessoaFisica();
            var pessoaJuridica = new PessoaJuridica();

            // Pedindo valor do salario
            Console.Write("Digite seu salário: ");
            var salario = double.Parse(Console.ReadLine());

            // Passando parâmetros para o método abstrato obrigaatóri TaxaEmprestimo()
            pessoaFisica.TaxaEmprestimo(salario);
            pessoaJuridica.TaxaEmprestimo(salario);
        }
    }
}


