using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int customerId, long accountNumber, string name, string status) 
            : base(customerId, accountNumber, name, status)
        {
        }

        public new void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0}!!",Name);
        }
    }
}
