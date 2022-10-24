using System;

class Pessoa
{
    // Atributo
    private string _nome = "Tatiana";

    //Construtor
     public Pessoa(string _nome)
    {
        Console.WriteLine(_nome);
    } // Sem o this ele mostra o nome que vai no parâmetro que vamos receber no programa
    public Pessoa(string _nome)
    {
        Console.WriteLine(this._nome);
    } // Com o this ele nos trás o atributo da classe 

}