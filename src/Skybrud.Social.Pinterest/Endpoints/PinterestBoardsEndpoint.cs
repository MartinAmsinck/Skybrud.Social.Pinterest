using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.Endpoints.Raw;
using Skybrud.Social.Pinterest.Options.Boards;
using Skybrud.Social.Pinterest.Responses.Boards;

namespace Skybrud.Social.Pinterest.Endpoints {

    /// <summary>
    /// Class representing the raw boards endpoint.
    /// </summary>
    public class PinterestBoardsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest service.
        /// </summary>
        public PinterestService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public PinterestBoardsRawEndpoint Raw => Service.Client.Boards;

        #endregion

        #region Constructors

        internal PinterestBoardsEndpoint(PinterestService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Creates a new board with the specified <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <param name="name">The name of the board to be created.</param>
        /// <param name="description">The description of the board to be created.</param>
        /// <returns>An instance of <see cref="PinterestCreateBoardResponse"/> representing the response.</returns>
        public PinterestCreateBoardResponse CreateBoard(string name, string description) {
            return PinterestCreateBoardResponse.ParseResponse(Raw.CreateBoard(name, description));
        }

        /// <summary>
        /// Creates a new board with the specified <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <param name="name">The name of the board to be created.</param>
        /// <param name="description">The description of the board to be created.</param>
        /// <param name="fields">The fields to be returned for the board.</param>
        /// <returns>An instance of <see cref="PinterestCreateBoardResponse"/> representing the response.</returns>
        public PinterestCreateBoardResponse CreateBoard(string name, string description, PinterestFieldsCollection fields) {
            return PinterestCreateBoardResponse.ParseResponse(Raw.CreateBoard(name, description, fields));
        }

        /// <summary>
        /// Creates a new board with the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="PinterestCreateBoardResponse"/> representing the response.</returns>
        public PinterestCreateBoardResponse CreateBoard(PinterestCreateBoardOptions options) {
            return PinterestCreateBoardResponse.ParseResponse(Raw.CreateBoard(options));
        }

        /// <summary>
        /// Gets the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <c>&lt;username&gt;/&lt;board_name&gt;</c></param>
        /// <returns>An instance of <see cref="PinterestGetBoardResponse"/> representing the response.</returns>
        public PinterestGetBoardResponse GetBoard(string board) {
            return PinterestGetBoardResponse.ParseResponse(Raw.GetBoard(board));
        }

        /// <summary>
        /// Gets the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <c>&lt;username&gt;/&lt;board_name&gt;</c></param>
        /// <param name="fields">The fields to be returned for the board.</param>
        /// <returns>An instance of <see cref="PinterestGetBoardResponse"/> representing the response.</returns>
        public PinterestGetBoardResponse GetBoard(string board, PinterestFieldsCollection fields) {
            return PinterestGetBoardResponse.ParseResponse(Raw.GetBoard(board, fields));
        }

        /// <summary>
        /// Gets the board matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="PinterestGetBoardResponse"/> representing the response.</returns>
        public PinterestGetBoardResponse GetBoard(PinterestGetBoardOptions options) {
            return PinterestGetBoardResponse.ParseResponse(Raw.GetBoard(options));
        }

        /// <summary>
        /// Edits the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <c>&lt;username&gt;/&lt;board_name&gt;</c></param>
        /// <param name="name">The new name of the board.</param>
        /// <param name="description">The new description of the board.</param>
        /// <returns>An instance of <see cref="PinterestEditBoardResponse"/> representing the response.</returns>
        public PinterestEditBoardResponse EditBoard(string board, string name, string description) {
            return PinterestEditBoardResponse.ParseResponse(Raw.EditBoard(board, name, description));
        }

        /// <summary>
        /// Edits the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <c>&lt;username&gt;/&lt;board_name&gt;</c></param>
        /// <param name="name">The new name of the board.</param>
        /// <param name="description">The new description of the board.</param>
        /// <param name="fields">The fields to be returned for the board.</param>
        /// <returns>An instance of <see cref="PinterestEditBoardResponse"/> representing the response.</returns>
        public PinterestEditBoardResponse EditBoard(string board, string name, string description, PinterestFieldsCollection fields) {
            return PinterestEditBoardResponse.ParseResponse(Raw.EditBoard(board, name, description, fields));
        }

        /// <summary>
        /// Edits the board matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="PinterestEditBoardResponse"/> representing the response.</returns>
        public PinterestEditBoardResponse EditBoard(PinterestEditBoardOptions options) {
            return PinterestEditBoardResponse.ParseResponse(Raw.EditBoard(options));
        }

        /// <summary>
        /// Deletes the board with the specified <paramref name="board"/> identifier.
        /// </summary>
        /// <param name="board">The identifier of the board to be retrieved. Can be either the ID of the board or the
        /// part of the URL like <code>&lt;username&gt;/&lt;board_name&gt;</code></param>
        /// <returns>An instance of <see cref="PinterestDeleteBoardResponse"/> representing the response.</returns>
        public PinterestDeleteBoardResponse DeleteBoard(string board) {
            return PinterestDeleteBoardResponse.ParseResponse(Raw.DeleteBoard(board));
        }

        #endregion

    }

}