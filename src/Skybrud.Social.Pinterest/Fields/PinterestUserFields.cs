namespace Skybrud.Social.Pinterest.Fields {

    /// <summary>
    /// Static class with known fields of a Pinterest user.
    /// </summary>
    public static class PinterestUserFields {

        /// <summary>
        /// Indicates that the ID of a user should be returned.
        /// </summary>
        public static readonly PinterestField Id = new PinterestField("id");

        /// <summary>
        /// Indicates that the username of a user should be returned.
        /// </summary>
        public static readonly PinterestField Username = new PinterestField("username");

        /// <summary>
        /// Indicates that the bio of a user should be returned.
        /// </summary>
        public static readonly PinterestField Bio = new PinterestField("bio");

        /// <summary>
        /// Indicates that the first name of a user should be returned.
        /// </summary>
        public static readonly PinterestField FirstName = new PinterestField("first_name");

        /// <summary>
        /// Indicates that the last name of a user should be returned.
        /// </summary>
        public static readonly PinterestField LastName = new PinterestField("last_name");

        /// <summary>
        /// Indicates that the account type of a user should be returned.
        /// </summary>
        public static readonly PinterestField AccountType = new PinterestField("account_type");

        /// <summary>
        /// Indicates that the counts object of a user should be returned.
        /// </summary>
        public static readonly PinterestField Counts = new PinterestField("counts");

        /// <summary>
        /// Indicates that the creation date of a user should be returned.
        /// </summary>
        public static readonly PinterestField CreatedAt = new PinterestField("created_at");

        /// <summary>
        /// Indicates that the profile image of a user should be returned.
        /// </summary>
        public static readonly PinterestField Image = new PinterestField("image");

        /// <summary>
        /// Indicates that the profile URL of a user should be returned.
        /// </summary>
        public static readonly PinterestField Url = new PinterestField("url");
        
        /// <summary>
        /// Gets a collection of all known scopes of a Pinterest user.
        /// </summary>
        public static readonly PinterestFieldsCollection All = Id + Username + Bio + FirstName + LastName + AccountType + Counts + CreatedAt + Image + Url;

    }

}