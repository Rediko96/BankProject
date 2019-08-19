using System.Collections.Generic;
namespace BankProject
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }


        public Account(int id, decimal balance, string firstName, string lastName, long pesel)
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public abstract string TypeName();
        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);

            return fullName;
        }

        public string GetBalance()
        {
            return string.Format("{0}zł", Balance);
        }

        private string generateAccountNumber(int id)
        {
            var accountNumber = string.Format("94{0:D10}", id);

            return accountNumber;
        }
    }

    class AccountsManager
    {
        private IList<Account> _accounts;
        public AccountsManager()
        {
            _accounts = new List<Account>();
        }

    }
}