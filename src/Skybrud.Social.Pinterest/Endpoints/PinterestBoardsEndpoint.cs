using System;
using Skybrud.Social.Pinterest.Endpoints.Raw;
using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.Options.Boards;
using Skybrud.Social.Pinterest.Responses.Boards;

namespace Skybrud.Social.Pinterest.Endpoints {

    /// <summary>
    /// Class representing the boards endpoint.
    /// </summary>
    public class PinterestBoardsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest service.
        /// </summary>
        public PinterestService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public PinterestBoardsRawEndpoint Raw {
            get { return Service.Client.Boards; }
        }

        #endregion

        #region Constructors

        internal PinterestBoardsEndpoint(PinterestService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        public PinterestCreateBoardResponse CreateBoard(string name, string description) {
            return PinterestCreateBoardResponse.ParseResponse(Raw.CreateBoard(name, description));
        }

        public PinterestCreateBoardResponse CreateBoard(string name, string description, PinterestFieldsCollection fields) {
            return PinterestCreateBoardResponse.ParseResponse(Raw.CreateBoard(name, description, fields));
        }

        public PinterestCreateBoardResponse CreateBoard(PinterestCreateBoardOptions options) {
            return PinterestCreateBoardResponse.ParseResponse(Raw.CreateBoard(options));
        }

        public PinterestDeleteBoardResponse DeleteBoard(string board) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            return PinterestDeleteBoardResponse.ParseResponse(Raw.DeleteBoard(board));
        }

        #endregion

    }

}