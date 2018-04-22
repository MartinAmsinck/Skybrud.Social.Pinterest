using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Pins.Http;

namespace Skybrud.Social.Pinterest.Responses.Pins {

    /// <summary>
    /// Class representing the response of a request to the Pinterest API for getting a collection of Pinterest pins.
    /// </summary>
    public class PinterestGetPinsResponse : PinterestResponse<PinterestGetPinsResponseBody> {
        
        #region Constructors

        private PinterestGetPinsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestGetPinsResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetPinsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetPinsResponse"/>.</returns>
        public static PinterestGetPinsResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestGetPinsResponse(response);
        }

        #endregion

    }

}