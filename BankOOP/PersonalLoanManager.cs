using System;
using System.Collections.Generic;
using System.Text;

namespace BankOOP
{
    class PersonalLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
