using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public class Recipe
    {
        public int Price;
        public string RecipeName;
        public List<string> Categories;
        public int TimePrepare;
        public List<Recipe> RecipeList;

        public Recipe(int price, string name, List<string> cat, int timePrepare)
        {
            this.Price = price;
            this.RecipeName = name;
            this.Categories = cat;
            this.TimePrepare = timePrepare;
        }

        public void AddRecipe()
        {

        }

        public void RemoveRecipe()
        {

        }
    }
}
