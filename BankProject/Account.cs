namespace BankProject
{
    abstract class Account
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public Account(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
        {
            AccountNumber = accountNumber;
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
    }
}