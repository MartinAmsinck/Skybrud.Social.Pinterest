using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Pinterest.Models.Common;

namespace Skybrud.Social.Pinterest.Models.Pins {

    /// <summary>
    /// Class representing the metadata of a pin.
    /// </summary>
    public class PinterestPinMetadata {

        #region Properties

        /// <summary>
        /// Gets information about the place the image or video of the pin was taken.
        /// </summary>
        public PinterestPlace Place { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestPinImage"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestPinMetadata(JObject obj) {
            Place = obj.GetObject("place", PinterestPlace.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPinMetadata"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPinMetadata"/>.</returns>
        public static PinterestPinMetadata Parse(JObject obj) {
            return obj == null ? null : new PinterestPinMetadata(obj);
        }

        #endregion

    }

}