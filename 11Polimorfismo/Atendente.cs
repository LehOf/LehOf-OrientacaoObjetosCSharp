using System;
using System.Globalization;

class Atendente : Imposto
{
    // Método ValeAlimentação
        public override void ValeAlimentação(double salario) //sobreescrevedo o método
    {
        Console.WriteLine($"Desconto atendente do vale alimentação: {(salario * 0.12).ToString("C")}"); // desconto 12% salário bruto do funcionário
    }
}