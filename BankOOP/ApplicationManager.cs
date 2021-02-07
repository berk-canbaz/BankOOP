using System;
using System.Collections.Generic;
using System.Text;

namespace BankOOP
{
    class ApplicationManager
    {
        public void MakeAnApplication(ILoanManager loanManager, params ILoggerService[] loggerServices)
        {
            loanManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void LoanInfo(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
