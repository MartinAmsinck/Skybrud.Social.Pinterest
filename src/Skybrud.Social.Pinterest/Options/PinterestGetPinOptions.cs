using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;
using Skybrud.Social.Pinterest.Fields;

namespace Skybrud.Social.Pinterest.Options {

    public class PinterestGetPinOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the pin to be returned.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public PinterestFieldsCollection Fields { get; set; }

        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public PinterestGetPinOptions() {
            Fields = new PinterestFieldsCollection();
        }

        /// <summary>
        /// Initializes the options based on the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        public PinterestGetPinOptions(string id) {
            Id = id;
        }

        /// <summary>
        /// Initializes the options based on the specified <paramref name="id"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <param name="fields">A collection of the fields that should be returned.</param>
        public PinterestGetPinOptions(string id, PinterestFieldsCollection fields) {
            Id = id;
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