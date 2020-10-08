using System.Globalization;

namespace ContaBancaria
{
    class BankAccount
    {
        public string _name;

        public int AccountNumber { get; set; }

        public double Balance { get; private set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public BankAccount(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            _name = name;
        }

        public BankAccount(int accountNumber, string name, double deposits) : this(accountNumber, name)
        {
            Balance = deposits;
        }

        public double Deposits(double money)
        {
            return Balance += money;
        }

        public double Withdraw(double money)
        {
            return Balance = (Balance - money) - 5;
        }

        public override string ToString()
        {
            return $"Conta {AccountNumber}, Titular: {_name}, Saldo: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
