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
            System.Console.WriteLine("Deseja criar uma conta em nosso banco? \nExemplo de resposta esperada: 1 = Sim e 2 = Não.");
            System.Console.Write("Resposta: ");
            string inputUsuario = Console.ReadLine();

            if (int.TryParse(inputUsuario, out int respostaUsuario))
            {
                switch (respostaUsuario)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine(">>CRIAÇÃO DE LOGIN>>>>>>");
                    Console.WriteLine("");
                    Console.Write("Nome completo: ");
                    string nomeCompleto = Console.ReadLine();
                    Console.Write("Senha: ");
                    string senhaUsuario = Console.ReadLine();
                    Console.Write("Email / Login: ");
                    string emailUsuario = Console.ReadLine();
                    Console.Write("CPF: ");
                    string cpfUsuario = Console.ReadLine();
                    userService.CreateLogin(nomeCompleto, senhaUsuario, emailUsuario, cpfUsuario);

                    Console.WriteLine("");
                    Console.Write("Pressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    OptionsAccountUser();
                    break;

                    case 2:
                    Console.Clear();
                    Console.WriteLine("Uma pena você não querer fazer parte do nosso banco, volte sempre!");
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
            Console.WriteLine("Olá " + userService.NomeCompleto + ".");
            Console.WriteLine("");
            Console.WriteLine("1 - Verificar Saldo");
            Console.WriteLine("2 - Realizar Saque");
            Console.WriteLine("3 - Realizar Depósito");
            Console.WriteLine("4 - Alteração de Dados Pessoais");
            Console.WriteLine("5 - Extrato de Transações");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("");

            Console.Write("O que deseja fazer dentre as opções acima?: ");
            string inputUsuario = Console.ReadLine();


            if (int.TryParse(inputUsuario, out int respostaUsuario))
            {
                switch (respostaUsuario)
                {
                    case 1:
                    ChecarSaldo();
                    Console.Clear();
                    Console.WriteLine("Você escolheu verificar o saldo da conta bancária.");
                    double valor = account.ChecarSaldo();
                    CultureInfo culturaBrasileira = new("pt-BR");
                    Console.WriteLine("O saldo da sua conta é: " + valor.ToString("C", culturaBrasileira));
                    Console.Write("Pressione a tecla ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    OptionsAccountUser();
                    break;

                    case 2:
                    Console.Write("Quanto você deseja sacar?: ");
                    double sacar = double.Parse(Console.ReadLine());
                    var saqueEfetuado = account.Sacar(sacar);

                    if (!saqueEfetuado)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Você não tem saldo para saque, faça um depósito.");
                        Console.WriteLine("");
                        Console.Write("Aperte a tecla ENTER para voltar ao menu de opções do banco...");
                        Console.ReadLine();
                        Console.Clear();
                        OptionsAccountUser();
                    }

                    if (saqueEfetuado)
                    {
                        Console.WriteLine($"Saque de {account.ChecarSaldo()} efetuado com sucesso!");
                        Console.ReadLine();
                        OptionsAccountUser();
                    }
                    break;
                }
            }
        }
    }
}