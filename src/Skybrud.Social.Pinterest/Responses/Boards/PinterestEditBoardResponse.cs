using System;
using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Models.Boards.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {

    /// <summary>
    /// Class representing the response of a request to the Pinterest API for editing an existing Pinterest board.
    /// </summary>
    public class PinterestEditBoardResponse : PinterestResponse<PinterestEditBoardResponseBody> {
        
        #region Constructors

        private PinterestEditBoardResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PinterestEditBoardResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestEditBoardResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestEditBoardResponse"/>.</returns>
        public static PinterestEditBoardResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestEditBoardResponse(response);
        }

        #endregion

    }

}