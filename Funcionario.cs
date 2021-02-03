using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosPOO
{
    public abstract class Funcionario
    {
        //implementação da classe abstrata
        private string Nome { get; set; }
        public double Salario { get; protected set; }

        public abstract void Reajustar();

        public void AdicionarNome(string primeiroNome, string sobreNome)
        {
            string nomeCompleto = $"{primeiroNome} {sobreNome}";
            this.Nome = nomeCompleto;
        }

        public void AdicionarSalario(double salario)
        {
            this.Salario = salario;
        }

    }
}
