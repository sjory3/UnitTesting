using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public static class Validate
    {
        public static bool ValidatePin(uint testPin)
        {
            uint pin = 1234;
            if (testPin < 999 || testPin > 9999)
            {
                return false;
            }
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
