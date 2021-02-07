using System;
using System.Collections.Generic;

namespace BankOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalManager = new PersonalLoanManager();
            ILoanManager transportManager = new TransportLoanManager();
            ILoanManager mortgageManager = new MortgageLoanManage();
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalManager, new FileLoggerService(), new DatabaseLoggerService());

            List<ILoanManager> loans = new List<ILoanManager>() { personalManager, mortgageManager };
            applicationManager.LoanInfo(loans);
        }
    }
}
