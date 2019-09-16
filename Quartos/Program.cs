using System;

namespace Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented?");
            int qtd = int.Parse(Console.ReadLine());

            Aluguel[] vect = new Aluguel[9];

            for(int i = 0; i < qtd; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Aluguel (nome, email);
            }

            Console.WriteLine("Busy rooms");
            for(int i = 0; i < vect.Length;  i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                } 
            }
        }
    }
}
