using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.OAuth;
using Skybrud.Social.Pinterest.Options;

namespace Skybrud.Social.Pinterest.Endpoints.Raw {
    
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