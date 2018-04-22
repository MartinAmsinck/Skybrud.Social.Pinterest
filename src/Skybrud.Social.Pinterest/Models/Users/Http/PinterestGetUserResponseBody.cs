using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Models.Users.Http {

    /// <summary>
    /// Class representing the response body of a request to the Pinterest API for getting information about a single Pinterest user.
    /// </summary>
    public class PinterestGetUserResponseBody : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest user.
        /// </summary>
        public PinterestUser Data { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestGetUserResponseBody"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestGetUserResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestUser.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="PinterestGetUserResponseBody"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="PinterestGetUserResponseBody"/>.</returns>
        public static PinterestGetUserResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetUserResponseBody(obj);
        }

        #endregion

    }

}