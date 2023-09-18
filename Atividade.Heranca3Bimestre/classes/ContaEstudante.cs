using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Heranca3Bimestre.classes
{
    internal class ContaEstudante: Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public ContaEstudante(string nomeInstituicao, string cpf, double limiteChequeEspecial, int nconta, string agencia, string titular, double saldo): 
            base(nconta,agencia,titular,saldo)//simplificação do metodo do pai
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;
            this.Cpf = cpf;
            this.NomeInstituicao = nomeInstituicao;
        }

        public override void Sacar(double valor)//override é para sobreescrever o metodo
        {
            if(valor <= Saldo + LimiteChequeEspecial)
            {
                Saldo = valor - Saldo;

                //base.Sacar(valor);
                /*Saldo = valor - Saldo;
                Console.WriteLine("Saque realizado!");*/
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}
