using TapSDK.Review.Internal;

namespace TapSDK.Review
{
    public class TapTapReview
    {

        public static readonly string Version = "4.7.0-alpha.14";

        public static void OpenReview()
        {
            TapTapReviewInner.OpenReview();
        }
    }
}
