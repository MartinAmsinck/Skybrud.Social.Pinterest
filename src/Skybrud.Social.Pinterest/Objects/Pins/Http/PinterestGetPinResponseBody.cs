using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Pins.Http {
    
    public class PinterestGetPinResponseBody : PinterestObject {

        #region Properties

        public PinterestPin Data { get; private set; }

        #endregion

        #region Constructors

        private PinterestGetPinResponseBody(JObject obj) : base(obj) {
            Data = obj.GetObject("data", PinterestPin.Parse);
        }

        #endregion

        #region Static methods

        public static PinterestGetPinResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetPinResponseBody(obj);
        }

        #endregion

    }

}