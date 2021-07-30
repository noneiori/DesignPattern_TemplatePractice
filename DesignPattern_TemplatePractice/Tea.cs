using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_TemplatePractice
{
    public class Tea: CaffeinBeverage
    {
       
        public override void AddCondiments()
        {
            Console.WriteLine("tea: add lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("tea: steep the tea");
        }
    }
}
