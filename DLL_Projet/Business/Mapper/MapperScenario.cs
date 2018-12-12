﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Business.Mapper
{
    public static class MapperScenario
    {
        public static Data.DAO.Scenario Map(Scenario value)
        {
            return new Data.DAO.Scenario
            {
                Id = value.Id,
                Name = value.Name
            };
        }

        public static Scenario Map(Data.DAO.Scenario value)
        {
            return new Scenario
            {
                Id = value.Id,
                Name = value.Name
            };
        }
        public static List<Scenario> Map(List<Data.DAO.Scenario> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}
