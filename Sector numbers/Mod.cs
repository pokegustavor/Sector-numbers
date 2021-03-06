using PulsarModLoader;

namespace Sector_numbers
{
    public class Mod : PulsarMod
    {
        public override string Version => "1.0";

        public override string Author => "pokegustavo ";

        public override string ShortDescription => "Makes all sectors have the ID number";

        public override string Name => "Sector Numbers";

        public override string HarmonyIdentifier()
        {
            return "pokegustavo.Sector_Numbers";
        }
    }
}
