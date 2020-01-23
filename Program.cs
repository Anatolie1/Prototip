using System;

namespace Prototip_projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients Julie = new Clients("Julie", 1234);
            Clients Jule = new Clients("Jule", 1234);

            Julie.CreateAccount();
            Julie.CreateAccount();

            Jule.CreateAccount();
            Jule.CreateAccount();


        }
    }

}
