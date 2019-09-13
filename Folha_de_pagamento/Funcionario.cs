using System.Globalization;

namespace Folha_de_pagamento
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;

        public double SalarioLiquido()
        {
            return SalarioBruto - Impostos;
        }
        public void AumentarSalarioPorcentagem(double porcentagem)
        {
            SalarioBruto += (SalarioBruto / 100) * porcentagem;
        }
        public override string ToString()
        {
            return Nome
                + " $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
