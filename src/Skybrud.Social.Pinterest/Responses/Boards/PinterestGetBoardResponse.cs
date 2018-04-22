using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Boards.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {

    /// <summary>
    /// Class representing the response of a request to the Pinterest API for getting information about a single Pinterest board.
    /// </summary>
    public class PinterestGetBoardResponse : PinterestResponse<PinterestGetBoardResponseBody> {
        
        #region Constructors

        private PinterestGetBoardResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestGetBoardResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestGetBoardResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestGetBoardResponse"/>.</returns>
        public static PinterestGetBoardResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestGetBoardResponse(response);
        }

        #endregion

    }

}