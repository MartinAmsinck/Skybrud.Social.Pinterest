using Skybrud.Social.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {
    
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
            return response == null ? null : new PinterestDeleteBoardResponse(response);
        }

        #endregion

    }

}