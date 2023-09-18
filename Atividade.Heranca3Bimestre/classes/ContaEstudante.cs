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

        public ContaEstudante()
        {

        }
        public void Sacar(double valor)
        {
            if(Saldo <= LimiteChequeEspecial)
            {
                base.Sacar(valor);
                /*Saldo = valor - Saldo;
                Console.WriteLine("Saque realizado!");*/
            }
            else
            {
                Console.WriteLine("Não é possivél sacar!");
            }
        }
    }
}
