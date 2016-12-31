using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.Pinterest.Objects {

    /// <summary>
    /// Class representing a basic object from the Pinterest API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class PinterestObject : JsonObjectBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected PinterestObject(JObject obj) : base(obj) { }

        #endregion

    }

}