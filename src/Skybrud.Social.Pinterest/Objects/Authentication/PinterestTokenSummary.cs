using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Pinterest.Scopes;

namespace Skybrud.Social.Pinterest.Objects.Authentication {

    /// <summary>
    /// Class representing the response body of a call to exchange an authorization code for an access token.
    /// </summary>
    public class PinterestTokenSummary : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the access token of the authenticating user.
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// Gets the type of the token - eg. <code>bearer</code>.
        /// </summary>
        public string TokenType { get; private set; }

        /// <summary>
        /// Gets an array of the <see cref="PinterestScope"/> the user granted.
        /// </summary>
        public PinterestScope[] Scope { get; private set; }
        
        #endregion

        #region Constructors

        private PinterestTokenSummary(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="PinterestTokenSummary"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestTokenSummary"/>.</returns>
        public static PinterestTokenSummary Parse(JObject obj) {
            
            if (obj == null) return null;
            
            // Parse the rest of the response
            return new PinterestTokenSummary(obj) {
                AccessToken = obj.GetString("access_token"),
                TokenType = obj.GetString("token_type"),
                Scope = GetStringArray(obj, "scope", x => PinterestScope.GetScope(x) ?? PinterestScope.RegisterScope(x))
            };
        
        }

        private static T[] GetStringArray<T>(JObject obj, string propertyName, Func<string, T> func) {
            JArray array = obj.GetArray(propertyName);
            return array == null ? new T[0] : (from item in array select func(item.ToString())).ToArray();
        }

        #endregion

    }

}