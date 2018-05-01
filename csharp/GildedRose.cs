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
                .Select(BasicQualityUpdater.UpdateQuality)
                .ToList();
        }
        #endregion
    }
}
