﻿using TapSDK.Review.Internal;

namespace TapSDK.Review
{
    public class TapTapReview
    {

        public static readonly string Version = "4.6.1-beta.3";

        public static void OpenReview()
        {
            TapTapReviewInner.OpenReview();
        }
    }
}
