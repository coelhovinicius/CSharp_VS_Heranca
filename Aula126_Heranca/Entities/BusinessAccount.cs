/* >>> SUBCLASSE BUSINESSACCOUNT - SUBCLASSE DA CLASSE ACCOUNT <<< */
namespace Aula126_Heranca.Entities
{
    class BusinessAccount : Account // (: Account) - Herda de Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        /* (: base (...)) - Permite herdar os construtores da Superclasse Account */
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
