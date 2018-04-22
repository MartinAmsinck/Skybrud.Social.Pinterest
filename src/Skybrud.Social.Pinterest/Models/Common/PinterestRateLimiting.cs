using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Pinterest.Models.Common {
    
    /// <summary>
    /// Class with rate-limiting information about a response from the Pinterest API.
    /// </summary>
    public class PinterestRateLimiting {

        #region Properties

        /// <summary>
        /// Gets the total number of calls allowed within the current 1-hour window.
        /// </summary>
        public int Limit { get; }

        /// <summary>
        /// Gets the remaining number of calls available to your app within the current 1-hour window.
        /// </summary>
        public int Remaining { get; }

        #endregion

        #region Constructors

        private PinterestRateLimiting(int limit, int remaining) {
            Limit = limit;
            Remaining = remaining;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses rate-limiting information from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response that holds the rate-limiting information.</param>
        /// <returns>Returns an instance of <see cref="PinterestRateLimiting"/>.</returns>
        public static PinterestRateLimiting GetFromResponse(SocialHttpResponse response) {
            if (!Int32.TryParse(response.Headers["X-Ratelimit-Limit"] ?? "", out int limit)) limit = -1;
            if (!Int32.TryParse(response.Headers["X-Ratelimit-Remaining"] ?? "", out int remaining)) remaining = -1;
            return new PinterestRateLimiting(limit, remaining);
        }

        #endregion

    }

}