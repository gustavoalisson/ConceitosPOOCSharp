using System;

namespace FundamentosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudando POO");

            AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            GerenteDeTI gerenteDeTI = new GerenteDeTI();

            analistaDeTI.Nome = "Alisson Gustavo";
            analistaDeTI.Salario = 4500;

            Console.WriteLine($"Salário do analista de TI {analistaDeTI.Nome} é {analistaDeTI.Salario} ");

            analistaDeTI.Reajustar();

            Console.WriteLine($"O salário de {analistaDeTI.Nome} foi reajustado para {analistaDeTI.Salario}");

            Console.WriteLine("__________________________________________________________________");

            gerenteDeTI.Nome = "Gustavo Barbosa";
            gerenteDeTI.Salario = 14000;

            Console.WriteLine($"Salário do Gerente de TI {gerenteDeTI.Nome} é {gerenteDeTI.Salario} ");

            gerenteDeTI.Reajustar();

            Console.WriteLine($"O salário de {gerenteDeTI.Nome} foi reajustado para {gerenteDeTI.Salario}");


            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("------- Conta bancária -------");

            double saldoTotal = 0;
            bool validaSaque;

            Console.WriteLine("------- Conta Poupança -------");

            ContaPoupanca cp = new ContaPoupanca(154, 0);

            cp.Deposita(1500);
            cp.Saca(500);

            double saldoPoupanca = cp.ConsultaSaldoDisponivel();

            Console.WriteLine("Saldo na poupança: " + saldoPoupanca);
            Console.WriteLine("Limite da poupança: " + cp.Limite);
            cp.MostrarNumeroConta();


            Console.WriteLine("--------------------------------------------------------");

            // criação do objeto = instância da classe Conta
            Conta conta1 = new Conta(3590, 1000);
            Conta conta2 = new Conta(158, 4000);
            Conta conta3 = new Conta(123, 700);
            Conta conta4 = new Conta(511, 960);

            conta1.Deposita(2000);
            conta1.Deposita(5000);

            validaSaque = conta1.Saca(1200);

            if (validaSaque)
            {
                saldoTotal = conta1.ConsultaSaldoDisponivel();

                Console.WriteLine("Saldo disponível: " + saldoTotal);
                Console.WriteLine("Limite disponível: " + conta1.Limite);
                Console.WriteLine("O número da sua conta é: " + conta1.Numero);
            }

            Console.WriteLine("--------------------------------------------------------");
           
            int totalContas = Conta.ProximoTotalContasCriadas();

            Console.WriteLine("Número de contas criadas: " + Conta.TotalContasCriadas);
            Console.WriteLine("Próximo total de contas criadas: " + totalContas);



            //Criação dos objetos
            CartaoDeCredito cartao = new CartaoDeCredito();
            Cliente cliente1 = new Cliente();

            // Nome do cliente
            cliente1.Nome = "Alisson Gustavo";

            // Adicionar número e validade do cartão 
            cartao.Numero = "5567 7865 9798 4002";
            cartao.DataValidade = "01/12/2021";
            cartao.CodigoSeguranca = 263;

            cartao.Cliente = cliente1;

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("O nome do cliente é: " + cliente1.Nome);
            Console.WriteLine("Número do cartão: " + cartao.Numero);
            Console.WriteLine("Data de validade: " + cartao.DataValidade);
            Console.WriteLine("Código de segurança: " + cartao.CodigoSeguranca);
            Console.WriteLine("Nome do cliente agragado ao cartão: " + cartao.Cliente.Nome);


        }
    }
}
