using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;
using Skybrud.Social.Pinterest.Fields;

namespace Skybrud.Social.Pinterest.Options {

    public class PinterestGetPinsOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the alias of the board.
        /// </summary>
        public string Board { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public PinterestFieldsCollection Fields { get; set; }

        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public PinterestGetPinsOptions() {
            Fields = new PinterestFieldsCollection();
        }

        /// <summary>
        /// Initializes an instance with the specified <code>username</code>.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="board">The alias of the board.</param>
        public PinterestGetPinsOptions(string username, string board) {
            Board = board;
            Username = username;
        }

        /// <summary>
        /// Initializes an instance with the specified <code>username</code>.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="board">The alias of the board.</param>
        /// <param name="fields">A collection of the fields that should be returned.</param>
        public PinterestGetPinsOptions(string username, string board, PinterestFieldsCollection fields) {
            Board = board;
            Username = username;
            Fields = fields ?? new PinterestFieldsCollection();
        }

        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {

            // Convert the collection of fields to a string
            string fields = (Fields == null ? "" : Fields.ToString()).Trim();

            // Construct the query string
            SocialHttpQueryString query = new SocialHttpQueryString();
            if (!String.IsNullOrWhiteSpace(fields)) query.Set("fields", fields);

            return query;

        }

        #endregion
    
    }

}