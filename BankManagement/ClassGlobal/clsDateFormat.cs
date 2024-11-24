using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.ClassGlobal
{
    public static class clsDateFormat
    {
        public static string DateToShort(DateTime d1)
        {
            return d1.ToString("dd/MMM/yyyy");
        }
    }
}
