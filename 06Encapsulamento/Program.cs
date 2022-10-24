using System;

namespace _06Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamento serve para restrigir a visíbilidade dos nossos Atributos e Métodos

            var aluno = new Aluno();
            aluno.Mensagem();   
        }
    }
}
