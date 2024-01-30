namespace BankProject.Entities
{
    public class BusinessAccount : Account
    {
        public double LimiteEmprestimo
        {
            get; set;
        }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int numero, string nomeProprietario, double saldoConta, double limiteEmprestimo) : base(numero, nomeProprietario, saldoConta)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Limite(double quantia)
        {
            if (quantia <= LimiteEmprestimo)
            {
                SaldoConta += quantia;
            }
        }
    }
}