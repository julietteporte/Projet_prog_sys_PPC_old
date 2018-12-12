using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public class Cook
    {

        Recipe recipe = new Recipe();
        public int Id;
        public bool HaveToCook;
        public bool IsAvailable;

        public Cook()
        {
            
        }
        
        public void Cooking(Recipe recipe)
        {
            if ( HaveToCook == true && IsAvailable == true )
            {
                var timeCook = recipe.TimePrepare;
                var name = recipe.RecipeName;
                Console.WriteLine("Plat finit : " + name + ", Temps : " + timeCook);
            } else Console.WriteLine("Cuisinier occupé tmtc");
        }
    }
}
