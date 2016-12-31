using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Users.Http {
    
    public class PinterestGetUserResponseBody : PinterestObject {

        #region Properties

        public PinterestUser Data { get; private set; }

        #endregion

        #region Constructors

        private PinterestGetUserResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestUser.Parse);
        }

        #endregion

        #region Static methods

        public static PinterestGetUserResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetUserResponseBody(obj);
        }

        #endregion

    }

}