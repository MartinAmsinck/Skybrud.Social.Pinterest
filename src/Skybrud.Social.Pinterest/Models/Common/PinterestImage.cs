using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Pinterest.Models.Common {
    
    /// <summary>
    /// Class representing an image. The class serves as a collection of various sizes of the image.
    /// </summary>
    public class PinterestImage : PinterestObject {

        #region Private fields

        private readonly Dictionary<string, PinterestImageSize> _sizes;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the image size with the specified <paramref name="alias"/>, or <c>null</c> if not found.
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        public PinterestImageSize this[string alias] => _sizes[alias];

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestImage"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestImage(JObject obj) : base(obj) {
            _sizes = (
                from property in obj.Properties()
                select PinterestImageSize.Parse(property.Value as JObject)
            ).ToDictionary(x => x.Alias, x => x);
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets whether an image size with the specified <paramref name="alias"/> is present in the response from the
        /// Pinterest API.
        /// </summary>
        /// <param name="alias">The alias of the image size.</param>
        /// <returns><c>true</c> if the image size is present in the response from the Pinterest API, otherwise <c>false</c>.</returns>
        public bool HasSize(string alias) {
            return _sizes.ContainsKey(alias);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestImage"/>.</returns>
        public static PinterestImage Parse(JObject obj) {
            return obj == null ? null : new PinterestImage(obj);
        }

        #endregion

    }

}