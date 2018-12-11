using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public class Table
    {

        public Table()
        {
        }

        public void Id;

        public int Capacity;

        public bool IsAvailable;

        public list<Order> Order;

        public bool IsCleaned;

        public int nbrOccupiedTable;
    }
}
