using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class Gerente : Funcionario
    {
        //sobrepor
        public override void Reajustar()
        {
            this.Salario += 1000;
        }
    }
}
