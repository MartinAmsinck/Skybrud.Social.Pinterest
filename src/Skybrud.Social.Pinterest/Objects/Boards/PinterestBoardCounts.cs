using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Boards {

    /// <summary>
    /// Class with various statistics (counts) about a Pinterest board.
    /// </summary>
    public class PinterestBoardCounts {

        #region Properties
        
        /// <summary>
        /// Gets the amount of pins that have been added to the board.
        /// </summary>
        public int Pins { get; private set; }

        /// <summary>
        /// Gets the amount of collaborators of the board.
        /// </summary>
        public int Collaborators { get; private set; }

        /// <summary>
        /// Gets the amount of followers of the board.
        /// </summary>
        public int Followers { get; private set; }

        #endregion

        #region Constructors

        private PinterestBoardCounts(JObject obj) {
            Pins = obj.GetInt32("pins");
            Collaborators = obj.GetInt32("collaborators");
            Followers = obj.GetInt32("followers");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestBoardCounts"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestBoardCounts"/>.</returns>
        public static PinterestBoardCounts Parse(JObject obj) {
            return obj == null ? null : new PinterestBoardCounts(obj);
        }

        #endregion

    }

}