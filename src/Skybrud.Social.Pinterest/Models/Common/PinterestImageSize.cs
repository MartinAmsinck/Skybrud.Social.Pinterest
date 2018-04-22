using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Common {

    /// <summary>
    /// Class representing a resized version of <see cref="PinterestImage"/>.
    /// </summary>
    public class PinterestImageSize : PinterestObject {

        #region Properties
        
        /// <summary>
        /// Gets the alias of the image size.
        /// </summary>
        public string Alias { get; }

        /// <summary>
        /// Gets the URL of the image size.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the width of the image size.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height of the image size.
        /// </summary>
        public int Height { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestImageSize"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestImageSize(JObject obj) : base(obj) {

            JProperty property = obj.Parent as JProperty;
            Alias = property?.Name;

            Url = obj.GetString("url");
            Width = obj.GetInt32("width");
            Height = obj.GetInt32("height");
        
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestImageSize"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestImageSize"/>.</returns>
        public static PinterestImageSize Parse(JObject obj) {
            return obj == null ? null : new PinterestImageSize(obj);
        }

        #endregion

    }

}