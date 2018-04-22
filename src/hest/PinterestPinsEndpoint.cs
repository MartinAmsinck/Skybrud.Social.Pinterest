using System;
using Skybrud.Social.Pinterest.Endpoints.Raw;
using Skybrud.Social.Pinterest.Fields;
using Skybrud.Social.Pinterest.Options;
using Skybrud.Social.Pinterest.Responses.Pins;

namespace Skybrud.Social.Pinterest.Endpoints {

    /// <summary>
    /// Class representing the pins endpoint.
    /// </summary>
    public class PinterestPinsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Pinterest service.
        /// </summary>
        public PinterestService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public PinterestPinsRawEndpoint Raw {
            get { return Service.Client.Pins; }
        }

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
        /// <returns>Returns an instance of <see cref="PinterestGetPinResponse"/> representing the response.</returns>
        public PinterestGetPinResponse GetPin(string id) {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id");
            return PinterestGetPinResponse.ParseResponse(Raw.GetPin(id));
        }

        /// <summary>
        /// Gets the pin with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pin to be returned.</param>
        /// <param name="fields">The fields to be returned for the pin.</param>
        /// <returns>Returns an instance of <see cref="PinterestGetPinResponse"/> representing the response.</returns>
        public PinterestGetPinResponse GetPin(string id, PinterestFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id");
            return PinterestGetPinResponse.ParseResponse(Raw.GetPin(id, fields));
        }

        /// <summary>
        /// Gets the pin matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="PinterestGetPinResponse"/> representing the response.</returns>
        public PinterestGetPinResponse GetPin(PinterestGetPinOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return PinterestGetPinResponse.ParseResponse(Raw.GetPin(options));
        }

        public PinterestGetPinsResponse GetPins(string username, string board) {
            if (String.IsNullOrWhiteSpace(username)) throw new ArgumentNullException("username");
            if (String.IsNullOrWhiteSpace(board)) throw new ArgumentNullException("board");
            return PinterestGetPinsResponse.ParseResponse(Raw.GetPins(username, board));
        }

        public PinterestGetPinsResponse GetPins(string username, string board, PinterestFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(username)) throw new ArgumentNullException("username");
            if (String.IsNullOrWhiteSpace(board)) throw new ArgumentNullException("board");
            return PinterestGetPinsResponse.ParseResponse(Raw.GetPins(username, board, fields));
        }

        public PinterestGetPinsResponse GetPins(PinterestGetPinsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return PinterestGetPinsResponse.ParseResponse(Raw.GetPins(options));
        }

        #endregion

    }

}