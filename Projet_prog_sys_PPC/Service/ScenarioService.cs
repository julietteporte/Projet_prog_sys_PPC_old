using Projet_prog_sys_PPC.Business.Mapper;
using Projet_prog_sys_PPC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Service
{
    public class ScenarioService
    {
        ProjetContext context;

        public ScenarioService()
        {
            context = new ProjetContext();
        }

        public void Add(Business.Scenario business)
        {
            var entity = MapperScenario.Map(business);
            context.Scenario.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = (from c in context.Scenario where c.Id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Scenario.Remove(entity);
                context.SaveChanges();
            }

        }
        public void Update(Business.Scenario business)
        {
            var entity = (from c in context.Scenario where c.Id == business.Id select c).FirstOrDefault();
            entity.Name = business.Name;
            context.SaveChanges();
        }

        public List<Business.Scenario> Select()
        {
            return (from c in context.Scenario select MapperScenario.Map(c)).ToList();

        }
    }
}
