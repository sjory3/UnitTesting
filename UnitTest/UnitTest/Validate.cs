using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public static class Validate
    {
        public static bool ValidatePin(int testPin)
        {
            int pin = 1234;

            if (testPin == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
