using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*   ----------------------------------- SOBRE GET E SET -----------------------------------
                set enviar informação para um atributo
                get obtém a informação enviada
                Usamos get e set para termo o encapsulamento onde evitamos o uso de atributos públicos
                por exemplo você precisa enviar ou capturar uma informação sem deixar o atributo publico
            */

            var pessoa = new Pessoa();

            pessoa.Nome = "Leila"; // Set obtendo a informação
            
            Console.WriteLine(pessoa.Nome); // _Get lendo a informação
        }
    }
}
