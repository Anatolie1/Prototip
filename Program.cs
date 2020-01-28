using System;
using System.Collections.Generic;
using CommandLine;


namespace Project_2
{
    class Program
    {
        [Verb("login", HelpText = "authentification")]
        class LoginOptions
        {
            [Option('u', "username", Required = true, HelpText = "enter your username")]
            public string Username { get; set; }

            [Option('p', "password", Required = true, HelpText = "enter your password")]
            public string Password { get; set; }
        }

        [Verb("operation", HelpText = "money movment")]
        class OpsOptions
        {
            [Option('t', "transfer", HelpText = "money transfer")]
            public bool Transfer { get; set; }
            [Option('w', "withdraw", HelpText = "Withdraw money")]
            public bool Withdraw { get; set; }
        }
        [Verb("Account", HelpText = "Account managment")]
        class AccountOptions
        {
            [Option('c', "create", HelpText = "Create account")]
            public bool CreateAccount { get; set; }

            [Option('d', "delete", HelpText = "Delete Account")]
            public bool DeleteAccount { get; set; }

        }
        class Options
        {
            [Option('i', "informations", HelpText = "Get informations on your accounts")]
            public bool GetInfo { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<LoginOptions, OpsOptions, AccountOptions, Options>(args)
            .WithParsed<LoginOptions>(RunLoginOptions)
            .WithParsed<OpsOptions>(RunOpsOptions)
            .WithParsed<AccountOptions>(RunAccountOptions)
            .WithParsed<Options>(RunOptions);

        }

        static void RunOptions(Options options)
        {
            if (options.GetInfo)
            {
                Console.WriteLine("Your current account situation : ");
                // metohde
            }
        }

        static void RunLoginOptions(LoginOptions options)
        {
            Console.WriteLine("Your log");
            //use foreach + DB
        }
        static void RunOpsOptions(OpsOptions options)
        {
            if (options.Transfer)
            {
                Console.WriteLine("Transfer of your money");
                // implement transfer method
            }
            if (options.Withdraw)
            {
                Console.WriteLine("Withdraw");
            }
        }
        static void RunAccountOptions(AccountOptions options)
        {
            if (options.CreateAccount)
            {
                Console.WriteLine("Create Account : ");
            }
            if (options.DeleteAccount)
            {
                Console.WriteLine("Delete Account : ");
            }
        }

    }
}