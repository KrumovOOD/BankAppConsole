using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic test = new Logic();
            test.DepositFunds(10.00);
            test.WithDrawFunds(500);
            test.CurrentBalance();
            test.CurrentBalance();

        }
    }
}
