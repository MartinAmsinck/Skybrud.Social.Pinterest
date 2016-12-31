using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Common {

    /// <summary>
    /// Class representing information about attribution - eg. of a pin.
    /// </summary>
    public class PinterestAttribution : PinterestObject {

        #region Properties

        public string Title { get; private set; }

        public string Url { get; private set; }

        public string ProviderIconUrl { get; private set; }

        public string AuthorName { get; private set; }

        public string ProviderFaviconUrl { get; private set; }

        public string AuthorUrl { get; private set; }

        public string ProviderName { get; private set; }

        #endregion

        #region Constructors

        private PinterestAttribution(JObject obj) : base(obj) {
            Title = obj.GetString("title");
            Url = obj.GetString("url");
            ProviderIconUrl = obj.GetString("provider_icon_url");
            AuthorName = obj.GetString("author_name");
            ProviderFaviconUrl = obj.GetString("provider_favicon_url");
            AuthorUrl = obj.GetString("author_url");
            ProviderName = obj.GetString("provider_name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestAttribution"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestAttribution"/>.</returns>
        public static PinterestAttribution Parse(JObject obj) {
            return obj == null ? null : new PinterestAttribution(obj);
        }

        #endregion

    }

}