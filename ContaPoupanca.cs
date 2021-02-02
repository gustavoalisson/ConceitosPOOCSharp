using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class ContaPoupanca : Conta
    {
        // base = quer pegar o construtor da classe de herença conta
       public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {
          
        }

        public void MostrarNumeroConta()
        {
            Console.WriteLine("O número da conta popança é: " + this.Numero);
        }

        
    }
}
