using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Boards.Http {

    /// <summary>
    /// Class representing the response body of a request to the Pinterest API for getting information about a single Pinterest board.
    /// </summary>
    public class PinterestGetBoardResponseBody : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest board.
        /// </summary>
        public PinterestBoard Data { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestBoard"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestGetBoardResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestBoard.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="PinterestGetBoardResponseBody"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="PinterestGetBoardResponseBody"/>.</returns>
        public static PinterestGetBoardResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetBoardResponseBody(obj);
        }

        #endregion

    }

}