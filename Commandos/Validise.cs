using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal static class Vailidise
    {
        public static string ligicSayName(string commanderRank, string name, string codename)
        {
            if (commanderRank == "GENERAL")
            {
                return name;
            }
            else if (commanderRank == "COLONEL")
            {
                return codename;
            }
            return "The information is classified and cannot be received.";

        }
    }

}
