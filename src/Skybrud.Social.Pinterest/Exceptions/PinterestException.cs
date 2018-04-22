using System;

namespace Skybrud.Social.Pinterest.Exceptions {

    /// <summary>
    /// Exception class for errors used throughout this package.
    /// </summary>
    public class PinterestException : Exception {

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public PinterestException(string message) : base(message) { }

    }

}