using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Pins {

    /// <summary>
    /// Class with various statistics (counts) about a Pinterest pin.
    /// </summary>
    public class PinterestPinCounts {

        #region Properties
        
        /// <summary>
        /// The amount of likes the pin has received.
        /// </summary>
        public int Likes { get; }

        /// <summary>
        /// The amount of comments the pin has received.
        /// </summary>
        public int Comments { get; }

        /// <summary>
        /// The amount of repins the pin has received.
        /// </summary>
        public int Repins { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestPinCounts"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestPinCounts(JObject obj) {
            Likes = obj.GetInt32("likes");
            Comments = obj.GetInt32("comments");
            Repins = obj.GetInt32("repins");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPinCounts"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPinCounts"/>.</returns>
        public static PinterestPinCounts Parse(JObject obj) {
            return obj == null ? null : new PinterestPinCounts(obj);
        }

        #endregion

    }

}