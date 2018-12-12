using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Service
{
    public class Order
    {
        public int Id;
        public Table Table;
        public Customer Customer;
        int nbrOrderFinal;
        public List<Recipe> Recipes;

        public Order(Table table)
        {
            this.Table = table;
            this.Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

    }
}
