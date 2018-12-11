using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    class Table
    {

        public Table()
        {
        }

        public int Id;
        public int Capacity;
        public bool IsAvailable;
        public List<Order> Order;
        public bool IsCleaned;
        public int nbrOccupiedTable;

    }
}
