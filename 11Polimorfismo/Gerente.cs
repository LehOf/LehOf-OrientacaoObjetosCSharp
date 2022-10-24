using System;
using System.Globalization;

class Gerente : Imposto
{
    // Método ValeAlimentação
    public override void ValeAlimentação(double salario) //sobreescrevendo um método
    {
        Console.WriteLine($"Desconto gerente do vale alimentação: {(salario * 0.15).ToString("C")}"); // desconto 15% salário bruto do funcionário
    }
}