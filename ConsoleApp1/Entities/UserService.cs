namespace BankProject.Entities
{
    public class UserService
    {
        public string NomeCompleto { get; set; }
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string CpfUsuario { get; set; }

        public UserService()
        {
        }
        
        public bool CreateLogin(string nomeCompleto, string senhaUsuario, string emailUsuario, string cpfUsuario)
        {
            NomeCompleto = nomeCompleto;
            SenhaUsuario = senhaUsuario;
            EmailUsuario = emailUsuario;
            CpfUsuario = cpfUsuario;
            return true;
        }
    }
}