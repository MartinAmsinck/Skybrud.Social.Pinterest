using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Pinterest.Objects.Common;

namespace Skybrud.Social.Pinterest.Objects.Users {
    
    /// <summary>
    /// Class representing the profile image of a user. The class serves as a collection of various size of the image.
    /// </summary>
    public class PinterestUserImage : PinterestImage {

        #region Properties

        /// <summary>
        /// Gets a reference to the small image size, or <code>null</code> if not specified.
        /// </summary>
        public PinterestImageSize Small {
            get { return this["small"]; }
        }

        /// <summary>
        /// Gets a reference to the medium image size, or <code>null</code> if not specified.
        /// </summary>
        public PinterestImageSize Medium {
            get { return this["medium"]; }
        }

        /// <summary>
        /// Gets a reference to the large image size, or <code>null</code> if not specified.
        /// </summary>
        public PinterestImageSize Large {
            get { return this["large"]; }
        }

        /// <summary>
        /// Gets whether a small image size is present in the response from the Pinterest API.
        /// </summary>
        public bool HasSmall {
            get { return Small != null; }
        }

        /// <summary>
        /// Gets whether a small medium size is present in the response from the Pinterest API.
        /// </summary>
        public bool HasMedium {
            get { return Medium != null; }
        }

        /// <summary>
        /// Gets whether a small large size is present in the response from the Pinterest API.
        /// </summary>
        public bool HasLarge {
            get { return Large != null; }
        }

        #endregion

        #region Constructors

        private PinterestUserImage(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestUserImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestUserImage"/>.</returns>
        public static new PinterestUserImage Parse(JObject obj) {
            return obj == null ? null : new PinterestUserImage(obj);
        }

        #endregion

    }

}