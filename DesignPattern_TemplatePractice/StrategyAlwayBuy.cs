using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TemplatePractice
{
    class StrategyAlwayBuy : Strategy
    {
        protected override TradeSign CheckSign()
        {
            Console.WriteLine("Send Buy Sign");
            return TradeSign.Buy;
        }
    }
}
