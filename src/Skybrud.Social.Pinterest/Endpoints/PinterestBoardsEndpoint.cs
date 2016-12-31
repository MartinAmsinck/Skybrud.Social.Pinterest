using Skybrud.Social.Pinterest.Endpoints.Raw;

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

        #endregion

    }

}