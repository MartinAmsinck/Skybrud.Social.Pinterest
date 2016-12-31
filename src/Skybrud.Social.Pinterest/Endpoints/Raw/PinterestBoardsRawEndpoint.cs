using Skybrud.Social.Pinterest.OAuth;

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


        #endregion

    }

}