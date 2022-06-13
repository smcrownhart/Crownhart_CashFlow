using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_CashFlow
{
    internal interface ILedger
    {
        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }
    }
}
