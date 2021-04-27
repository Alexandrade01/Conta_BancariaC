using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio18
{
    abstract class Conta_Bancaria : Object
    {
        private string nomeCliente;
       
        public string NomeCliente { get => nomeCliente; set { if (string.IsNullOrEmpty(value)) { throw new Exception("Nome Invalido!"); } nomeCliente = value; } }
        public virtual string NumerodaConta
        {
            get; set;
        }
        public double Saldo { get; protected set; }
        public abstract void Deposito(double valor);
        public abstract void Saque(double valor);

        public override string ToString()
        {
            return "Nome: " + NomeCliente + Environment.NewLine +"Numero da conta: " + NumerodaConta+ Environment.NewLine+ "Saldo: R$" + Saldo.ToString("0.00");
        }
    }
}







