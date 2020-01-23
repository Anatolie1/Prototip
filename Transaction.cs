using System;
using System.Collections.Generic;
using System.Text;

namespace Prototip_projet2
{
    static class Transaction
    {
        private static double _amount;
        private static int _accountId;

        public static void Withdraw(Accounts accounts, double amount)
        {
            Console.WriteLine("there are : " + accounts.GetAmount() + " of money from account " + accounts.GetAccountId());
            double money = accounts.GetAmount() - amount;
            accounts.SetAmount(money);
            Console.WriteLine("there are : " + accounts.GetAmount() + " of money left");

        }

        public static void MoneyTransfer(Accounts DebitAccount, Accounts CreditAccount, double amount)
        {
            Console.WriteLine("Money on debit account before transfer: " + DebitAccount.GetAmount());
            Console.WriteLine("Money on credit account before transfer: " + CreditAccount.GetAmount());
            double money = DebitAccount.GetAmount() - amount;
            DebitAccount.SetAmount(money);
            CreditAccount.SetAmount(CreditAccount.GetAmount() + amount);
            Console.WriteLine("Money on debit account after transfer: " + DebitAccount.GetAmount());
            Console.WriteLine("Money on credit account after transfer: " + CreditAccount.GetAmount());

        }
    }
}
