using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;
using Skybrud.Social.Pinterest.Fields;

namespace Skybrud.Social.Pinterest.Options {
    
    public class PinterestGetPinOptions : IGetOptions {

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
        /// Initializes an instance with default options.
        /// </summary>
        public PinterestGetPinOptions() {
            Fields = new PinterestFieldsCollection();
        }

        /// <summary>
        /// Initializes an instance with the specified <code>username</code>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        public PinterestGetPinOptions(string id) {
            Id = id;
        }

        /// <summary>
        /// Initializes an instance with the specified <code>username</code>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <param name="fields">A collection of the fields that should be returned.</param>
        public PinterestGetPinOptions(string id, PinterestFieldsCollection fields) {
            Id = id;
            Fields = fields ?? new PinterestFieldsCollection();
        }

        #endregion

        #region Member methods

        public SocialQueryString GetQueryString() {

            // Convert the collection of fields to a string
            string fields = (Fields == null ? "" : Fields.ToString()).Trim();

            // Construct the query string
            SocialQueryString query = new SocialQueryString();
            if (!String.IsNullOrWhiteSpace(fields)) query.Set("fields", fields);

            return query;

        }

        #endregion
    
    }

}