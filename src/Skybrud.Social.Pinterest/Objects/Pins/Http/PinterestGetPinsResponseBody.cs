using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Pins.Http {
    
    public class PinterestGetPinsResponseBody : PinterestObject {

        #region Properties

        public PinterestPin[] Data { get; private set; }

        #endregion

        #region Constructors

        private PinterestGetPinsResponseBody(JObject obj) : base(obj) {
            Data = obj.GetArray("data", PinterestPin.Parse);
            /*
              "page": {
                "cursor": null,
                "next": null
              }
            */
        }

        #endregion

        #region Static methods

        public static PinterestGetPinsResponseBody Parse(JObject obj) {
            return obj == null ? null : new PinterestGetPinsResponseBody(obj);
        }

        #endregion

    }

}