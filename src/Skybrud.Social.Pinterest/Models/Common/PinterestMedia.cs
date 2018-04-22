using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Common {

    public class PinterestMedia : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the type of the media - eg. <c>image</c> or <c>video</c>.
        /// </summary>
        public string Type { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestMedia"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestMedia(JObject obj) : base(obj) {
            Type = obj.GetString("type");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestMedia"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestMedia"/>.</returns>
        public static PinterestMedia Parse(JObject obj) {
            return obj == null ? null : new PinterestMedia(obj);
        }

        #endregion

    }

}