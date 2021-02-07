using System;
using System.Collections.Generic;
using System.Text;

namespace BankOOP
{
    class TransportLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
