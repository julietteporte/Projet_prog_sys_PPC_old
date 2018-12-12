using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Service
{
    public class Menu
    {
        public List<Recipe> Recipes { get; set; }

        /// <summary>
        /// Implementation Singleton
        /// </summary>

        private static Menu instance;
        private Menu()
        {

        }

        public static Menu getInstance()
        {
            if (instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }

        
    }
}
