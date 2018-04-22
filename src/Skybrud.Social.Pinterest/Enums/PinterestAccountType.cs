namespace Skybrud.Social.Pinterest.Enums {
    
    /// <summary>
    /// Enum class representing the account type of a Pinterest user.
    /// </summary>
    public enum PinterestAccountType {

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
