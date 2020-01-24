using System;
using System.Collections.Generic;
using System.Text;

namespace Prototip_projet2
{
    class Clients
    {
        private string _name;
        private int _password;
        private Accounts _account;

        public Clients(string name, int password)
        {
            _name = name;
            _password = password;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetPassword()
        {
            return _password;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetPassword(int password)
        {
            _password = password;
        }
        public Accounts CreateAccount()
        {
            Accounts accounts = new Accounts(this);
            return accounts;
        }

        public static void EnterClientAccount(string name)
        {
            Console.WriteLine("{0}, welcome on your personal account", name);
            Console.WriteLine("What operation do you want to do ?");
            string option = Console.ReadLine();
            Operation(option);
        }

        public static void Operation(string operation)
        {
            if (operation == "TransferMoney")
            {
                Console.Write("Enter account id: ");
                int accountId =  Convert.ToInt32(Console.ReadLine());
                

                Console.Write("Enter credit account: ");

                Console.Write("Enter the amount to transfer: ");
            }
        }
    }
}
