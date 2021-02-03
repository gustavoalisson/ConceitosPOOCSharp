using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    // realiza o contrato de assinatura dos metodos
    public interface IConta
    {
        void Deposita(double valor);
        bool Saca(double valor);
        void AdicionarLimite(double valor);
        double ConsultaSaldoDisponivel();
    }
}
