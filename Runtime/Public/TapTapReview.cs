﻿using TapSDK.Review.Internal;

namespace TapSDK.Review
{
    public class TapTapReview
    {

        public static readonly string Version = "4.5.9";

        public static void OpenReview()
        {
            TapTapReviewInner.OpenReview();
        }
    }
}
