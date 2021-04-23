using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio18
{
    class Conta_Poupanca:Conta_Bancaria
    {
        public int Diadeaniversario { get; set; }
        public string NCCorrenteAtrelada { get; set; }
        public override string NumerodaConta { get => NCCorrenteAtrelada;}

        public override void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override void Saque(double valor)
        {
            if (valor>Saldo)
            {
                throw new Exception("O saldo não pode ser negativo!");
            }
            Saldo -= valor;
        }

        public override string ToString()
        {
            return "Nome: " + NomeCliente + Environment.NewLine + "Numero da conta: "
                + NCCorrenteAtrelada + Environment.NewLine +
                "Saldo: R$" + Saldo.ToString("0.00")
                + Environment.NewLine + "Dia de aniversario: " +
                Diadeaniversario.ToString();
        }
    }
}
