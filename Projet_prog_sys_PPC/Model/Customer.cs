using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    
    //DP Strategy

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
            firstCustomer.Eat(40);
            firstCustomer.Pay();

        }
    }

    interface IPresenceStrategy
    {
        int GetPresenceTime(int PresenceTime);
    }

    class SlowStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime * 2;
        }
    }

    class NormalStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime;
        }
    }

    class FastStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime / 2;
        }
    }

    //Classe Customer

    class Customer : People
    {
        public IPresenceStrategy Strategy { get; set; }
        this.Strategy = strategy;
        public bool IsReserved;
        public int NbrSatisfiedCustomer;
        public Table Table;
        private IList<string> order;
        private int presenceTime;
        
        Recipe recipe = new Recipe();

        public Customer(IPresenceStrategy strategy)
        {
            
        }


        public void Pay()
        {
            NbrSatisfiedCustomer++;
            var price = recipe.Price;
            HotelMaster.Instance.Wallet = HotelMaster.Instance.Wallet + price;
        }

        public void OrderMenu()
        {
            // TODO implement here
        }

        public void Eat(int PresenceTime)
        {
            presenceTime = Strategy.GetPresenceTime(presenceTime);
            Console.WriteLine("Temps passé à manger : " + presenceTime);
        }
    }
}
