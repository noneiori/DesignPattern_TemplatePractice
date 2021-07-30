using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TemplatePractice
{
    class StrategyAlwaySell : Strategy
    {
        protected override TradeSign CheckSign()
        {
            Console.WriteLine("Send Sell Sign");
            return TradeSign.Sell;
        }
    }
}
