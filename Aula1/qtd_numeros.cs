using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            Console.Write("Quantos números você vai digitar?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i <= n; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
                Console.WriteLine("valor " + soma);
            }
        }
	}
}
