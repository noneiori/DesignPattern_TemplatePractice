using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TemplatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Buy Sign Strategy");
            StrategyAlwayBuy strategyAlwayBuy = new StrategyAlwayBuy();
            strategyAlwayBuy.execute();
            Console.WriteLine("---");

            Console.WriteLine("Test Sell Sign Strategy");
            StrategyAlwaySell strategyAlwaySell = new StrategyAlwaySell();
            strategyAlwaySell.execute();
            Console.WriteLine("---");

            Console.WriteLine("Test Non-Sign Strategy");
            StrategyNonSign strategyNonSign = new StrategyNonSign();
            strategyNonSign.execute();
            Console.WriteLine("---");

            Console.Read();
        }
    }
}
