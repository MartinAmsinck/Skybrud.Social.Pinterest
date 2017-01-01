using System.Net;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Exceptions;
using Skybrud.Social.Pinterest.Objects;
using Skybrud.Social.Pinterest.Objects.Common;

namespace Skybrud.Social.Pinterest.Responses {

    /// <summary>
    /// Class representing a response from the Pinterest API.
    /// </summary>
    public abstract class PinterestResponse : SocialResponse {

        #region Properties

        /// <summary>
        /// Gets information about rate limiting.
        /// </summary>
        public PinterestRateLimiting RateLimiting { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        protected PinterestResponse(SocialHttpResponse response) : base(response) {
            RateLimiting = PinterestRateLimiting.GetFromResponse(response);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;
            if (response.StatusCode == HttpStatusCode.Created) return;

            // Parse the JSON response
            PinterestError error = ParseJsonObject(response.Body, PinterestError.Parse);

            // Throw the exception
            throw new PinterestHttpException(response, error);

        }

        #endregion

    }
    
    /// <summary>
    /// Class representing a response from the Pinterest API.
    /// </summary>
    public class PinterestResponse<T> : PinterestResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        protected PinterestResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }

}