using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Authentication;

namespace Skybrud.Social.Pinterest.Responses.Authentication {

    /// <summary>
    /// Class representing the response of a request to the Pinterest API for authenticating a user.
    /// </summary>
    public class PinterestTokenResponse : PinterestResponse<PinterestToken> {
        
        #region Constructors

        private PinterestTokenResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestToken.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestTokenResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestTokenResponse"/>.</returns>
        public static PinterestTokenResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestTokenResponse(response);
        }

        #endregion

    }

}