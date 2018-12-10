using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Business.Mapper
{
    public static class MapperJob
    {
        public static Data.DAO.Job Map(Job value)
        {
            return new Data.DAO.Job
            {
                Id = value.Id,
                Type = value.Type,
                Number = value.Number
            };
        }

        public static Job Map(Data.DAO.Job value)
        {
            return new Job
            {
                Id = value.Id,
                Type = value.Type,
                Number = value.Number
            };
        }
        public static List<Job> Map(List<Data.DAO.Job> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}
