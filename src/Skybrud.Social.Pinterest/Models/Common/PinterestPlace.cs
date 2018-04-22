using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Locations;

namespace Skybrud.Social.Pinterest.Models.Common {
    
    /// <summary>
    /// Class representing a place.
    /// </summary>
    public class PinterestPlace : ILocation {

        #region Properties

        public string Category { get; }

        public string Name { get; }

        public string Street { get; }

        public string PostalCode { get; }

        public string Locality { get; }

        public string Region { get; }

        public string Country { get; }

        public string SourceUrl { get; }

        public double Latitude { get; }

        public double Longitude { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PinterestPlace"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected PinterestPlace(JObject obj) {
            Category = obj.GetString("category");
            Name = obj.GetString("name");
            Street = obj.GetString("street");
            PostalCode = obj.GetString("postal_code");
            Locality = obj.GetString("locality");
            Region = obj.GetString("region");
            Country = obj.GetString("country");
            SourceUrl = obj.GetString("source_url");
            Latitude = obj.GetDouble("latitude");
            Longitude = obj.GetDouble("longitude");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PinterestPlace"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="PinterestPlace"/>.</returns>
        public static PinterestPlace Parse(JObject obj) {
            return obj == null ? null : new PinterestPlace(obj);
        }

        #endregion

    }

}