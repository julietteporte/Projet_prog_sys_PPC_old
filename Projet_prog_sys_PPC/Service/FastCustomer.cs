using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public class FastStrategy : IPresenceStrategy
    {
        public int GetPresenceTime(int presenceTime)
        {
            return presenceTime / 2;
        }
    }
}
