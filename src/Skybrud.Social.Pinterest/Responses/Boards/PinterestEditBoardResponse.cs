using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Objects.Boards.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {
    
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
            return response == null ? null : new PinterestEditBoardResponse(response);
        }

        #endregion

    }

}