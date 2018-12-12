using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Service
{
    public class Scenario
    {
        public int Id { get; set; }
        public int nbrCookChief { get; set; }
        public int nbrChiefRank { get; set; }
        public int nbrCustomer { get; set; }
        public int nbrSlowCustomer { get; set; }
        public int nbrFastCustomer { get; set; }
        public int nbrReservedCustomer { get; set; }
        public int nbrServer { get; set; }
        public int nbrTable { get; set; }

        public Scenario()
        {
            
        }
        
        public void SelectScenario()
        {
            // TODO implement here
        }
    }
}
