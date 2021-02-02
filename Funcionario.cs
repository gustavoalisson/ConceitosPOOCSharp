using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public abstract void Reajustar();

    }
}
