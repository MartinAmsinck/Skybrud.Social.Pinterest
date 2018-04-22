using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.OAuth;
using Skybrud.Social.Pinterest.Options;

namespace Skybrud.Social.Pinterest.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw pins endpoint.
    /// </summary>
    public class PinterestPinsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public PinterestOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal PinterestPinsRawEndpoint(PinterestOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the pin with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPin(string id) {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id));
            return GetPin(new PinterestGetPinOptions(id));
        }

        /// <summary>
        /// Gets the pin with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <param name="fields">The fields to be returned for the pin.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPin(string id, PinterestFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id));
            return GetPin(new PinterestGetPinOptions(id, fields));
        }

        /// <summary>
        /// Gets the pin matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPin(PinterestGetPinOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest($"/v1/pins/{options.Id}", options);
        }

        /// <summary>
        /// Gets a collection of pins of the Pinterest board matching the specified <paramref name="username"/> and <paramref name="board"/>.
        /// </summary>
        /// <param name="username">The username of the user owning the board.</param>
        /// <param name="board">The alias of the board.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPins(string username, string board) {
            if (String.IsNullOrWhiteSpace(username)) throw new ArgumentNullException(nameof(username));
            if (String.IsNullOrWhiteSpace(board)) throw new ArgumentNullException(nameof(board));
            return GetPins(new PinterestGetPinsOptions(username, board));
        }

        /// <summary>
        /// Gets a collection of pins of the Pinterest board matching the specified <paramref name="username"/> and <paramref name="board"/>.
        /// </summary>
        /// <param name="username">The username of the user owning the board.</param>
        /// <param name="board">The alias of the board.</param>
        /// <param name="fields">The fields to be returned for the pins.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPins(string username, string board, PinterestFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(username)) throw new ArgumentNullException(nameof(username));
            if (String.IsNullOrWhiteSpace(board)) throw new ArgumentNullException(nameof(board));
            return GetPins(new PinterestGetPinsOptions(username, board, fields));
        }

        /// <summary>
        /// Gets a collection of pins of the Pinterest board matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns></returns>
        public SocialHttpResponse GetPins(PinterestGetPinsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (String.IsNullOrWhiteSpace(options.Username)) throw new PropertyNotSetException(nameof(options.Username));
            if (String.IsNullOrWhiteSpace(options.Board)) throw new PropertyNotSetException(nameof(options.Board));
            return Client.DoHttpGetRequest($"/v1/boards/{options.Username}/{options.Board}/pins", options);
        }

        #endregion

    }

}