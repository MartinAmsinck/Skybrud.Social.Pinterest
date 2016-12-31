using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Users {
    
    /// <summary>
    /// Class with various statistics (counts) about a Pinterest user.
    /// </summary>
    public class PinterestUserCounts : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the amount of pins made by the user.
        /// </summary>
        public int Pins { get; private set; }
        
        /// <summary>
        /// Gets the amount of users the user is following.
        /// </summary>
        public int Following { get; private set; }
        
        /// <summary>
        /// Gets the amount of users following the user.
        /// </summary>
        public int Followers { get; private set; }
        
        /// <summary>
        /// Gets hte amount of boards the user has created.
        /// </summary>
        public int Boards { get; private set; }

        /// <summary>
        /// Gets hte amount of likes the user has made.
        /// </summary>
        public int Likes { get; private set; }

        #endregion

        #region Constructors

        private PinterestUserCounts(JObject obj) : base(obj) {
            Pins = obj.GetInt32("pins");
            Following = obj.GetInt32("following");
            Followers = obj.GetInt32("followers");
            Boards = obj.GetInt32("boards");
            Likes = obj.GetInt32("likes");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestUserCounts"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestUserCounts"/>.</returns>
        public static PinterestUserCounts Parse(JObject obj) {
            return obj == null ? null : new PinterestUserCounts(obj);
        }

        #endregion

    }

}