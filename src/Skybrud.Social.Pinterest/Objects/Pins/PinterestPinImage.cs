using Newtonsoft.Json.Linq;
using Skybrud.Social.Pinterest.Objects.Common;

namespace Skybrud.Social.Pinterest.Objects.Pins {
    
    /// <summary>
    /// Class representing the image of a pin. The class serves as a collection of various size of the image.
    /// </summary>
    public class PinterestPinImage : PinterestImage {

        #region Properties

        /// <summary>
        /// Gets a reference to the original image.
        /// </summary>
        public PinterestImageSize Original {
            get { return this["original"]; }
        }

        #endregion

        #region Constructors

        private PinterestPinImage(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPinImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPinImage"/>.</returns>
        public static new PinterestPinImage Parse(JObject obj) {
            return obj == null ? null : new PinterestPinImage(obj);
        }

        #endregion

    }

}