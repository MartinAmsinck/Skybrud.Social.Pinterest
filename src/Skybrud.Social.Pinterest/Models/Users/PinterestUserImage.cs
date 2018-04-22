using Newtonsoft.Json.Linq;
using Skybrud.Social.Pinterest.Models.Common;

namespace Skybrud.Social.Pinterest.Models.Users {
    
    /// <summary>
    /// Class representing the profile image of a user. The class serves as a collection of various size of the image.
    /// </summary>
    public class PinterestUserImage : PinterestImage {

        #region Properties

        /// <summary>
        /// Gets a reference to the small image size, or <c>null</c> if not specified.
        /// </summary>
        public PinterestImageSize Small => this["small"];

        /// <summary>
        /// Gets a reference to the medium image size, or <c>null</c> if not specified.
        /// </summary>
        public PinterestImageSize Medium => this["medium"];

        /// <summary>
        /// Gets a reference to the large image size, or <c>null</c> if not specified.
        /// </summary>
        public PinterestImageSize Large => this["large"];

        /// <summary>
        /// Gets whether a small image size is present in the response from the Pinterest API.
        /// </summary>
        public bool HasSmall => Small != null;

        /// <summary>
        /// Gets whether a small medium size is present in the response from the Pinterest API.
        /// </summary>
        public bool HasMedium => Medium != null;

        /// <summary>
        /// Gets whether a small large size is present in the response from the Pinterest API.
        /// </summary>
        public bool HasLarge => Large != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestUserImage"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestUserImage(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestUserImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestUserImage"/>.</returns>
        public new static PinterestUserImage Parse(JObject obj) {
            return obj == null ? null : new PinterestUserImage(obj);
        }

        #endregion

    }

}