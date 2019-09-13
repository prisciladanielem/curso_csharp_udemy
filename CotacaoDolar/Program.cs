using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Qual a cotação do dólar? ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double quantiaDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.ConverteDolarEmReais(valorDolar, quantiaDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
