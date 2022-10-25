using System;
using System.Globalization;

abstract class Padrao
{
    // Método obrigatório
    public abstract void TaxaEmprestimo(double valor); // nâo possui um corpo será implementado nas classes que herdam

    // Método Opcional
    public void CalculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine($"Ganhos obtidos pela poupança: {(valor * taxa).ToString("C", CultureInfo.InvariantCulture)}");
    }
}