/* HERANCA - e um tipo de associacao que permite que a classe herde dados e comportamentos de outra. 
    - Permite o reuso de atributos e metodos (dados e comportamento);
    - E representada por uma seta com ponta branca;
    - E uma relacao "e um";
    - Generalizacao (Classe Account)/ Especializacao (Classe BusinessAccount);
    - Superclasse (classe base (generica) - Account) / Subclasse (classe derivada (especializada) - BusinessAccountn);
    - Heranca / extencao - Classe BusinessAccount extende a classe Account, incluindo novos parametros;
    - Heranca e uma associacao entre classes (e nao entre objetos).
*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Globalization;
using Aula126_Heranca.Entities;

namespace Aula126_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(8010, "Vinicius Coelho Bemfica", 235000.00);

            BusinessAccount businessAccount = new BusinessAccount(8010, "Vinicius Coelho Bemfica", 325100.0, 500.0);

            Console.WriteLine("Account: " + account.Number);
            Console.WriteLine("Holder: "+ account.Holder);
            Console.WriteLine("Balance: "+ account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Business Account: " + businessAccount.Number);
            Console.WriteLine("Holder: " + businessAccount.Holder);
            Console.WriteLine("Balance: " + businessAccount.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Loan Limit: " + businessAccount.LoanLimit.ToString("F2", CultureInfo.InvariantCulture));

            // account.Balance = 200.0; - Erro, por causa dos Modificadores de Acesso (protected)
        }
    }
}
