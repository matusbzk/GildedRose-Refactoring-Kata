
namespace csharp.QualityUpdaters
{
    public class SulfurasQualityUpdater : QualityUpdater
    {
        // parameters
        #region SellInDecrease
        protected override int SellInDecrease => 0;
        #endregion

        #region QualityDecreaseMultiplier
        /**
         * -1 if quality is decreasing
         *  1 if quality is increasing
         *  0 if quality is not changing
         */
        protected override int QualityDecreaseMultiplier => 0;
        #endregion

        #region MinQuality
        protected override int MinQuality => 80;
        #endregion

        #region MaxQuality
        protected override int MaxQuality => 80;
        #endregion

    }
}
