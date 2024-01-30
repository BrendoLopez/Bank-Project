namespace BankProject.Entities
{
    public class UserService
    {
        public string NomeCompleto
        {
            get; set;
        }
        public string SenhaUsuario
        {
            get; set;
        }
        public string EmailUsuario
        {
            get; set;
        }
        public string CpfUsuario
        {
            get; set;
        }

        public UserService()
        {

        }

        public UserService(string nomeCompleto, string senhaUsuario, string emailUsuario, string cpfUsuario)
        {
            NomeCompleto = nomeCompleto;
            SenhaUsuario = senhaUsuario;
            EmailUsuario = emailUsuario;
            CpfUsuario = cpfUsuario;
        }

        public static void CreateLogin()
        {
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


            UserService dadosUsuario = new UserService();
            dadosUsuario.NomeCompleto = nomeCompleto;
            dadosUsuario.SenhaUsuario = senhaUsuario;
            dadosUsuario.EmailUsuario = emailUsuario;
            dadosUsuario.CpfUsuario = cpfUsuario;

            System.Console.WriteLine("");
            System.Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            Menu.OptionsAccountUser();
        }
    }
}