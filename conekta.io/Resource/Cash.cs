using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Cash : IEquatable<Cash>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Cash" /> class.
        ///     Initializes a new instance of the <see cref="Cash" />class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="ExpiresAt">ExpiresAt.</param>
        public Cash(string Type = null, string ExpiresAt = null)
        {
            this.Type = Type;
            this.ExpiresAt = ExpiresAt;
        }


        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        ///     Returns true if Cash instances are equal
        /// </summary>
        /// <param name="other">Instance of Cash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cash other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                    ) &&
                (
                    ExpiresAt == other.ExpiresAt ||
                    ExpiresAt != null &&
                    ExpiresAt.Equals(other.ExpiresAt)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cash {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as Cash);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)

                if (Type != null)
                    hash = hash*59 + Type.GetHashCode();

                if (ExpiresAt != null)
                    hash = hash*59 + ExpiresAt.GetHashCode();

                return hash;
            }
        }
    }
}