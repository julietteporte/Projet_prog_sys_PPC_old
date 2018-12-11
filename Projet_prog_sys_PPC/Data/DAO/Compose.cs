using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Projet_prog_sys_PPC.Data.DAO
{
    public class Compose
    {
        public int Id { get; set; }
        [Key]
        public virtual Actions Actions { get; set; }
        public int Id_Scenario { get; set; }
        [Key]
        public virtual Scenario Scenario { get; set; }
    }
}
