namespace Skybrud.Social.Pinterest.Models.Users {
    
    /// <summary>
    /// Enum class representing the account type of a Pinterest user.
    /// </summary>
    public enum PinterestUserAccountType {

        /// <summary>
        /// Indicates that the <c>account_type</c> fields wasn't returned by the Pinterest API.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// Indicates that a Pinterest user is an individual.
        /// </summary>
        Individual,

        /// <summary>
        /// Indicates that a Pinterest user is a business.
        /// </summary>
        Business

    }

}
