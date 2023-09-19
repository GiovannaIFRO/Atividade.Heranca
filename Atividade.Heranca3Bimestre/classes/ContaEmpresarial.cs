using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Heranca3Bimestre.classes
{
    internal class ContaEmpresarial: Conta 
    {

        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial( double limiteEmprestimo, double anuidade, int nconta, string agencia, string titular, double saldo) : 
            base(nconta, agencia, titular, saldo)
        {
            this.Anuidade = anuidade;
            this.LimiteEmprestimo = limiteEmprestimo;   
        }
        public void FazerEmprestimo (double valor)
        {
            this.LimiteEmprestimo = Saldo;
            //LimiteEmprestimo = valor;

         
                if(valor <= LimiteEmprestimo - TotalEmprestimo)
                {
                    Saldo = Saldo + valor;
                    TotalEmprestimo = TotalEmprestimo + valor;
                    Console.WriteLine("O emprestimo foi realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possivel realizar o emprestimo!");
                }
        }

        public override void Sacar(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo = Saldo - valor;
                if(valor >= 5000)
                {
                    Saldo = Saldo - 5;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
            }
            base.Sacar(valor);
        }
    }
}
