﻿using TapSDK.Review.Internal;

namespace TapSDK.Review
{
    public class TapTapReview
    {

        public static readonly string Version = "4.5.1-beta.2";

        public static void OpenReview()
        {
            TapTapReviewInner.OpenReview();
        }
    }
}
