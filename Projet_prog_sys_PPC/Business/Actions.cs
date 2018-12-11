using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_prog_sys_PPC.Business
{
    public class Actions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public People People { get; set; }

    }
}
