using System;
using System.Collections.Generic;
using System.Text;

namespace Prototip_projet2
{
    class Accounts
    {
        private Clients _client;
        private int _accountId;
        private double _amount;
        private static int idCounter = 1;

        public Accounts(Clients client)
        {
            _client = client;
            _accountId = idCounter;
            idCounter++;
        }
        public double GetAmount()
        {
            return _amount;
        }
        public void SetAmount(double amount)
        {
            _amount = amount;
        }

        public int GetAccountId()
        {
            return _accountId;
        }
    }
}
