using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DLL_Projet.Data.DAO
{
    public class Compose
    {
        public int Id_Actions { get; set; }
        [ForeignKey("Id_Actions")]
        public virtual Actions Actions { get; set; }

        public int Id_Scenario { get; set; }
        [ForeignKey("Id_Scenario")]
        public virtual Scenario Scenario { get; set; }
    }
}
