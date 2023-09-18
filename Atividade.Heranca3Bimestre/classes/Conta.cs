using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Heranca3Bimestre.classes
{
    internal class Conta
    {
        public int Nconta { get; set; }
        public string Agencia { get; set; } 
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int nconta, string agencia, string titular, double saldo)
        {
            Nconta = nconta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public Conta()
        {

        }
        
        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void Depositar(double valor)
        {
            if(valor >= 0)
            {
                Saldo = valor + Saldo;
                Console.WriteLine("Deposito efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }

        //base: chamando o construtor do pai, 
    }
}
