namespace Skybrud.Social.Pinterest.Fields {

    /// <summary>
    /// Static class with known fields of a Pinterest board.
    /// </summary>
    public class PinterestBoardFields {

        public static readonly PinterestField Counts = "counts";

        public static readonly PinterestField CreatedAt = "created_at";

        public static readonly PinterestField Creator = "creator";

        public static readonly PinterestField Description = "description";

        public static readonly PinterestField Id = "id";

        public static readonly PinterestField Image = "image";

        public static readonly PinterestField Name = "name";

        public static readonly PinterestField Privacy = "privacy";

        public static readonly PinterestField Reason = "reason";

        public static readonly PinterestField Url = "url";

        public static readonly PinterestFieldsCollection All = Counts + CreatedAt + Creator + Description + Id + Image + Name + Privacy + Reason + Url;

    }

}