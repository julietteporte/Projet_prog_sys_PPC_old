using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_Projet.Service
{
    public abstract class People
    {
        public abstract void Wait();
        public abstract int Id { get; }
    }
}
