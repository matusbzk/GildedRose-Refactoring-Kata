using System.Collections.Generic;
using System.Linq;
using csharp.QualityUpdaters;

namespace csharp
{
    public class GildedRose
    {
        // parameters
        IList<Item> Items;

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
            BasicQualityUpdater qualityUpdater = null;

            if (item.Name.ToLower().Contains("sulfuras"))
            {
                qualityUpdater = new SulfurasQualityUpdater();
            }

            qualityUpdater = qualityUpdater ?? new BasicQualityUpdater();
            return qualityUpdater.UpdateQuality(item);
        }
        #endregion

    }
}
