using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Common {
    
    public class PinterestImageSize : PinterestObject {

        #region Properties
        
        /// <summary>
        /// Gets the alias of the image size.
        /// </summary>
        public string Alias { get; private set; }

        /// <summary>
        /// Gets the URL of the image size.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the width of the image size.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Gets the height of the image size.
        /// </summary>
        public int Height { get; private set; }

        #endregion

        #region Constructors

        private PinterestImageSize(JObject obj) : base(obj) {

            JProperty property = obj.Parent as JProperty;
            Alias = property == null ? null : property.Name;

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