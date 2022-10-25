using System;
using System.Globalization;

class PessoaJuridica : Padrao
{
    // Implementando classe abstratada - método obrigatório
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de empréstimo para a Pessoa Jurídica: {(valor * 0.2).ToString("C")}");
    }
}