using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Pinterest.Objects;
using Skybrud.Social.Pinterest.Objects.Pins;
using Skybrud.Social.Pinterest.Objects.Pins.Http;

namespace Skybrud.Social.Pinterest.Responses.Pins {

    /// <summary>
    /// Class representing a response from the Pinterest API with information about a single pin.
    /// </summary>
    public class PinterestGetPinResponse : PinterestResponse<PinterestGetPinResponseBody> {
        
        #region Constructors

        private PinterestGetPinResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetPinResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetPinResponse"/>.</returns>
        public static PinterestGetPinResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");
            
            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new PinterestGetPinResponse(response) {
                Body = ParseJsonObject(response.Body, PinterestGetPinResponseBody.Parse)
            };

        }

        #endregion

    }

}