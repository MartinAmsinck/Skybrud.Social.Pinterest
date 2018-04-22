using System;

namespace Skybrud.Social.Pinterest.Exceptions {

    /// <summary>
    /// Exception class thrown when parsing a JSON response from the Pinterest API fails.
    /// </summary>
    public class PinterestParseException : PinterestException {

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public PinterestParseException(string message) : base(message) { }

    }

}