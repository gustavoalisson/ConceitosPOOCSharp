using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class GerenteDeAgencia : Gerente
    {
        public override void Reajustar()
        {
            this.Salario += 1200;
        }
    }
}
