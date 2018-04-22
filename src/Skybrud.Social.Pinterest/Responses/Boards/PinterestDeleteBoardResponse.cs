using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {

    /// <summary>
    /// Class representing the response of a request to the Pinterest API for deleting an existing board.
    /// </summary>
    public class PinterestDeleteBoardResponse : PinterestResponse {
        
        #region Constructors

        private PinterestDeleteBoardResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);
        
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PinterestDeleteBoardResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestDeleteBoardResponse"/>.</returns>
        public static PinterestDeleteBoardResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new PinterestDeleteBoardResponse(response);
        }

        #endregion

    }

}