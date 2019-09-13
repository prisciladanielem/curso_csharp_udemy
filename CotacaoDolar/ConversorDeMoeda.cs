using System.Globalization;

namespace CotacaoDolar
{
    class ConversorDeMoeda
    {
        private static double IOF = 6.0;

        public static double ConverteDolarEmReais(double CotacaoDolar, double ValorComprasDolar)
        {  
            double total = ValorComprasDolar + (ValorComprasDolar / 100) * IOF;
            return CotacaoDolar * total;
        }
    }
}
