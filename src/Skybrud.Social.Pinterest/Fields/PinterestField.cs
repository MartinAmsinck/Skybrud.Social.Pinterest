using System;

namespace Skybrud.Social.Pinterest.Fields {
    
    /// <summary>
    /// Class representing a field in the Pinterest API.
    /// </summary>
    public class PinterestField {

        #region Properties

        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public PinterestField(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            Name = name;
        }

        #endregion

        #region Member methods

        public override bool Equals(object obj) {

            PinterestField field = obj as PinterestField;
            string fieldName = obj as string;

            if (field != null) {
                return Equals(field);
            }
            
            if (fieldName != null) {
                return Equals(fieldName);
            }
            
            return false;

        }

        public bool Equals(PinterestField field) {
            return field != null && Name == field.Name;
        }

        public bool Equals(string name) {
            return Name == name;
        }

        public override int GetHashCode() {
            return Name.GetHashCode();
        }

        #endregion

        #region Operators

        /// <summary>
        /// Initializes a new field based on the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <returns>An instance of <see cref="PinterestField"/>.</returns>
        public static implicit operator PinterestField(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new PinterestField(name);
        }

        /// <summary>
        /// Adding two instances of <see cref="PinterestField"/> will result in a
        /// <see cref="PinterestFieldsCollection"/> containing both fields.
        /// </summary>
        /// <param name="left">The left field.</param>
        /// <param name="right">The right field.</param>
        /// <returns>An instance of <see cref="PinterestFieldsCollection"/> containing both <paramref name="left"/> and
        /// <paramref name="right"/>.</returns>
        public static PinterestFieldsCollection operator +(PinterestField left, PinterestField right) {
            return new PinterestFieldsCollection(left, right);
        }

        #endregion

    }

}