using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TemplatePractice
{
    class StrategyNonSign : Strategy
    {
        protected override TradeSign CheckSign()
        {
            Console.WriteLine("No sign to send");
            return TradeSign.NonSign;
        }
    }
}
