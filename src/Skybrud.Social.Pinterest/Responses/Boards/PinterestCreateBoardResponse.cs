using Skybrud.Social.Http;
using Skybrud.Social.Pinterest.Objects.Boards.Http;

namespace Skybrud.Social.Pinterest.Responses.Boards {
    
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
            return response == null ? null : new PinterestCreateBoardResponse(response);
        }

        #endregion

    }

}