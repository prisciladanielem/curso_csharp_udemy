using System;
using System.Globalization;

namespace Folha_de_pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informa o salário bruto do funcionário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor dos impostos que serão descontados:");
            funcionario.Impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.SalarioLiquido();

            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine();
            Console.Write("Informa a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalarioPorcentagem(porcentagem);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
