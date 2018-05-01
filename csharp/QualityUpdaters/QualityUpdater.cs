
namespace csharp.QualityUpdaters
{
    public class QualityUpdater
    {
        // parameters
        #region SellInDecrease
        protected virtual int SellInDecrease => 1;
        #endregion

        #region QualityDifference
        protected virtual int QualityDifference => 1;
        #endregion

        #region QualityDifferenceMultiplier
        /**
         * Once the sell by date has passed, Quality degrades twice as fast
         */
        protected virtual int QualityDifferenceMultiplier { get; set; } = 1;
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
        public virtual Item UpdateQuality(Item item)
        {
            item.SellIn -= SellInDecrease;
            this.QualityDifferenceMultiplier *= item.SellIn > 0 ? 1 : 2;
            this.QualityDifferenceMultiplier *= item.Name.ToLower().Contains("conjured") ? 2 : 1;
            item.Quality += QualityDifference * QualityDecreaseMultiplier * QualityDifferenceMultiplier;
            item.Quality = this.CheckMinMax(item.Quality);

            return item;
        }

        // protected methods

        #region CheckMinMax(int quality)
        /**
         * Checks whether quality is in given range and modifies it if it's not
         */
        protected int CheckMinMax(int quality)
        {
            return quality > MaxQuality
                ? MaxQuality
                : quality < MinQuality
                    ? MinQuality
                    : quality;
        }
        #endregion

    }
}
