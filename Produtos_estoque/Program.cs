using System;
using System.Globalization;

namespace Produtos_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Produto();
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido no estoque: ");
            qtd = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
