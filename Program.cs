using System;

namespace FundamentosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldoTotal = 0;
            bool validaSaque;

            Console.WriteLine("-------Conta bancária-------");

            // criação do objeto = instância da classe Conta
            Conta conta1 = new Conta();

            conta1.AdicionarLimite(1000);

            conta1.Deposita(2000);
            conta1.Deposita(5000);

            validaSaque = conta1.Saca(50000);

            if (validaSaque)
            {
                saldoTotal = conta1.ConsultaSaldoDisponivel();

                Console.WriteLine("Saldo disponível: " + saldoTotal);
                Console.WriteLine("Limite disponível: " + conta1.Limite);
            }
          
        }
    }
}
