using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Business.Mapper
{
    public static class MapperPeople
    {
        public static Data.DAO.People Map(People value)
        {
            return new Data.DAO.People
            {
                Id = value.Id, 
                Type = value.Type,
                Number = value.Number
            };
        }

        public static People Map(Data.DAO.People value)
        {
            return new People
            {
                Id = value.Id,
                Type = value.Type,
                Number = value.Number
            };
        }
        public static List<People> Map(List<Data.DAO.People> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}
