using System;

namespace _05Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();

            produto.Nome = "Leila";

            // Note que não podemos atribuir o _valor uma vez que seu modificador de acesso
            // private pode ser visto e usado apenas pela classe que o criou
        }
    }
}
