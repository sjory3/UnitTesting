using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public static class Withdraw
    {
        public static double WithdrawMoney(double ammount)
        {
            if (ammount < 0)
            {
                return Account.balance;
            }
            if (ammount <= Account.balance)
            {
                return Account.balance - ammount;
            }
            else if (ammount > Account.balance && Account.overDraw == true)
            {
                return Account.balance - ammount;
            }
            else
            {
                return Account.balance;
            }
        }
    }
}
