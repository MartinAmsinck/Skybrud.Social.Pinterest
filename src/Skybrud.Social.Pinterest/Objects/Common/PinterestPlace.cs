using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Locations;

namespace Skybrud.Social.Pinterest.Objects.Common {
    
    /// <summary>
    /// Class representing a place.
    /// </summary>
    public class PinterestPlace : ILocation {

        #region Properties

        public string Category { get; private set; }

        public string Name { get; private set; }

        public string Street { get; private set; }

        public string PostalCode { get; private set; }

        public string Locality { get; private set; }

        public string Region { get; private set; }

        public string Country { get; private set; }

        public string SourceUrl { get; private set; }

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        #endregion

        #region Constructors

        private PinterestPlace(JObject obj) {
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