using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Pinterest.Objects.Common;
using Skybrud.Social.Pinterest.Objects.Pins;
using Skybrud.Social.Pinterest.Objects.Users;

namespace Skybrud.Social.Pinterest.Objects.Boards {

    public class PinterestBoard : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the board.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the board.
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// Get the description of the board.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property has a value.
        /// </summary>
        public bool HasDescription {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }

        public PinterestUserItem Creator { get; private set; }

        public string Url { get; private set; }

        public EssentialsDateTime CreatedAt { get; private set; }

        public string Privacy { get; private set; }

        public string Reason { get; private set; }

        public PinterestImage Image { get; private set; }

        public PinterestBoardCounts Counts { get; private set; }

        #endregion

        #region Constructors

        private PinterestBoard(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Description = obj.GetString("description");
            Creator = obj.GetObject("creator", PinterestUserItem.Parse);
            Url = obj.GetString("url");
            CreatedAt = obj.GetString("created_at", EssentialsDateTime.Parse);
            Privacy = obj.GetString("privacy");
            Reason = obj.GetString("reason");
            Image = obj.GetObject("image", PinterestPinImage.Parse);
            Counts = obj.GetObject("counts", PinterestBoardCounts.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPin"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPin"/>.</returns>
        public static PinterestBoard Parse(JObject obj) {
            return obj == null ? null : new PinterestBoard(obj);
        }

        #endregion

    }

}