using Projet_prog_sys_PPC.Business.Mapper;
using Projet_prog_sys_PPC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Projet_prog_sys_PPC.Service
{
    public class ActionsService
    {
        ProjetContext context;

        public ActionsService()
        {
            context = new ProjetContext();
        }

        public void Add(Business.Actions business)
        {
            var entity = MapperActions.Map(business);
            context.Actions.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = (from p in context.Actions where p.Id == id select p).FirstOrDefault();
            if (entity != null)
            {
                context.Actions.Remove(entity);
                context.SaveChanges();
            }

        }
        public void Update(Business.Actions business)
        {
            var entity = (from p in context.Actions where p.Id == business.Id select p).FirstOrDefault();
            entity.Name = business.Name;
            context.SaveChanges();
        }
        public List<Business.Actions> Select()
        {
            return (from p in context.Actions.Include(i => i.Job) select MapperActions.Map(p)).ToList();

        }
    }
}
