using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Boards.Http {

    public class PinterestGetBoardResponseBody : PinterestObject {

        #region Properties

        public PinterestBoard Data { get; private set; }

        #endregion

        #region Constructors

        private PinterestGetBoardResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestBoard.Parse);
        }

        #endregion

        #region Static methods

        public static PinterestGetBoardResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetBoardResponseBody(obj);
        }

        #endregion

    }

}