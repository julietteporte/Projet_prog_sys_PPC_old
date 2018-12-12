using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_Projet.Data.DAO
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrepTime { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
    }
}
