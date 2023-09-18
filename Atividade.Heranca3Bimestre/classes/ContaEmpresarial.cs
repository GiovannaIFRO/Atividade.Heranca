using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Heranca3Bimestre.classes
{
    internal class ContaEmpresarial: Conta 
    {
        public double Anuidaade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; } 

        public void FazerEmprestimo (double valor)
        {
            this.LimiteEmprestimo = Saldo;
            //LimiteEmprestimo = valor;

            if(valor > 5000)
            {
                if(LimiteEmprestimo <= valor)
                {
                    Saldo = Saldo + valor - 5;
                    TotalEmprestimo = valor;
                    Console.WriteLine("O emprestimo foi realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possivel realizar o emprestimo!");
                }
            }
            else
            {
                if (LimiteEmprestimo <= valor)
                {
                    Saldo = Saldo + valor;
                    TotalEmprestimo = valor;
                    Console.WriteLine("O emprestimo foi realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi possivel realizar o emprestimo!");
                }
            }
        }

        public void Sacar(double valor)
        {
            base.Sacar(valor);
        }
    }
}
