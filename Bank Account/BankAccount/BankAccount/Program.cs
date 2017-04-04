using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account.Deposit(-50.5));
            Console.WriteLine(account.Withdraw(200));

            Console.ReadLine();
            
        }
    }
}
