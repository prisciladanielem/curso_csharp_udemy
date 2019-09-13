﻿using System;
using System.Globalization;

namespace Produtos_estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ " 
                + Preco.ToString("F2",CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " unidades, Total: $" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
