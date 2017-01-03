using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.OAuth;
using Skybrud.Social.Pinterest.Options.Boards;

namespace Skybrud.Social.Pinterest.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw boards endpoint.
    /// </summary>
    public class PinterestBoardsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public PinterestOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal PinterestBoardsRawEndpoint(PinterestOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Creates a new board with the specified <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <param name="name">The name of the board to be created.</param>
        /// <param name="description">The description of the board to be created.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse CreateBoard(string name, string description) {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            return CreateBoard(new PinterestCreateBoardOptions(name, description));
        }

        /// <summary>
        /// Creates a new board with the specified <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <param name="name">The name of the board to be created.</param>
        /// <param name="description">The description of the board to be created.</param>
        /// <param name="fields">The fields to be returned for the board.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse CreateBoard(string name, string description, PinterestFieldsCollection fields) {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            return CreateBoard(new PinterestCreateBoardOptions(name, description, fields));
        }

        /// <summary>
        /// Creates a new board with the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse CreateBoard(PinterestCreateBoardOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpPostRequest("/v1/boards/", options);
        }

        /// <summary>
        /// Gets the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <code>&lt;username&gt;/&lt;board_name&gt;</code></param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetBoard(string board) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            return GetBoard(new PinterestGetBoardOptions(board));
        }

        /// <summary>
        /// Gets the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <code>&lt;username&gt;/&lt;board_name&gt;</code></param>
        /// <param name="fields">The fields to be returned for the board.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetBoard(string board, PinterestFieldsCollection fields) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            return GetBoard(new PinterestGetBoardOptions(board, fields));
        }

        /// <summary>
        /// Gets the board matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetBoard(PinterestGetBoardOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrEmpty(options.Board)) throw new PropertyNotSetException("options.Board");
            return Client.DoHttpGetRequest("/v1/boards/" + options.Board, options);
        }

        /// <summary>
        /// Edits the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <code>&lt;username&gt;/&lt;board_name&gt;</code></param>
        /// <param name="name">The new name of the board.</param>
        /// <param name="description">The new description of the board.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse EditBoard(string board, string name, string description) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            return EditBoard(new PinterestEditBoardOptions(board, name, description));
        }

        /// <summary>
        /// Edits the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <code>&lt;username&gt;/&lt;board_name&gt;</code></param>
        /// <param name="name">The new name of the board.</param>
        /// <param name="description">The new description of the board.</param>
        /// <param name="fields">The fields to be returned for the board.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse EditBoard(string board, string name, string description, PinterestFieldsCollection fields) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            return EditBoard(new PinterestEditBoardOptions(board, name, description, fields));
        }

        /// <summary>
        /// Edits the board matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse EditBoard(PinterestEditBoardOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrEmpty(options.Board)) throw new PropertyNotSetException("options.Board");
            if (String.IsNullOrEmpty(options.Name)) throw new PropertyNotSetException("options.Name");
            return Client.DoHttpPatchRequest("/v1/boards/" + options.Board, options);
        }

        /// <summary>
        /// Deletes the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <code>&lt;username&gt;/&lt;board_name&gt;</code></param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DeleteBoard(string board) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            return Client.DoHttpDeleteRequest("/v1/boards/" + board + "/");
        }

        #endregion

    }

}