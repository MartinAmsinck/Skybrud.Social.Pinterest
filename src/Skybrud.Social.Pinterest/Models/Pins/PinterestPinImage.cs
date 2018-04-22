using Newtonsoft.Json.Linq;
using Skybrud.Social.Pinterest.Models.Common;

namespace Skybrud.Social.Pinterest.Models.Pins {
    
    /// <summary>
    /// Class representing the image of a pin. The class serves as a collection of various size of the image.
    /// </summary>
    public class PinterestPinImage : PinterestImage {

        #region Properties

        /// <summary>
        /// Gets a reference to the original image.
        /// </summary>
        public PinterestImageSize Original => this["original"];

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestPinImage"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestPinImage(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPinImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPinImage"/>.</returns>
        public new static PinterestPinImage Parse(JObject obj) {
            return obj == null ? null : new PinterestPinImage(obj);
        }

        #endregion

    }

}