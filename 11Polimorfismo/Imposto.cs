using System;
using System.Globalization;

class Imposto
{
    // Método valeAlimentação
    public virtual void ValeAlimentação(double salario) //virtual é usada para que possa sofrer alterações neste método
    {
        Console.WriteLine($"Desconto padrão do vale alimentação: {(salario * 0.1).ToString("C")})"); // desconto 10% salário bruto do funcionário
    }
    
    // Método ValeTransporte
    public void ValeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale Transporte: {(salario * 0.06).ToString("C")}"); // desconto 6% salário bruto do funcionário
    }
}