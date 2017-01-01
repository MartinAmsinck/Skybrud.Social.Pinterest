using System;
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

        public SocialHttpResponse CreateBoard(string name, string description) {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            return CreateBoard(new PinterestCreateBoardOptions(name, description));
        }

        public SocialHttpResponse CreateBoard(string name, string description, PinterestFieldsCollection fields) {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            return CreateBoard(new PinterestCreateBoardOptions(name, description, fields));
        }

        public SocialHttpResponse CreateBoard(PinterestCreateBoardOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpPostRequest("/v1/boards/", options);
        }

        public SocialHttpResponse DeleteBoard(string board) {
            if (String.IsNullOrEmpty(board)) throw new ArgumentNullException("board");
            return Client.DoHttpRequest(SocialHttpMethod.Delete, "/v1/boards/" + board + "/");
        }

        #endregion

    }

}