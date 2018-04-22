using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Boards.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {
    
    /// <summary>
    /// Class representing the response of a request to the Pinterest API for creating a new Pinterest board.
    /// </summary>
    public class PinterestCreateBoardResponse : PinterestResponse<PinterestCreateBoardResponseBody> {
        
        #region Constructors

        private PinterestCreateBoardResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestCreateBoardResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestCreateBoardResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestCreateBoardResponse"/>.</returns>
        public static PinterestCreateBoardResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestCreateBoardResponse(response);
        }

        #endregion

    }

}