using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio18
{
    class Conta_Corrente : Conta_Bancaria
    {
       
        public double LimiteCredito { get; set; }
        public bool UtilizaTalaoCheque { get; set; }



        public override void Deposito(double valor)
        {
            Saldo += valor;
        }
        public override void Saque(double valor)
        {
            if (valor>Saldo+LimiteCredito)
            {
                throw new Exception("O Saldo mais o limite não pode ser menor do que zero");

            }

            Saldo -= valor;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Limite de crédito: R$" + LimiteCredito.ToString("0.00")+ Environment.NewLine+ "Utiliza talão?: " + UtilizaTalaoCheque.ToString();
        }

    }
}
