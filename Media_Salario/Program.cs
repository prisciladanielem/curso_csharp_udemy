using System;
using System.Globalization;

namespace Media_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Funcionario();
            var f2 = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            Console.Write("Digite o salário do primeiro funcionário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário médio é " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
