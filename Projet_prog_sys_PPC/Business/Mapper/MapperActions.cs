using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Business.Mapper
{
    public static class MapperActions
    {
        public static Data.DAO.Actions Map(Actions value)
        {
            return new Data.DAO.Actions
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description
            };
        }


        public static Actions Map(Data.DAO.Actions value)
        {
            return new Actions
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                Job = value.Job != null ? MapperJob.Map(value.Job) : null
            };
        }
        public static List<Actions> Map(List<Data.DAO.Actions> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}
