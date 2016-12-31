using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Objects.Pins.Http;

namespace Skybrud.Social.Pinterest.Responses.Pins {

    /// <summary>
    /// Class representing a response from the Pinterest API with a list of pins.
    /// </summary>
    public class PinterestGetPinsResponse : PinterestResponse<PinterestGetPinsResponseBody> {
        
        #region Constructors

        private PinterestGetPinsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetPinsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetPinsResponse"/>.</returns>
        public static PinterestGetPinsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");
            
            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new PinterestGetPinsResponse(response) {
                Body = ParseJsonObject(response.Body, PinterestGetPinsResponseBody.Parse)
            };

        }

        #endregion

    }

}