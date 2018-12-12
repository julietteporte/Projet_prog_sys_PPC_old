using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public class NormalStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime;
        }
    }
}
