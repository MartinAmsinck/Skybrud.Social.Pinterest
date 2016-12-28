using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.OAuth;
using Skybrud.Social.Pinterest.Options;

namespace Skybrud.Social.Pinterest.Endpoints.Raw {
    
    public class PinterestPinsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public PinterestOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal PinterestPinsRawEndpoint(PinterestOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the pin with the specified <code>id</code>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse GetPin(string id) {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id");
            return GetPin(new PinterestGetPinOptions(id));
        }

        /// <summary>
        /// Gets the pin with the specified <code>id</code>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <param name="fields">The fields to be returned for the pin.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse GetPin(string id, PinterestFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id");
            return GetPin(new PinterestGetPinOptions(id, fields));
        }

        /// <summary>
        /// Gets the pin matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse GetPin(PinterestGetPinOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://api.pinterest.com/v1/pins/" + options.Id, options);
        }

        public SocialHttpResponse GetPins(string username, string board) {
            if (String.IsNullOrWhiteSpace(username)) throw new ArgumentNullException("username");
            if (String.IsNullOrWhiteSpace(board)) throw new ArgumentNullException("board");
            return GetPins(new PinterestGetPinsOptions(username, board));
        }

        public SocialHttpResponse GetPins(string username, string board, PinterestFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(username)) throw new ArgumentNullException("username");
            if (String.IsNullOrWhiteSpace(board)) throw new ArgumentNullException("board");
            return GetPins(new PinterestGetPinsOptions(username, board, fields));
        }

        public SocialHttpResponse GetPins(PinterestGetPinsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://api.pinterest.com/v1/boards/" + options.Username + "/" + options.Board + "/pins", options);
        }

        #endregion

    }

}