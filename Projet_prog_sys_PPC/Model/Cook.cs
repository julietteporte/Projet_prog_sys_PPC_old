using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    class Cook
    {

        Recipe recipe = new Recipe();
        public int Id;
        public bool haveToCook;
        public bool IsAvailable;

        public Cook()
        {
            
        }
        
        public void Cooking()
        {
            if ( haveToCook == true && IsAvailable == true )
            {
                var timeCook = recipe.TimePrepare;
                var name = recipe.NameRecipe;
                Console.WriteLine("Plat finit : " + name + ", Temps : " + timeCook);
            } else Console.WriteLine("Cuisinier occupé tmtc");
        }
    }
}
