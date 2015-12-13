using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Pinterest.Objects.Pins {
    
    public class PinterestPinBoard {

        #region Properties
        
        public string Id { get; private set; }
        
        public string Url { get; private set; }
        
        public string Name { get; private set; }

        #endregion

        #region Constructors

        private PinterestPinBoard(JObject obj) {
            Id = obj.GetString("id");
            Url = obj.GetString("url");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        public static PinterestPinBoard Parse(JObject obj) {
            return obj == null ? null : new PinterestPinBoard(obj);
        }

        #endregion

    }

}