using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Pinterest.Enums;

namespace Skybrud.Social.Pinterest.Models.Users {
    
    /// <summary>
    /// Class representing a Pinterest user.
    /// </summary>
    public class PinterestUser : PinterestObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the username of the user.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Gets whether the <see cref="Username"/> property has a value.
        /// </summary>
        public bool HasUsername => !String.IsNullOrWhiteSpace(Username);

        /// <summary>
        /// Gets the bio of the user.
        /// </summary>
        public string Bio { get; }

        /// <summary>
        /// Gets whether the <see cref="Bio"/> property has a value.
        /// </summary>
        public bool HasBio => !String.IsNullOrWhiteSpace(Bio);

        /// <summary>
        /// Gets the first name of the user.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Gets whether the <see cref="FirstName"/> property has a value.
        /// </summary>
        public bool HasFirstName => !String.IsNullOrWhiteSpace(FirstName);

        /// <summary>
        /// Gets the last name of the user.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Gets whether the <see cref="LastName"/> property has a value.
        /// </summary>
        public bool HasLastName => !String.IsNullOrWhiteSpace(LastName);

        /// <summary>
        /// Gets the account type of the user.
        /// </summary>
        public PinterestAccountType AccountType { get; }

        /// <summary>
        /// Gets whether the <see cref="AccountType"/> property has a value.
        /// </summary>
        public bool HasAccountType => AccountType != PinterestAccountType.NotSpecified;

        /// <summary>
        /// Gets the profile URL of the user.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets whether the <see cref="Url"/> property has a value.
        /// </summary>
        public bool HasUrl => !String.IsNullOrWhiteSpace(Url);

        /// <summary>
        /// Gets the creation date of the user.
        /// </summary>
        public EssentialsDateTime CreatedAt { get; }

        /// <summary>
        /// Gets whether the <see cref="CreatedAt"/> property has a value.
        /// </summary>
        public bool HasCreatedAt => CreatedAt != null;

        /// <summary>
        /// Gets the URL of the profile image of the user.
        /// </summary>
        public PinterestUserImage Image { get; }

        /// <summary>
        /// Gets whether the <see cref="Image"/> property has a value.
        /// </summary>
        public bool HasImage => Image != null;

        /// <summary>
        /// Gets the counts object of the user.
        /// </summary>
        public PinterestUserCounts Counts { get; }

        /// <summary>
        /// Gets whether the <see cref="Counts"/> property has a value.
        /// </summary>
        public bool HasCounts => Counts != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestUser"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestUser(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Username = obj.GetString("username");
            Bio = obj.GetString("bio");
            FirstName = obj.GetString("first_name");
            LastName = obj.GetString("last_name");
            AccountType = obj.GetEnum("account_type", PinterestAccountType.NotSpecified);
            Url = obj.GetString("url");
            CreatedAt = obj.GetString("created_at", EssentialsDateTime.Parse);
            Image = obj.GetObject("image", PinterestUserImage.Parse);
            Counts = obj.GetObject("counts", PinterestUserCounts.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestUser"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestUser"/>.</returns>
        public static PinterestUser Parse(JObject obj) {
            return obj == null ? null : new PinterestUser(obj);
        }

        #endregion

    }
}