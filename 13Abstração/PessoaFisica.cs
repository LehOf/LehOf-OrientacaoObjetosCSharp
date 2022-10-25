using System;
using System.Globalization;

class PessoaFisica : Padrao
{
    // Implementando classe abstratada - método obrigatório
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de empréstimo para a Pessoa Fisíca: {(valor * 0.1).ToString("C")}");
    }
}