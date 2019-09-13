using System;
using System.Globalization;

namespace CalcularNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas dos alunos: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F1", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
