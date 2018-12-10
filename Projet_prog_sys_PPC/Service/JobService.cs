using Projet_prog_sys_PPC.Business.Mapper;
using Projet_prog_sys_PPC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Service
{
    public class JobService
    {
        ProjetContext context;

        public JobService()
        {
            context = new ProjetContext();
        }

        public void Add(Business.Job business)
        {
            var entity = MapperJob.Map(business);
            context.Job.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = (from c in context.Job where c.Id == id select c).FirstOrDefault();
            if (entity != null)
            {
                context.Job.Remove(entity);
                context.SaveChanges();
            }

        }
        public void Update(Business.Job business)
        {
            var entity = (from c in context.Job where c.Id == business.Id select c).FirstOrDefault();
            entity.Type = business.Type;
            context.SaveChanges();
        }

        public List<Business.Job> Select()
        {
            return (from c in context.Job select MapperJob.Map(c)).ToList();

        }
    }
}
