using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_Projet.Service
{
    public class NormalStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime;
        }
    }
}
