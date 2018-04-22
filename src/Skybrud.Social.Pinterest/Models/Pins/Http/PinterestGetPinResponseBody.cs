using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Pins.Http {

    /// <summary>
    /// Class representing the response body of a request to the Pinterest API for getting information about a single Pinterest pin.
    /// </summary>
    public class PinterestGetPinResponseBody : PinterestObject {

        #region Properties
        
        /// <summary>
        /// Gets a reference to the pin.
        /// </summary>
        public PinterestPin Data { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestGetPinResponseBody"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestGetPinResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestPin.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="PinterestGetPinResponseBody"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="PinterestGetPinResponseBody"/>.</returns>
        public static PinterestGetPinResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetPinResponseBody(obj);
        }

        #endregion

    }

}