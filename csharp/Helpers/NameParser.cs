using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.QualityUpdaters;

namespace csharp.Helpers
{
    public static class NameParser
    {
        // parameters

        private static string sulfurasSubstring = "sulfuras";
        private static string agedBrieSubstring = "aged brie";
        private static string backstagePassesSubstring = "backstage passes";

        // public methods

        #region GetQualityUpdaterForItem(Item item)
        public static QualityUpdater GetQualityUpdaterForItem(string name)
        {
            string nameLow = name.ToLower();
            if (nameLow.Contains(NameParser.sulfurasSubstring))
            {
                return new SulfurasQualityUpdater();
            }
            if (nameLow.Contains(NameParser.agedBrieSubstring))
            {
                return new AgedBrieQualityUpdater();
            }
            if (nameLow.Contains(NameParser.backstagePassesSubstring))
            {
                return new BackstagePassesQualityUpdater();
            }

            return new QualityUpdater();
        }
        #endregion

    }
}
