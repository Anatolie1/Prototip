using System;

namespace Prototip_projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentification.OpenApplication();

            Clients Julie = new Clients("Julie", 1234);
            Clients Jule = new Clients("Jule", 1234);

            Accounts JulieAccount1 = Julie.CreateAccount();
            Accounts JulieAccount2 = Julie.CreateAccount();

            Accounts JuleAccount1 = Jule.CreateAccount();
            Accounts JuleAccount2 = Jule.CreateAccount();

            //Accounts accounts = new Accounts(Jule);
            JuleAccount1.SetAmount(3000);
            JuleAccount2.SetAmount(6000);
            JulieAccount1.SetAmount(8000);
            JulieAccount2.SetAmount(2000);


            Transaction.MoneyTransfer(JuleAccount1, JulieAccount1, 100);
            Transaction.Withdraw(JulieAccount2, 500);


        }
    }

}
