using System;
using System.Collections.Generic;
using System.Text;

namespace Prototip_projet2
{
    public class Clients
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
        public void CreateAccount()
        {
            Accounts accounts = new Accounts(this);
        }
    }
}
