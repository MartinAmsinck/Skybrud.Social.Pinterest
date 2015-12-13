using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;
using Skybrud.Social.Time;

namespace Skybrud.Social.Pinterest.Objects.Pins {

    public class PinterestPin {

        #region Properties

        // attribution

        public PinterestPinCreator Creator { get; private set; }

        public string Url { get; private set; }

        // media

        public SocialDateTime CreatedAt { get; private set; }

        public string Note { get; private set; }

        public string Color { get; private set; }

        public string Link { get; private set; }

        public PinterestPinBoard Board { get; private set; }

        // image

        public PinterestPinCounts Counts { get; private set; }

        public string Id { get; private set; }

        // metadata

        #endregion

        #region Constructors

        private PinterestPin(JObject obj) {
            Creator = obj.GetObject("creator", PinterestPinCreator.Parse);
            Url = obj.GetString("url");
            CreatedAt = obj.GetString("created_at", SocialDateTime.Parse);
            Note = obj.GetString("note");
            Color = obj.GetString("color");
            Link = obj.GetString("link");
            Board = obj.GetObject("board", PinterestPinBoard.Parse);
            Counts = obj.GetObject("counts", PinterestPinCounts.Parse);
            Id = obj.GetString("id");
        }

        #endregion

        #region Static methods

        public static PinterestPin Parse(JObject obj) {
            return obj == null ? null : new PinterestPin(obj);
        }

        #endregion

    }

}