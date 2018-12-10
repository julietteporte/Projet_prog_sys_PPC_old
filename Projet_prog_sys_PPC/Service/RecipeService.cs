using Projet_prog_sys_PPC.Business.Mapper;
using Projet_prog_sys_PPC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Service
{
    public class RecipeService
    {
        ProjetContext context;

        public RecipeService()
        {
            context = new ProjetContext();
        }

        public void Add(Business.Recipe business)
        {
            var entity = MapperRecipe.Map(business);
            context.Recipe.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = (from c in context.Recipe where c.Id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Recipe.Remove(entity);
                context.SaveChanges();
            }

        }
        public void Update(Business.Recipe business)
        {
            var entity = (from c in context.Recipe where c.Id == business.Id select c).FirstOrDefault();
            entity.Name = business.Name;
            context.SaveChanges();
        }

        public List<Business.Recipe> Select()
        {
            return (from c in context.Recipe select MapperRecipe.Map(c)).ToList();
        }
    }
}
