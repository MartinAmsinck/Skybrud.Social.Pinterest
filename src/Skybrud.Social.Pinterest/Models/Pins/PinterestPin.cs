using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Pinterest.Models.Common;

namespace Skybrud.Social.Pinterest.Models.Pins {

    /// <summary>
    /// Class representing a Pinterest pin.
    /// </summary>
    public class PinterestPin {

        #region Properties

        /// <summary>
        /// Gets the ID of the pin.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets attribution ifnormation about the pin.
        /// </summary>
        public PinterestAttribution Attribution { get; }

        /// <summary>
        /// Gets whether the <see cref="Attribution"/> property has a value.
        /// </summary>
        public bool HasAttribution => Attribution != null;

        /// <summary>
        /// Gets a reference to the user that created the pin.
        /// </summary>
        public PinterestPinCreator Creator { get; }

        /// <summary>
        /// Gets whether the <see cref="Creator"/> property has a value.
        /// </summary>
        public bool HasCreator => Creator != null;

        /// <summary>
        /// Get the URL of the pin.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets whether the <see cref="Url"/> property has a value.
        /// </summary>
        public bool HasUrl => !String.IsNullOrWhiteSpace(Url);

        public PinterestMedia Media { get; }

        /// <summary>
        /// Gets whether the <see cref="Media"/> property has a value.
        /// </summary>
        public bool HasMedia => Media != null;

        /// <summary>
        /// Gets the creation date of the pin.
        /// </summary>
        public EssentialsDateTime CreatedAt { get; }

        /// <summary>
        /// Gets whether the <see cref="CreatedAt"/> property has a value.
        /// </summary>
        public bool HasCreatedAt => CreatedAt != null;

        /// <summary>
        /// Gets the note (description) of the pin.
        /// </summary>
        public string Note { get; }

        /// <summary>
        /// Gets whether the <see cref="Note"/> property has a value.
        /// </summary>
        public bool HasNote => !String.IsNullOrWhiteSpace(Note);

        /// <summary>
        /// Gets the primary color of the pin.
        /// </summary>
        public string Color { get; }

        /// <summary>
        /// Gets whether the <see cref="Color"/> property has a value.
        /// </summary>
        public bool HasColor => !String.IsNullOrWhiteSpace(Color);

        /// <summary>
        /// Gets the source URL of the image of the pin.
        /// </summary>
        public string Link { get; }

        /// <summary>
        /// Gets whether the <see cref="Link"/> property has a value.
        /// </summary>
        public bool HasLink => !String.IsNullOrWhiteSpace(Link);

        /// <summary>
        /// Gets a reference to the board that the pin belongs to.
        /// </summary>
        public PinterestPinBoard Board { get; }

        /// <summary>
        /// Gets whether the <see cref="Board"/> property has a value.
        /// </summary>
        public bool HasBoard => Board != null;

        /// <summary>
        /// Gets a reference to the image of the pin.
        /// </summary>
        public PinterestPinImage Image { get; }

        /// <summary>
        /// Gets whether the <see cref="Image"/> property has a value.
        /// </summary>
        public bool HasImage => Image != null;

        /// <summary>
        /// Gets the counts object of the pin.
        /// </summary>
        public PinterestPinCounts Counts { get; }

        /// <summary>
        /// Gets whether the <see cref="Counts"/> property has a value.
        /// </summary>
        public bool HasCounts => Counts != null;

        public PinterestPinMetadata Metadata { get; }

        /// <summary>
        /// Gets whether the <see cref="Metadata"/> property has a value.
        /// </summary>
        public bool HasMetadata => Metadata != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestPin"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestPin(JObject obj) {
            Id = obj.GetString("id");
            Attribution = obj.GetObject("attribution", PinterestAttribution.Parse);
            Creator = obj.GetObject("creator", PinterestPinCreator.Parse);
            Url = obj.GetString("url");
            Media = obj.GetObject("media", PinterestMedia.Parse);
            Image = obj.GetObject("image", PinterestPinImage.Parse);
            CreatedAt = obj.GetString("created_at", EssentialsDateTime.Parse);
            Note = obj.GetString("note");
            Color = obj.GetString("color");
            Link = obj.GetString("link");
            Board = obj.GetObject("board", PinterestPinBoard.Parse);
            Counts = obj.GetObject("counts", PinterestPinCounts.Parse);
            Metadata = obj.GetObject("meatadata", PinterestPinMetadata.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPin"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPin"/>.</returns>
        public static PinterestPin Parse(JObject obj) {
            return obj == null ? null : new PinterestPin(obj);
        }

        #endregion

    }

}