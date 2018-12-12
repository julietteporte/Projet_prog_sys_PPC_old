using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_Projet.Service
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
