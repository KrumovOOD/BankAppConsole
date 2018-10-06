using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Logic
    {
        private double tempBalanceDeposit, tempBalanceWithdraw;

        public void CurrentBalance()
        {
            if (tempBalanceWithdraw == 0)
            {
                Console.WriteLine("Your Balance now : " + tempBalanceDeposit);
            }
            else
                Console.WriteLine("Your Balance now : " + tempBalanceWithdraw);
        }
        public void DepositFunds(double desiredValueToDeposit)
        {
            Acc a = new Acc();
            desiredValueToDeposit = desiredValueToDeposit + a.balance;
            Console.WriteLine("You just deposited : " + desiredValueToDeposit);
            tempBalanceDeposit = desiredValueToDeposit;
        }
        public void WithDrawFunds(double DesiredValueToWithdraw)
        {

            Console.WriteLine("You just withdraw : " + DesiredValueToWithdraw);
            double NewCurrentBalance = ((tempBalanceDeposit) - (DesiredValueToWithdraw));
            tempBalanceWithdraw = NewCurrentBalance;
        }
    }
}
