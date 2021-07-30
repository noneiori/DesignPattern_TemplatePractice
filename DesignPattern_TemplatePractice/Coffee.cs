﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_TemplatePractice
{
    public class Coffee: CaffeinBeverage
    {
        

        public override void AddCondiments()
        {
            Console.WriteLine("coffee: add sugar and milk");
        }

        

        public override void Brew()
        {
            Console.WriteLine("coffee: brew coffee grinds");
        }

        
    }
}
