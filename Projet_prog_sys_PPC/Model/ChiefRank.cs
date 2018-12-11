using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    class ChiefRank : People
    {
        Table table = new Table();
        public ChiefRank()
        {

        }

        public int nbrOrder;

        // Méthode dresser, faire passer le booléan de la Table "IsDressed" en true
        public void Dress()
        {
            if (table.IsCleaned == false)
            {
                Console.WriteLine("Table nettoyée");
                table.IsCleaned = true;
            } else if (table.IsDressed == true)
            {
                //rien
            }
            else table.IsDressed = true;
        }

        //Méthode Distribuer le menu
        public void GiveMenu()
        {
            // TODO implement here
        }

        //Méthode Prendre commande
        public void TakeOrder()
        {
            // TODO implement here
        }
    }
}
