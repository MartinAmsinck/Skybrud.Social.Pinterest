using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Users.Http;

namespace Skybrud.Social.Pinterest.Responses.Users {

    /// <summary>
    /// Class representing a response from the Pinterest API with information about a single user.
    /// </summary>
    public class PinterestGetUserResponse : PinterestResponse<PinterestGetUserResponseBody> {
        
        #region Constructors

        private PinterestGetUserResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestGetUserResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetUserResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetUserResponse"/>.</returns>
        public static PinterestGetUserResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestGetUserResponse(response);
        }

        #endregion

    }

}