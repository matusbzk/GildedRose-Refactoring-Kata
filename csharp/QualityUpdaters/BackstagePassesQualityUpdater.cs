
namespace csharp.QualityUpdaters
{
    public sealed class BackstagePassesQualityUpdater : QualityUpdater
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

        // constructors
        public BackstagePassesQualityUpdater(Item item)
        {
            this.QualityDifferenceMultiplier = item.SellIn > 10
                ? 1
                : item.SellIn > 5
                    ? 2
                    : item.SellIn > 0
                        ? 3
                        : 0;
            if (item.SellIn <= 0)
            {
                this.MaxQuality = 0;
            }
        }
    }
}
