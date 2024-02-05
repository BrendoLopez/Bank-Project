using System;

namespace BankProject.Entities
{
    public class PersonalChange
    {
        Menu menuOpcoes = new Menu();

        public PersonalChange()
        {
            
        }

        // Metodos para a alteração dos dados pessois do cliente
        public void AlteracaoNomeCompleto()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu a opção de alterar os dados pessoais.");

            UserService cliente = new UserService();
            Console.WriteLine("");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Senha");
            Console.WriteLine("3 - Email");
            Console.WriteLine("4 - CPF");
            Console.WriteLine("");
            Console.Write("Qual dos 4 itens você deseja alterar?: ");
            string dadosAlteracao = Console.ReadLine();

            if(int.TryParse(dadosAlteracao, out int respostaAlteracao))
            {
                if(respostaAlteracao == 1)
                {
                    Console.Clear();
                    Console.Write("Digite o novo nome para ser alterado: ");
                    string novoNomeCompleto = Console.ReadLine();
                    cliente.NomeCompleto = novoNomeCompleto;
                    Console.WriteLine($"Seu novo nome agora é: {cliente.NomeCompleto}");
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