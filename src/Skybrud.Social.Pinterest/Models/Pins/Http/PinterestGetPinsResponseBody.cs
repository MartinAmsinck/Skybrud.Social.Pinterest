using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Pins.Http {

    /// <summary>
    /// Class representing the response body of a request to the Pinterest API for getting a collection Pinterest pins.
    /// </summary>
    public class PinterestGetPinsResponseBody : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets an array of <see cref="PinterestPin"/> representing the returned Pinterest pins.
        /// </summary>
        public PinterestPin[] Data { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestGetPinsResponseBody"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestGetPinsResponseBody(JObject obj) : base(obj) {
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

        /// <summary>
        /// Gets an instance of <see cref="PinterestGetPinsResponseBody"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="PinterestGetPinsResponseBody"/>.</returns>
        public static PinterestGetPinsResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetPinsResponseBody(obj);
        }

        #endregion

    }

}