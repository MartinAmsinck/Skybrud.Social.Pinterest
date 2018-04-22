using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Pins {

    /// <summary>
    /// Class with information about the board a pin belongs to.
    /// </summary>
    public class PinterestPinBoard {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the board.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the Pinterest URL of the board.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the name of the board.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestPinBoard"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestPinBoard(JObject obj) {
            Id = obj.GetString("id");
            Url = obj.GetString("url");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPinBoard"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPinBoard"/>.</returns>
        public static PinterestPinBoard Parse(JObject obj) {
            return obj == null ? null : new PinterestPinBoard(obj);
        }

        #endregion

    }

}