using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.Endpoints.Raw;
using Skybrud.Social.Pinterest.Options;
using Skybrud.Social.Pinterest.Responses.Pins;

namespace Skybrud.Social.Pinterest.Endpoints {

    /// <summary>
    /// Class representing the raw pins endpoint.
    /// </summary>
    public class PinterestPinsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest service.
        /// </summary>
        public PinterestService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public PinterestPinsRawEndpoint Raw => Service.Client.Pins;

        #endregion

        #region Constructors

        internal PinterestPinsEndpoint(PinterestService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the pin with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <returns>An instance of <see cref="PinterestGetPinResponse"/> representing the response.</returns>
        public PinterestGetPinResponse GetPin(string id) {
            return PinterestGetPinResponse.ParseResponse(Raw.GetPin(id));
        }

        /// <summary>
        /// Gets the pin with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <param name="fields">The fields to be returned for the pin.</param>
        /// <returns>An instance of <see cref="PinterestGetPinResponse"/> representing the response.</returns>
        public PinterestGetPinResponse GetPin(string id, PinterestFieldsCollection fields) {
            return PinterestGetPinResponse.ParseResponse(Raw.GetPin(id, fields));
        }

        /// <summary>
        /// Gets the pin matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="PinterestGetPinResponse"/> representing the response.</returns>
        public PinterestGetPinResponse GetPin(PinterestGetPinOptions options) {
            return PinterestGetPinResponse.ParseResponse(Raw.GetPin(options));
        }

        /// <summary>
        /// Gets a collection of pins of the Pinterest board matching the specified <paramref name="username"/> and <paramref name="board"/>.
        /// </summary>
        /// <param name="username">The username of the user owning the board.</param>
        /// <param name="board">The alias of the board.</param>
        /// <returns>An instance of <see cref="PinterestGetPinsResponse"/> representing the response.</returns>
        public PinterestGetPinsResponse GetPins(string username, string board) {
            return PinterestGetPinsResponse.ParseResponse(Raw.GetPins(username, board));
        }

        /// <summary>
        /// Gets a collection of pins of the Pinterest board matching the specified <paramref name="username"/> and <paramref name="board"/>.
        /// </summary>
        /// <param name="username">The username of the user owning the board.</param>
        /// <param name="board">The alias of the board.</param>
        /// <param name="fields">The fields to be returned for the pins.</param>
        /// <returns>An instance of <see cref="PinterestGetPinsResponse"/> representing the response.</returns>
        public PinterestGetPinsResponse GetPins(string username, string board, PinterestFieldsCollection fields) {
            return PinterestGetPinsResponse.ParseResponse(Raw.GetPins(username, board, fields));
        }

        /// <summary>
        /// Gets a collection of pins of the Pinterest board matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns></returns>
        public PinterestGetPinsResponse GetPins(PinterestGetPinsOptions options) {
            return PinterestGetPinsResponse.ParseResponse(Raw.GetPins(options));
        }

        #endregion

    }

}