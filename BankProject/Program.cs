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

            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingAccounts(1,12.9M, "Marek", "Zajac", 1234567890));
            accounts.Add(new SavingAccounts(2,30M, "Marek", "Aaaa", 1234554321));
            accounts.Add(new SavingAccounts(3,4M, "Zzzz", "Bbb", 0987654321));
            accounts.Add(new BillingAcounts(4,13.9M, "Marek", "Zajac", 1234567890));
            accounts.Add(new BillingAcounts(5,0.0M, "Marek", "Aaaa", 1234554321));

            Printer printer = new Printer();

            foreach(Account element in accounts)
            {
                printer.Print(element);
            }

            Console.ReadKey();


        }

    }
}
