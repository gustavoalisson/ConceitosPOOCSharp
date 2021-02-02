using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class GerenteDeTI : Gerente
    {
        public override void Reajustar()
        {
            this.Salario += 2000;
        }
    }
}
