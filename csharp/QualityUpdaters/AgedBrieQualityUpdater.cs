
namespace csharp.QualityUpdaters
{
    public class AgedBrieQualityUpdater : QualityUpdater
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
    }
}
