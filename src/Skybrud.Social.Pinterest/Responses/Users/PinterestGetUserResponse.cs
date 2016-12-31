using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Objects.Users.Http;

namespace Skybrud.Social.Pinterest.Responses.Users {

    /// <summary>
    /// Class representing a response from the Pinterest API with information about a single user.
    /// </summary>
    public class PinterestGetUserResponse : PinterestResponse<PinterestGetUserResponseBody> {
        
        #region Constructors

        private PinterestGetUserResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetUserResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetUserResponse"/>.</returns>
        public static PinterestGetUserResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");
            
            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new PinterestGetUserResponse(response) {
                Body = ParseJsonObject(response.Body, PinterestGetUserResponseBody.Parse)
            };

        }

        #endregion

    }

}