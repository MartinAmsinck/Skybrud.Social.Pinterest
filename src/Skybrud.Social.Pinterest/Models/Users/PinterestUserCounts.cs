using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Users {
    
    /// <summary>
    /// Class with various statistics (counts) about a Pinterest user.
    /// </summary>
    public class PinterestUserCounts : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the amount of pins made by the user.
        /// </summary>
        public int Pins { get; }
        
        /// <summary>
        /// Gets the amount of users the user is following.
        /// </summary>
        public int Following { get; }
        
        /// <summary>
        /// Gets the amount of users following the user.
        /// </summary>
        public int Followers { get; }
        
        /// <summary>
        /// Gets hte amount of boards the user has created.
        /// </summary>
        public int Boards { get; }

        /// <summary>
        /// Gets hte amount of likes the user has made.
        /// </summary>
        public int Likes { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestUserCounts"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestUserCounts(JObject obj) : base(obj) {
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