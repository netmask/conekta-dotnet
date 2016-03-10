using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ChargeBank : IEquatable<ChargeBank>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ChargeBank" /> class.
        ///     Initializes a new instance of the <see cref="ChargeBank" />class.
        /// </summary>
        /// <param name="Type">Type.</param>
        public ChargeBank(string Type = null)
        {
            this.Type = Type;
        }


        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Returns true if ChargeBank instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeBank other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type);
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeBank {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");

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
            return Equals(obj as ChargeBank);
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

                return hash;
            }
        }
    }
}