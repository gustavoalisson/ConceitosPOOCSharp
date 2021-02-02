using System;


namespace FundamentosPOO
{
    public class Conta
    {
        //Metodo construtor
        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalContasCriadas++;
        }

        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; private set; }
        // atributo estático = faz parte da minha classe Conta e não da instância (vive na classe)
        public static int TotalContasCriadas { get; set; }


        //Metodos
        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }

        public void Deposita(double valor)
        {
            this.Saldo = this.Saldo + valor;
        }

        public bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();
            
            if (valor > saldoDisponivel)
            {              
                Console.WriteLine("Saque indisponível"); 
                return false;
            }
            else
            {
                this.Saldo = this.Saldo - valor;
                return true;
            }   
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }


}