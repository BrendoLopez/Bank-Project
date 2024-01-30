using System.Globalization;

namespace BankProject.Entities
{
    public class Account
    {
        public int NumeroConta { get; set; }
        public string NomeProprietario { get; set; }
        public double SaldoConta { get; set; }

        public Account()
        {
        }

        public Account(int numero, string nomeProprietario, double saldoConta)
        {
            NumeroConta = numero;
            NomeProprietario = nomeProprietario;
            SaldoConta = saldoConta;
        }

        public static void Sacar(double quantia)
        {
            Account saldoConta = new Account();

            if (quantia > 0)
            {
                saldoConta.SaldoConta -= quantia;
            }
        }

        public void Depositar(double quantia)
        {
            SaldoConta += quantia;
        }

        public static void ChecarSaldo()
        {
            Account saldo = new Account();
            Console.Clear();
            System.Console.WriteLine("Você escolheu verificar o saldo da conta bancária.");
            double valor = saldo.SaldoConta;
            CultureInfo culturaBrasileira = new("pt-BR");
            System.Console.WriteLine("O saldo da sua conta é: " + valor.ToString("C", culturaBrasileira));
            System.Console.Write("Pressione a tecla ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            Menu.OptionsAccountUser();
        }

        public override string ToString()
        {
            return "Número da conta: " + NumeroConta + "\nNome do proprietário: " + NomeProprietario + "\nSaldo da conta: " + SaldoConta;
        }
    }
}