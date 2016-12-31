using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Pinterest.Objects.Common;

namespace Skybrud.Social.Pinterest.Objects.Pins {

    /// <summary>
    /// Class representing the metadata of a pin.
    /// </summary>
    public class PinterestPinMetadata {

        #region Properties

        /// <summary>
        /// Gets information about the place the image or video of the pin was taken.
        /// </summary>
        public PinterestPlace Place { get; private set; }

        #endregion

        #region Constructors

        private PinterestPinMetadata(JObject obj) {
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