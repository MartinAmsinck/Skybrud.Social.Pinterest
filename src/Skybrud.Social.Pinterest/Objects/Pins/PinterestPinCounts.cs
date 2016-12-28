using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Pinterest.Objects.Pins {
    
    public class PinterestPinCounts {

        #region Properties
        
        public int Likes { get; private set; }
        
        public int Comments { get; private set; }
        
        public int Repins { get; private set; }

        #endregion

        #region Constructors

        private PinterestPinCounts(JObject obj) {
            Likes = obj.GetInt32("likes");
            Comments = obj.GetInt32("comments");
            Repins = obj.GetInt32("repins");
        }

        #endregion

        #region Static methods

        public static PinterestPinCounts Parse(JObject obj) {
            return obj == null ? null : new PinterestPinCounts(obj);
        }

        #endregion

    }

}