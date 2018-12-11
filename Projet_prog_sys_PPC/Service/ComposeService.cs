using Projet_prog_sys_PPC.Business.Mapper;
using Projet_prog_sys_PPC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Projet_prog_sys_PPC.Service
{
    public class ComposeService
    {
        ProjetContext context;

        public ComposeService()
        {
            context = new ProjetContext();
        }

        public void Add(Business.Compose business)
        {
            var entity = MapperCompose.Map(business);
            context.Compose.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = (from p in context.Compose where p.Id == id select p).FirstOrDefault();
            if (entity != null)
            {
                context.Compose.Remove(entity);
                context.SaveChanges();
            }

        }
        /*public void Update(Business.Compose business)
        {
            var entity = (from p in context.Compose where p.Id == business.Id select p).FirstOrDefault();
            entity.Name = business.Name;
            context.SaveChanges();
        }*/
        public List<Business.Compose> Select()
        {
            return (from p in context.Compose.Include(i => i.Scenario).Include(i => i.Actions)
                    select MapperCompose.Map(p)).ToList();

        }
    }
}

