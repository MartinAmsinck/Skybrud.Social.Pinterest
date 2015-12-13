using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Social.Json.Extensions.JObject;
using Skybrud.Social.Pinterest.Objects;
using Skybrud.Social.Pinterest.Objects.Pins;

namespace Skybrud.Social.Pinterest.Responses.Pins {
    
    public class PinterestGetPinResponse : PinterestResponse<PinterestGetPinResponseBody> {
        
        #region Constructors

        private PinterestGetPinResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>PinterestGetPinResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <code>PinterestGetPinResponse</code>.</returns>
        public static PinterestGetPinResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");
            
            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new PinterestGetPinResponse(response) {
                Body = SocialUtils.ParseJsonObject(response.Body, PinterestGetPinResponseBody.Parse)
            };

        }

        #endregion

    }

    public class PinterestGetPinResponseBody : PinterestObject {

        #region Properties

        public PinterestPin Data { get; private set; }

        #endregion

        #region Constructors

        private PinterestGetPinResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestPin.Parse);
        }

        #endregion

        #region Static methods

        public static PinterestGetPinResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetPinResponseBody(obj);
        }

        #endregion

    }

}