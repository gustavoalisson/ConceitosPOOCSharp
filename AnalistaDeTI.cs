using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class AnalistaDeTI : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 700;
        }
    }
}
