using Projet_prog_sys_PPC.Service;
using System;

namespace Projet_prog_sys_PPC
{
    class Program
    {
        static void Main(string[] args)
        {
           var toto = new ScenarioService().Select();
            Console.ReadLine();
        }
    }
}
