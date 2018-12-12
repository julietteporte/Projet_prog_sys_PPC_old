using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Projet_prog_sys_PPC.Data.DAO
{
    public class Actions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id_People { get; set; }
        [ForeignKey("Id_People")]
        public virtual People People { get; set; }
        public int Time { get; set; }
    }
}
