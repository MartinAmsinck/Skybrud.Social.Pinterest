using System;
using System.Collections.Generic;

namespace Skybrud.Social.Pinterest.Scopes {

    /// <summary>
    /// Class representing a scope of the Pinterest API.
    /// </summary>
    public class PinterestScope {

        #region Private fields

        private static readonly Dictionary<string, PinterestScope> Scopes = new Dictionary<string, PinterestScope> {
            {PinterestScopes.ReadPublic.Name, PinterestScopes.ReadPublic},
            {PinterestScopes.WritePublic.Name, PinterestScopes.WritePublic},
            {PinterestScopes.ReadRelationships.Name, PinterestScopes.ReadRelationships},
            {PinterestScopes.WriteRelationships.Name, PinterestScopes.WriteRelationships}
        };

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the scope.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new scope based on the specified <paramref name="name"/> a.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        public PinterestScope(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            Name = name;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a string representation of the scope.
        /// </summary>
        /// <returns>An instance of <see cref="System.String"/> representing the scope.</returns>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Registers a scope in the internal dictionary.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        internal static PinterestScope RegisterScope(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            PinterestScope scope = new PinterestScope(name);
            Scopes.Add(scope.Name, scope);
            return scope;
        }

        /// <summary>
        /// Attempts to get a scope with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <returns>Gets a scope matching the specified <paramref name="name"/>, or <c>null</c> if not found.</returns>
        public static PinterestScope GetScope(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            PinterestScope scope;
            return Scopes.TryGetValue(name, out scope) ? scope : null;
        }

        /// <summary>
        /// Gets whether the scope is a known scope.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <returns>Returns <code>true</code> if the specified <paramref name="name"/> matches a known scope,
        /// otherwise <code>false</code>.</returns>
        public static bool ScopeExists(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return Scopes.ContainsKey(name);
        }

        #endregion

        #region Operators

        /// <summary>
        /// Adding two instances of <see cref="PinterestScope"/> will result in a
        /// <see cref="PinterestScopeCollection"/> containing both scopes.
        /// </summary>
        /// <param name="left">The left scope.</param>
        /// <param name="right">The right scope.</param>
        /// <returns>An instance of <see cref="PinterestScopeCollection"/> based on <paramref name="left"/> and
        /// <paramref name="right"/>.</returns>
        public static PinterestScopeCollection operator +(PinterestScope left, PinterestScope right) {
            return new PinterestScopeCollection(left, right);
        }

        #endregion

    }

}