using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Service
{
    public class SlowStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime * 2;
            
        }
    }
}
