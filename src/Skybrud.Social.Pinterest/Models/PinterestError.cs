using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Pinterest.Models {

    /// <summary>
    /// Class representing an error returned by the Pinterest API.
    /// </summary>
    public class PinterestError : PinterestObject {

        #region Properties
        
        /// <summary>
        /// Gets the status of the exception.
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// Gets the error code of the exception.
        /// </summary>
        public int Code { get; }

        public string Host { get; }

        public EssentialsDateTime GeneratedAt { get; }

        public string Message { get; }

        public string Type { get; }

        public bool HasStatus {
            get { return !String.IsNullOrWhiteSpace(Status); }
        }

        public bool HasCode {
            get { return Code > 0; }
        }

        public bool HasHost {
            get { return !String.IsNullOrWhiteSpace(Host); }
        }

        public bool HasGeneratedAt {
            get { return GeneratedAt != null; }
        }

        public bool HasMessage {
            get { return !String.IsNullOrWhiteSpace(Message); }
        }

        public bool HasType {
            get { return !String.IsNullOrWhiteSpace(Type); }
        }

        #endregion

        #region Constructors

        private PinterestError(JObject obj) : base(obj) {
            Status = obj.GetString("status");
            Code = obj.GetInt32("code");
            Host = obj.GetString("host");
            GeneratedAt = obj.GetString("generated_at", EssentialsDateTime.Parse);
            Message = obj.GetString("message");
            Type = obj.GetString("type");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestError"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestError"/>.</returns>
        public static PinterestError Parse(JObject obj) {
            return obj == null ? null : new PinterestError(obj);
        }

        #endregion

    }

}