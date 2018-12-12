using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_prog_sys_PPC.Model
{
    public interface IMobile
    {

        Square ActualSquare { get; set; }

        Table ActualTable { get; set; }

        /// <summary>
        /// @return
        /// </summary>
        void Move(Square newSquare, Table newTable);
    }
}
