using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.Endpoints.Raw;
using Skybrud.Social.Pinterest.Options;
using Skybrud.Social.Pinterest.Responses.Users;

namespace Skybrud.Social.Pinterest.Endpoints {

    /// <summary>
    /// Class representing the raw users endpoint.
    /// </summary>
    public class PinterestUsersEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest service.
        /// </summary>
        public PinterestService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public PinterestUsersRawEndpoint Raw => Service.Client.Users;

        #endregion

        #region Constructors

        internal PinterestUsersEndpoint(PinterestService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the user with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the user.</param>
        /// <returns>An instance of <see cref="PinterestGetUserResponse"/> representing the response.</returns>
        public PinterestGetUserResponse GetUser(string identifier) {
            return PinterestGetUserResponse.ParseResponse(Raw.GetUser(identifier));
        }

        /// <summary>
        /// Gets information about the user with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the user.</param>
        /// <param name="fields">The fields that should be returned.</param>
        /// <returns>An instance of <see cref="PinterestGetUserResponse"/> representing the response.</returns>
        public PinterestGetUserResponse GetUser(string identifier, PinterestFieldsCollection fields) {
            return PinterestGetUserResponse.ParseResponse(Raw.GetUser(identifier, fields));
        }

        /// <summary>
        /// Gets information about the user matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="PinterestGetUserResponse"/> representing the response.</returns>
        public PinterestGetUserResponse GetUser(PinterestGetUserOptions options) {
            return PinterestGetUserResponse.ParseResponse(Raw.GetUser(options));
        }

        #endregion

    }

}