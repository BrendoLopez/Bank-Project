using BankProject.Entities;
using System.Globalization;

namespace BankProject
{
    public class Menu : Account
    {
        private Account account = new Account();
        private UserService userService = new UserService();
        public void OptionsCreateLogin()
        {
            Console.Clear();
            System.Console.WriteLine("Olá, bem-vindo ao nosso Banco <<Bank Project>>.");
            System.Console.WriteLine("Deseja criar uma conta em nosso banco? \nExemplo de resposta esperada: 1 para Sim e 2 para Não.");
            System.Console.Write("Resposta: ");
            string inputUsuario = Console.ReadLine();

            if (int.TryParse(inputUsuario, out int respostaUsuario))
            {
                switch (respostaUsuario)
                {
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine(">>CRIAÇÃO DE LOGIN>>>>>>");
                        System.Console.WriteLine("");
                        System.Console.Write("Nome completo: ");
                        string nomeCompleto = Console.ReadLine();
                        System.Console.Write("Senha: ");
                        string senhaUsuario = Console.ReadLine();
                        System.Console.Write("Email / Login: ");
                        string emailUsuario = Console.ReadLine();
                        System.Console.Write("CPF: ");
                        string cpfUsuario = Console.ReadLine();
                        userService.CreateLogin(nomeCompleto, senhaUsuario, emailUsuario, cpfUsuario);

                        System.Console.WriteLine("");
                        System.Console.Write("Pressione ENTER para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        OptionsAccountUser();
                    break;

                    case 2:
                    Console.Clear();
                    System.Console.WriteLine("Uma pena você não querer fazer parte do nosso banco, volte sempre!");
                    Environment.Exit(0);
                    break;

                    default:
                    OptionsCreateLogin();
                    break;
                }
            }
            else
            {
                OptionsCreateLogin();
            }
        }

        public void OptionsAccountUser()
        {
            System.Console.WriteLine("1 - Verificar Saldo");
            System.Console.WriteLine("2 - Realizar Saque");
            System.Console.WriteLine("3 - Realizar Depósito");
            System.Console.WriteLine("4 - Alteração de Dados Pessoais");
            System.Console.WriteLine("5 - Extrato de Transações");
            System.Console.WriteLine("6 - Sair");
            System.Console.WriteLine("");

            System.Console.Write("O que deseja fazer dentre as opções acima?: ");
            string inputUsuario = Console.ReadLine();


            if (int.TryParse(inputUsuario, out int respostaUsuario))
            {
                switch (respostaUsuario)
                {
                    case 1:
                        ChecarSaldo();
                        Console.Clear();
                        System.Console.WriteLine("Você escolheu verificar o saldo da conta bancária.");
                        double valor = account.ChecarSaldo();
                        CultureInfo culturaBrasileira = new("pt-BR");
                        System.Console.WriteLine("O saldo da sua conta é: " + valor.ToString("C", culturaBrasileira));
                        System.Console.Write("Pressione a tecla ENTER para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        OptionsAccountUser();
                    break;

                    case 2:
                        System.Console.Write("Quanto você deseja sacar?: ");
                        double sacar = double.Parse(Console.ReadLine());
                        var saqueEfetuado = account.Sacar(sacar);
                    
                        if(!saqueEfetuado)
                        {
                            System.Console.WriteLine("");
                            System.Console.WriteLine("Você não tem saldo para saque, faça um depósito.");
                            System.Console.WriteLine("");
                            System.Console.Write("Aperte a tecla ENTER para voltar ao menu de opções do banco...");
                            Console.ReadLine();
                            Console.Clear();
                            OptionsAccountUser();
                        }
                    break;
                }
            }
        }
    }
}