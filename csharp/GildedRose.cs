using System.Collections.Generic;
using System.Linq;
using csharp.QualityUpdaters;

namespace csharp
{
    public class GildedRose
    {
        // parameters
        IList<Item> Items;

        private static string sulfurasSubstring = "sulfuras";
        private static string agedBrieSubstring = "aged brie";
        private static string backstagePassesSubstring = "backstage passes";

        // constructors
        #region GildedRose(IList<Item> Items)
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        #endregion


        // public methods
        #region UpdateQuality()
        public void UpdateQuality()
        {
            this.Items = this.Items
                .Select(this.UpdateQuality)
                .ToList();
        }
        #endregion

        // private methods
        #region UpdateQuality(Item item)
        /**
         * Updates quality and SellIn of a given item. 
         */
        private Item UpdateQuality(Item item)
        {
            QualityUpdater qualityUpdater = null;

            if (item.Name.ToLower().Contains(GildedRose.sulfurasSubstring))
            {
                qualityUpdater = new SulfurasQualityUpdater();
            }
            if (item.Name.ToLower().Contains(GildedRose.agedBrieSubstring))
            {
                qualityUpdater = qualityUpdater ?? new AgedBrieQualityUpdater();
            }
            if (item.Name.ToLower().Contains(GildedRose.backstagePassesSubstring))
            {
                qualityUpdater = qualityUpdater ?? new BackstagePassesQualityUpdater();
            }

            qualityUpdater = qualityUpdater ?? new QualityUpdater();
            return qualityUpdater.UpdateQuality(item);
        }
        #endregion

    }
}
