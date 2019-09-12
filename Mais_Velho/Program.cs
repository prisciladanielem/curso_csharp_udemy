using System;

namespace Mais_Velho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha " + p1.nome);
            }
            else if( p2.idade > p1.idade)
            {
                Console.WriteLine("Pessoa mais velha " + p2.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: Ninguém, eles tem a mesma idade!");
            }
        }
    }
}
