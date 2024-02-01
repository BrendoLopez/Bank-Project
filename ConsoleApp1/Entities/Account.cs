namespace BankProject.Entities
{
    public class Account
    {
        private int NumeroConta { get; set; }
        private string NomeProprietario { get; set; }
        private double SaldoConta { get; set; }

        public Account()
        {
        }

        public Account(int numero, string nomeProprietario, double saldoConta)
        {
            NumeroConta = numero;
            NomeProprietario = nomeProprietario;
            SaldoConta = saldoConta;
        }

        public bool Sacar(double quantia)
        {
            if(quantia <= SaldoConta)
            {
                SaldoConta -= quantia;
                return true;
            }
            return false;
        }

        public bool Depositar(double quantia)
        {
            if(quantia > 0)
            {
                SaldoConta += quantia;
                return true;
            }
            return false;
        }

        public double ChecarSaldo()
        {
            return SaldoConta;
        }

        public override string ToString()
        {
            return "Número da conta: " + NumeroConta + "\nNome do proprietário: " + NomeProprietario + "\nSaldo da conta: " + SaldoConta;
        }
    }
}