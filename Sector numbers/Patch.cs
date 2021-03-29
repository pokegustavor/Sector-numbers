using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace Sector_numbers
{
    [HarmonyPatch(typeof(PLGalaxy), "Update")]
    class Patch
    {
        static void Postfix(PLGalaxy __instance)
        {
            foreach (PLSectorInfo sector in __instance.AllSectorInfos.Values)
            {
                int test;
                bool vai = false;
                if (int.TryParse(sector.Name, out test))
                {
                    vai = true;
                }
                if (!vai && !sector.Name.Contains("("))
                {
                    sector.Name = sector.Name + " (" + sector.ID + ")";
                }
            }
        }
    }
}
