using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Pinterest.Objects.Common;

namespace Skybrud.Social.Pinterest.Objects.Pins {

    public class PinterestPin {

        #region Properties

        /// <summary>
        /// Gets the ID of the pin.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets attribution ifnormation about the pin.
        /// </summary>
        public PinterestAttribution Attribution { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Attribution"/> property has a value.
        /// </summary>
        public bool HasAttribution {
            get { return Attribution != null; }
        }

        /// <summary>
        /// Gets a reference to the user that created the pin.
        /// </summary>
        public PinterestPinCreator Creator { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Creator"/> property has a value.
        /// </summary>
        public bool HasCreator {
            get { return Creator != null; }
        }

        /// <summary>
        /// Get the URL of the pin.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Url"/> property has a value.
        /// </summary>
        public bool HasUrl {
            get { return !String.IsNullOrWhiteSpace(Url); }
        }

        public PinterestMedia Media { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Media"/> property has a value.
        /// </summary>
        public bool HasMedia {
            get { return Media != null; }
        }

        /// <summary>
        /// Gets the creation date of the pin.
        /// </summary>
        public EssentialsDateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="CreatedAt"/> property has a value.
        /// </summary>
        public bool HasCreatedAt {
            get { return CreatedAt != null; }
        }

        /// <summary>
        /// Gets the note (description) of the pin.
        /// </summary>
        public string Note { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Note"/> property has a value.
        /// </summary>
        public bool HasNote {
            get { return !String.IsNullOrWhiteSpace(Note); }
        }

        /// <summary>
        /// Gets the primary color of the pin.
        /// </summary>
        public string Color { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Color"/> property has a value.
        /// </summary>
        public bool HasColor {
            get { return !String.IsNullOrWhiteSpace(Color); }
        }

        /// <summary>
        /// Gets the source URL of the image of the pin.
        /// </summary>
        public string Link { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Link"/> property has a value.
        /// </summary>
        public bool HasLink {
            get { return !String.IsNullOrWhiteSpace(Link); }
        }

        /// <summary>
        /// Gets a reference to the board that the pin belongs to.
        /// </summary>
        public PinterestPinBoard Board { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Board"/> property has a value.
        /// </summary>
        public bool HasBoard {
            get { return Board != null; }
        }

        /// <summary>
        /// Gets a reference to the image of the pin.
        /// </summary>
        public PinterestPinImage Image { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Image"/> property has a value.
        /// </summary>
        public bool HasImage {
            get { return Image != null; }
        }
        
        /// <summary>
        /// Gets the counts object of the pin.
        /// </summary>
        public PinterestPinCounts Counts { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Counts"/> property has a value.
        /// </summary>
        public bool HasCounts {
            get { return Counts != null; }
        }

        public PinterestPinMetadata Metadata { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Metadata"/> property has a value.
        /// </summary>
        public bool HasMetadata {
            get { return Metadata != null; }
        }

        #endregion

        #region Constructors

        private PinterestPin(JObject obj) {
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