using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Common {

    public class PinterestMedia : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the type of the media - eg. <code>image</code> or <code>video</code>.
        /// </summary>
        public string Type { get; private set; }

        #endregion

        #region Constructors

        private PinterestMedia(JObject obj) : base(obj) {
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