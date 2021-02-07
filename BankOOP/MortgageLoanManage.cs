using System;
using System.Collections.Generic;
using System.Text;

namespace BankOOP
{
    class MortgageLoanManage : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
