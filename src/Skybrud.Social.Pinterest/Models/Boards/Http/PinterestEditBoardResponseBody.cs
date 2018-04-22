using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Boards.Http {

    /// <summary>
    /// Class representing the response body of a request to the Pinterest API for editing a Pinterest board.
    /// </summary>
    public class PinterestEditBoardResponseBody : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the updated board.
        /// </summary>
        public PinterestBoard Data { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestEditBoardResponseBody"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestEditBoardResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestBoard.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="PinterestEditBoardResponseBody"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="PinterestEditBoardResponseBody"/>.</returns>
        public static PinterestEditBoardResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestEditBoardResponseBody(obj);
        }

        #endregion

    }

}