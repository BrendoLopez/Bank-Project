using BankProject.Entities;

namespace BankProject
{
    public class Menu : Account
    {
        public static void OptionsCreateLogin()
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
                    UserService.CreateLogin();
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

        public static void OptionsAccountUser()
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
                    ;
                    ChecarSaldo();
                    break;
                    case 2:
                    System.Console.Write("Quanto você deseja sacar?: ");
                    double sacar = double.Parse(Console.ReadLine());
                    Sacar(sacar);
                    break;
                }
            }
        }
    }
}