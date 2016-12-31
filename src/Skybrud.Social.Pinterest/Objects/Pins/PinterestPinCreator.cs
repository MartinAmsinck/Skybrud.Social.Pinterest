using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Pins {

    /// <summary>
    /// Class with information about the creator of a Pinterest pin.
    /// </summary>
    public class PinterestPinCreator {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the creator.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the profile URL of the creator.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the first name of the creator.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets the last name of the creator.
        /// </summary>
        public string LastName { get; private set; }

        #endregion

        #region Constructors

        private PinterestPinCreator(JObject obj) {
            Id = obj.GetString("id");
            Url = obj.GetString("url");
            FirstName = obj.GetString("first_name");
            LastName = obj.GetString("last_name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPinCreator"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPinCreator"/>.</returns>
        public static PinterestPinCreator Parse(JObject obj) {
            return obj == null ? null : new PinterestPinCreator(obj);
        }

        #endregion

    }

}