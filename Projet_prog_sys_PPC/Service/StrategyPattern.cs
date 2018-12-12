using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public class StrategyPattern
    {
        public static void Main(String[] args)
        {
            //Préparation des stratégies
            IPresenceStrategy slowStrategy = new SlowStrategy();
            IPresenceStrategy fastStrategy = new FastStrategy();
            IPresenceStrategy normalStrategy = new NormalStrategy();

            Customer firstCustomer = new Customer(slowStrategy);
            firstCustomer.Strategy = fastStrategy;
            //firstCustomer.Eat(40);
            //firstCustomer.Pay();

        }
    }
}
