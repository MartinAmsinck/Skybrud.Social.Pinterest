using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Common {

    /// <summary>
    /// Class representing information about attribution - eg. of a pin.
    /// </summary>
    public class PinterestAttribution : PinterestObject {

        #region Properties

        public string Title { get; }

        public string Url { get; }

        public string ProviderIconUrl { get; }

        public string AuthorName { get; }

        public string ProviderFaviconUrl { get; }

        public string AuthorUrl { get; }

        public string ProviderName { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestAttribution"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestAttribution(JObject obj) : base(obj) {
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