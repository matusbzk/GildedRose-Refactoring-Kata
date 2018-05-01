
namespace csharp.QualityUpdaters
{
    public class BasicQualityUpdater
    {
        // parameters
        #region SellInDecrease
        protected virtual int SellInDecrease => 1;
        #endregion

        #region QualityDifference
        protected virtual int QualityDifference => 1;
        #endregion

        #region QualityDecreaseMultiplier
        /**
         * -1 if quality is decreasing
         *  1 if quality is increasing
         *  0 if quality is not changing
         */
        protected virtual int QualityDecreaseMultiplier => -1;
        #endregion

        #region MinQuality
        protected virtual int MinQuality => 0;
        #endregion

        #region MaxQuality
        protected virtual int MaxQuality => 50;
        #endregion

        // public methods
        public Item UpdateQuality(Item item)
        {
            item.SellIn -= SellInDecrease;
            item.Quality += QualityDifference * QualityDecreaseMultiplier * (item.SellIn > 0 ? 1 : 2);
            item.Quality = item.Quality > MaxQuality
                ? MaxQuality
                : item.Quality < MinQuality
                    ? MinQuality
                    : item.Quality;
                    

            //if (item.Name.ToLower().Contains("sulfuras"))
            //{
            //    return item;
            //}

            //item.SellIn -= sellInDecrease;

            //qualityDifference = item.Quality > 0 && item.Quality < 50 ? -1 : 0;

            //if (item.Name.ToLower().Contains("aged brie") || item.Name.ToLower().Contains("backstage passes"))
            //{
            //    qualityDifference *= -1;
            //}

            //if (item.Name.ToLower().Contains("backstage passes"))
            //{
            //    if (item.SellIn <= 0)
            //    {
            //        item.Quality = 0;
            //        return item;
            //    }

            //    if (item.SellIn < 11)
            //    {
            //        qualityDifference += 1;
            //    }

            //    if (item.SellIn < 6)
            //    {
            //        qualityDifference += 1;
            //    }
            //}

            //item.Quality += qualityDifference;

            //if (item.SellIn < 0)
            //{
            //    if (item.Name != "Aged Brie")
            //    {
            //        if (!item.Name.ToLower().Contains("backstagepasses"))
            //        {
            //            if (item.Quality > 0)
            //            {
            //                if (item.Name != "Sulfuras, Hand of Ragnaros")
            //                {
            //                    item.Quality = item.Quality - 1;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            item.Quality = 0;
            //        }
            //    }
            //    else
            //    {
            //        if (item.Quality < 50)
            //        {
            //            item.Quality = item.Quality + 1;
            //        }
            //    }
            //}

            return item;
        }
    }
}
