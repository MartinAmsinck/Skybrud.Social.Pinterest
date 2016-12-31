using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Objects;

namespace Skybrud.Social.Pinterest.Exceptions {

    /// <summary>
    /// Class representing an exception based on an error from the Pinterest API.
    /// </summary>
    public class PinterestHttpException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>.
        /// </summary>
        public SocialHttpResponse Response { get; private set; }

        /// <summary>
        /// Gets a reference to an object with information about the error.
        /// </summary>
        public PinterestError Error { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new exception based on the specified <paramref name="response"/> and Pinterest <paramref name="error"/>.
        /// </summary>
        /// <param name="response">The response received from the Pinterest API.</param>
        /// <param name="error">The error message.</param>
        public PinterestHttpException(SocialHttpResponse response, PinterestError error) : base("The Pinterest API responded with an error (" + error.Message + ")") {
            Response = response;
            Error = error;
        }

        #endregion

    }

}