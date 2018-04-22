using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Pins.Http;

namespace Skybrud.Social.Pinterest.Responses.Pins {

    /// <summary>
    /// Class representing the response of a request to the Pinterest API for getting information about a single Pinterest pin.
    /// </summary>
    public class PinterestGetPinResponse : PinterestResponse<PinterestGetPinResponseBody> {
        
        #region Constructors

        private PinterestGetPinResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestGetPinResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetPinResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetPinResponse"/>.</returns>
        public static PinterestGetPinResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestGetPinResponse(response);
        }

        #endregion

    }

}