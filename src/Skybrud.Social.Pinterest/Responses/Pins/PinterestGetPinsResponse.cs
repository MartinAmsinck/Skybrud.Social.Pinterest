using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Pinterest.Objects;
using Skybrud.Social.Pinterest.Objects.Pins;

namespace Skybrud.Social.Pinterest.Responses.Pins {
    
    public class PinterestGetPinsResponse : PinterestResponse<PinterestGetPinsResponseBody> {
        
        #region Constructors

        private PinterestGetPinsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>PinterestGetPinsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <code>PinterestGetPinsResponse</code>.</returns>
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

    public class PinterestGetPinsResponseBody : PinterestObject {

        #region Properties

        public PinterestPin[] Data { get; private set; }

        #endregion

        #region Constructors

        private PinterestGetPinsResponseBody(JObject obj) : base(obj) {
            Data = obj.GetArray("data", PinterestPin.Parse);
/*
  "page": {
    "cursor": null,
    "next": null
  }
*/
        }

        #endregion

        #region Static methods

        public static PinterestGetPinsResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetPinsResponseBody(obj);
        }

        #endregion

    }

}