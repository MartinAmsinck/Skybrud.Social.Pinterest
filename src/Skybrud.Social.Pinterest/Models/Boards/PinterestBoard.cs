using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Pinterest.Models.Common;
using Skybrud.Social.Pinterest.Models.Pins;
using Skybrud.Social.Pinterest.Models.Users;

namespace Skybrud.Social.Pinterest.Models.Boards {

    /// <summary>
    /// Class representing a Pinterest board.
    /// </summary>
    public class PinterestBoard : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the board.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the board.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Get the description of the board.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property has a value.
        /// </summary>
        public bool HasDescription => !String.IsNullOrWhiteSpace(Description);

        public PinterestUserItem Creator { get; }

        public string Url { get; }

        public EssentialsDateTime CreatedAt { get; }

        public string Privacy { get; }

        public string Reason { get; }

        public PinterestImage Image { get; }

        public PinterestBoardCounts Counts { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestBoard"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestBoard(JObject obj) : base(obj) {
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