using System;

namespace BankProject.Entities
{
    public class PersonalChange
    {
        // Metodos para a alteração dos dados pessois do cliente
        private Menu menuOpcoes;

        public PersonalChange()
        {
            
        }

        public void AlteracaoNomeCompleto()
        {
            Console.Clear();
            System.Console.WriteLine("Você escolheu a opção de alterar os dados pessoais.");

            UserService cliente = new UserService();
            System.Console.WriteLine("");
            System.Console.WriteLine("1 - Nome");
            System.Console.WriteLine("2 - Senha");
            System.Console.WriteLine("3 - Email");
            System.Console.WriteLine("4 - CPF");
            System.Console.WriteLine("");
            System.Console.Write("Qual dos 4 itens você deseja alterar?: ");
            string dadosAlteracao = Console.ReadLine();

            if(int.TryParse(dadosAlteracao, out int respostaAlteracao))
            {
                if(respostaAlteracao == 1)
                {
                    System.Console.Clear();
                    System.Console.Write("Digite o novo nome para ser alterado: ");
                    string novoNomeCompleto = Console.ReadLine();
                    cliente.NomeCompleto = novoNomeCompleto;
                    System.Console.WriteLine($"Seu novo nome agora é: {cliente.NomeCompleto}");
                    menuOpcoes.ReturnOptionsMenu();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você digitou algo errado, tente novamente!");
                menuOpcoes.ReturnOptionsMenu();
            }
        }
    }
}