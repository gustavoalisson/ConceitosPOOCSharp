using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public class Conta
    {

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public Conta()
        {

        }

        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; private set; }


        //Metodos
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