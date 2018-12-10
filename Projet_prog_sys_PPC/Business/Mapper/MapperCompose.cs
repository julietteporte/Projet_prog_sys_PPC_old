using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_prog_sys_PPC.Business.Mapper
{
    public static class MapperCompose
    {
        public static Data.DAO.Compose Map(Compose value)
        {
            return new Data.DAO.Compose
            {
                Id = value.Id
            };
        }


        public static Compose Map(Data.DAO.Compose value)
        {
            return new Compose
            {
                Id = value.Id,
                Scenario = value.Scenario != null ? MapperScenario.Map(value.Scenario) : null
            };
        }
        public static List<Compose> Map(List<Data.DAO.Compose> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}
