using Atividade.Heranca3Bimestre.classes;


public class Program
{
    static void Main(string[] args)
    {
        int Nconta = 1;
        string Agencia = "Ji-Paraná";
        while (true)
        {
            Console.WriteLine("Digite\n" +
            "1 Conta comum, \n" +
            "2 para Conta Estudante e\n" +
            "3 para Conta Empresarial");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do titular:");
            string titular = Console.ReadLine() ;
            if (opcao == 1)
            {
                Conta c = new Conta(Nconta, Agencia, titular, 0);
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if(opcao == 1)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                        Console.WriteLine($"Novo saldo {c.Saldo}");

                    }else if(opcao == 2)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Sacar(valor);
                        Console.WriteLine($"Novo saldo {c.Saldo}");

                    }
                    else if(opcao == 3)
                    {
                        break;
                    }
                }
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o cpf do estudante: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Informe a instituição: ");
                string instituicao = Console.ReadLine();

                ContaEstudante ce = new ContaEstudante(instituicao, cpf, 200, Nconta, Agencia, titular, 0);
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Depositar(valor);
                        Console.WriteLine($"Novo saldo {ce.Saldo}");

                    }
                    else if (opcao == 2)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Sacar(valor);
                        Console.WriteLine($"Novo saldo {ce.Saldo}");

                    }
                    else if (opcao == 3)
                    {
                        break;
                    }
                }
            }
            else if (opcao == 3)
            {
                ContaEmpresarial cemp = new ContaEmpresarial(10, 1000, Nconta, Agencia, titular, 0);

                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar, 3 para emprestimo e 4 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cemp.Depositar(valor);
                        Console.WriteLine($"Novo saldo {cemp.Saldo}");

                    }
                    else if (opcao == 2)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cemp.Sacar(valor);
                        Console.WriteLine($"Novo saldo {cemp.Saldo}");

                    }
                    else if (opcao == 3)
                    {
                        Console.Write("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cemp.FazerEmprestimo(valor);
                        Console.WriteLine($"Novo saldo {cemp.Saldo}");

                    }
                    else if (opcao == 3)
                    {
                        break;
                    }
                }
            }
        }
        
    }
}
