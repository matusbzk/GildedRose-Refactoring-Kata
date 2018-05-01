
namespace csharp.QualityUpdaters
{
    public class BackstagePassesQualityUpdater : QualityUpdater
    {
        // parameters
        #region QualityDecreaseMultiplier
        /**
         * -1 if quality is decreasing
         *  1 if quality is increasing
         *  0 if quality is not changing
         */
        protected override int QualityDecreaseMultiplier => 1;
        #endregion

        // public methods
        public override Item UpdateQuality(Item item)
        {
            item.SellIn -= SellInDecrease;
            this.QualityDifferenceMultiplier *= item.SellIn > 10
                ? 1
                : item.SellIn > 5
                    ? 2
                    : item.SellIn > 0
                        ? 3
                        : 0;
            item.Quality += QualityDifference * QualityDecreaseMultiplier * QualityDifferenceMultiplier;
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            item.Quality = this.CheckMinMax(item.Quality);

            return item;
        }
    }
}
