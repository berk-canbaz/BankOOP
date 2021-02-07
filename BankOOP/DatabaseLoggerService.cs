using System;
using System.Collections.Generic;
using System.Text;

namespace BankOOP
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
