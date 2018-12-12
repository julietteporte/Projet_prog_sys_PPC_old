using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_Projet.Service
{
    public class Square
    {

        public List<Table> ListTables { get; set; }

        public Square()
        {
            this.ListTables = new List<Table>();
        }
        
        public void AddTable(Table t)
        {
            this.ListTables.Add(t);
        }
        
        public void RemoveTable(Table t)
        {
            this.ListTables.Remove(t);
        }

    }
}
