using System;
using CommandLine;

namespace Prototip_projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Clients Julie = new Clients("Julie", 1234);
            Clients Jule = new Clients("Jule", 1234);

            Julie.CreateAccount();
            Julie.CreateAccount();

            Jule.CreateAccount();
            Jule.CreateAccount();
 
            Accounts JuleAccount = new Accounts(Jule);

            Transaction.Withdraw(JuleAccount, 300);*/

            CommandLine.Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions);
        }

        class Options
        {
            [Option ('n', "name", Required = true, HelpText = "Enter client name.")]
            public string Name { get; set; }

            [Option ('p', "password", Required = true, HelpText = "Set password.")]
            public int Password { get; set; }

            [Option ('a', "amount", Required = true, HelpText = "Set the amount of money on the first client account.")]
            public double AmountClientOne { get; set; }

            [Option ('o', "otherClient", Required = false, HelpText = "Enter name of another client.")]
            public string Name2 { get; set; }

            [Option('s', "setAmount", Required = true, HelpText = "Set the amount of money on the second client account.")]
            public double AmountClientTwo { get; set; }

            [Option ('w', "withdraw", Required = false, HelpText = "If you wish to withdraw som cash.")]
            public bool IsWithdraw { get; set; }

            [Option ('t', "transfer", Required =false, HelpText = "If you wish to transfer your money somewhere!")]
            public bool IsTransfer { get; set; }
        }

        static void RunOptions(Options options)
        {
            Clients clientOne = new Clients(options.Name, options.Password);
            Accounts clientOneAccount = new Accounts(clientOne);
            clientOneAccount.SetAmount(options.AmountClientOne);

            Clients clientTwo = new Clients(options.Name2, options.Password);
            Accounts clientTwoAccount = new Accounts(clientTwo);
            clientTwoAccount.SetAmount(options.AmountClientTwo);

            
            if (options.IsWithdraw)
            {
                Console.Write("Write the amount of money to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Transaction.Withdraw(clientOneAccount, amount);
            }

            if (options.IsTransfer)
            {
                Console.Write("Write the amount of money to transfer: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Transaction.MoneyTransfer(clientOneAccount, clientTwoAccount, amount);
            }

        }
    }

}
