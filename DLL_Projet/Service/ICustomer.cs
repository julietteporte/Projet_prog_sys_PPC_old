using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Service
{
    public interface IPresenceStrategy
    {
        int GetPresenceTime(int PresenceTime);
    }
}
