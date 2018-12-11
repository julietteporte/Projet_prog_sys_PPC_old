using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    class CookChief : People
    {
        public CookChief()
        {
        }

        private static CookChief uniqueInstance;

        public list<Order> Orders;

        public int nbrDoneRecipe;

        private void Singleton()
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public static CookChief getInstance()
        {
            // TODO implement here
            return null;
        }

        public void CancelDish()
        {
            // TODO implement here
        }

        public void RegroupOrder()
        {
            // TODO implement here
        }

        public void OrderCook()
        {
            // TODO implement here
        }
    }
}
