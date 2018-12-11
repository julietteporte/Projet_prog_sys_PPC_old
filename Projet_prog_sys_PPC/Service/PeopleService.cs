using Projet_prog_sys_PPC.Business.Mapper;
using Projet_prog_sys_PPC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Service
{
    public class PeopleService
    {
        ProjetContext context;

        public PeopleService()
        {
            context = new ProjetContext();
        }

        public void Add(Business.People business)
        {
            var entity = MapperPeople.Map(business);
            context.People.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = (from c in context.People where c.Id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.People.Remove(entity);
                context.SaveChanges();
            }

        }
        public void Update(Business.People business)
        {
            var entity = (from c in context.People where c.Id == business.Id select c).FirstOrDefault();
            entity.Type = business.Type;
            context.SaveChanges();
        }

        public List<Business.People> Select()
        {
            return (from c in context.People select MapperPeople.Map(c)).ToList();

        }
    }
}
