using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Objects.Boards.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {
    
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
            return response == null ? null : new PinterestGetBoardResponse(response);
        }

        #endregion

    }

}