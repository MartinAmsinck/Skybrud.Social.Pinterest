using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Pinterest.Scopes;

namespace Skybrud.Social.Pinterest.Models.Authentication {

    /// <summary>
    /// Class representing the response body of a request to exchange an authorization code for an access token.
    /// </summary>
    public class PinterestToken : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the access token of the authenticating user.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Gets the type of the token - eg. <c>bearer</c>.
        /// </summary>
        public string TokenType { get; }

        /// <summary>
        /// Gets an array of the <see cref="PinterestScope"/> the user granted.
        /// </summary>
        public PinterestScope[] Scope { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestToken"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestToken(JObject obj) : base(obj) {
            AccessToken = obj.GetString("access_token");
            TokenType = obj.GetString("token_type");
            Scope = GetStringArray(obj, "scope", x => PinterestScope.GetScope(x) ?? PinterestScope.RegisterScope(x));
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="PinterestToken"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestToken"/>.</returns>
        public static PinterestToken Parse(JObject obj) {
            return obj == null ? null : new PinterestToken(obj);
        }

        private static T[] GetStringArray<T>(JObject obj, string propertyName, Func<string, T> func) {
            JArray array = obj.GetArray(propertyName);
            return array == null ? new T[0] : (from item in array select func(item.ToString())).ToArray();
        }

        #endregion

    }

}