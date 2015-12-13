using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Pinterest.Objects.Pins {
    
    public class PinterestPinCreator {

        #region Properties
        
        public string Id { get; private set; }
        
        public string Url { get; private set; }
        
        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }

        #endregion

        #region Constructors

        private PinterestPinCreator(JObject obj) {
            Id = obj.GetString("id");
            Url = obj.GetString("url");
            FirstName = obj.GetString("first_name");
            LastName = obj.GetString("last_name");
        }

        #endregion

        #region Static methods

        public static PinterestPinCreator Parse(JObject obj) {
            return obj == null ? null : new PinterestPinCreator(obj);
        }

        #endregion

    }

}