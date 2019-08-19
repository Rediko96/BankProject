using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account;



            account = new SavingAccounts("940000000001", 0.0M, "Marek", "Zając", 92010133333);
            account = new SavingAccounts("940000000002", 0.0M, "Marek", "Zając", 92010133333);

            //string fullName = account.getFullName();
            // Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);

            // string fullBalance = savingsAccount.getBalance();
            // Console.WriteLine("Twoja wartość konta wynosi: {0}", fullBalance);



            //BillingAcounts billingsAccount = new BillingAcounts(savingsAccount.AccountNumber, savingsAccount.Balance, savingsAccount.FirstName, savingsAccount.LastName,
            //savingsAccount.Pesel);


            Printer printer = new Printer();

            printer.Print(account);
            printer.Print(account);
            //printer.Print(billingsAccount);

            Console.ReadKey();

        }

    }
}
