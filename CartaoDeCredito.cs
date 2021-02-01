using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class CartaoDeCredito
    {
        public string Numero { get; set; }
        public string DataValidade { get; set; }
        public int CodigoSeguranca { get; set; }

        // agregação da classe cliente
        public Cliente Cliente { get; set; }

    }
}
