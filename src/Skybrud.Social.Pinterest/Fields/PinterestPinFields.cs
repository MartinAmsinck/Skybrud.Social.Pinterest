namespace Skybrud.Social.Pinterest.Fields {

    /// <summary>
    /// Static class with known fields of a Pinterest pin.
    /// </summary>
    public static class PinterestPinFields {

        /// <summary>
        /// The unique string of numbers and letters that identifies the Pin on Pinterest.
        /// </summary>
        public static readonly PinterestField Id = new PinterestField("id");

        /// <summary>
        /// The source data for videos, including the title, URL, provider, author name, author URL and provider name.
        /// </summary>
        public static readonly PinterestField Attribution = new PinterestField("attribution");

        /// <summary>
        /// The first and last name, ID and profile URL of the user who created the board.
        /// </summary>
        public static readonly PinterestField Creator = new PinterestField("creator");

        /// <summary>
        /// The URL of the Pin on Pinterest.
        /// </summary>
        public static readonly PinterestField Url = new PinterestField("url");

        /// <summary>
        /// The media type of the Pin (image or video).
        /// </summary>
        public static readonly PinterestField Media = new PinterestField("media");

        /// <summary>
        /// The date the Pin was created.
        /// </summary>
        public static readonly PinterestField CreatedAt = new PinterestField("created_at");

        /// <summary>
        /// The user-entered description of the Pin.
        /// </summary>
        public static readonly PinterestField Note = new PinterestField("note");

        /// <summary>
        /// The dominant color of the Pin’s image in hex code format.
        /// </summary>
        public static readonly PinterestField Color = new PinterestField("color");

        /// <summary>
        /// The URL of the webpage where the Pin was created.
        /// </summary>
        public static readonly PinterestField Link = new PinterestField("link");

        /// <summary>
        /// The board that the Pin is on.
        /// </summary>
        public static readonly PinterestField Board = new PinterestField("board");

        /// <summary>
        /// The Pin’s image. The default response returns the image’s URL, width and height.
        /// </summary>
        public static readonly PinterestField Image = new PinterestField("image");

        /// <summary>
        /// The Pin’s stats, including the number of repins, comments and likes.
        /// </summary>
        public static readonly PinterestField Counts = new PinterestField("counts");

        /// <summary>
        /// Extra information about the Pin for Rich Pins. Includes the Pin type (e.g., article, recipe) and related information (e.g., ingredients, author).
        /// </summary>
        public static readonly PinterestField Metadata = new PinterestField("metadata");

        /// <summary>
        /// Gets a collection of all known scopes of a Pinterest pin.
        /// </summary>
        public static readonly PinterestFieldsCollection All = Id + Attribution + Creator + Url + Media + CreatedAt + Note + Color + Link + Board + Image + Counts + Metadata;

    }

}