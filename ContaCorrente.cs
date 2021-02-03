using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class ContaCorrente : Conta, IConta
    {
        public ContaCorrente(int numero, double limite) : base( numero, limite)
        {

        }

        public override bool Saca(double valor)
        {
            // usando metodo Saca de Conta. 
            bool saqueAprovado = base.Saca(valor);

            if (saqueAprovado) // se o saque deu certo irá entrar nessa validação para descontar  uma taxa
            {
                double valorTaxa = 5;
                this.Saldo -= valorTaxa;

                Console.WriteLine("Taxa de manutenção: " + valorTaxa);
             
            }

            return false;
        }

    }
}

