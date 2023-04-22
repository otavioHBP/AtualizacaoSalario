using System;
using System.Globalization;

namespace AtualizacaoSalario; 

internal class Program {
    static void Main(string[] args) {
        
        Funcionario func = new Funcionario();

        Console.Write("Digite o nome do funcionário: ");
        func.Name = Console.ReadLine();

        Console.Write("Salário Bruto: R$");
        func.SalarioBruto = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.Write("Imposto atual: R$");
        func.Imposto = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"Funcionário: {func}");

        Console.WriteLine();
        Console.Write("Qual porcentagem deseja aumentar o salário do funcionário? ");
        double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        func.AumentoSalarial(porcent);

        Console.WriteLine();
        Console.WriteLine($"Dados atualizados do funcionário: {func}");

        



    }
}