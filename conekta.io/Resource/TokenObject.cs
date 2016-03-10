using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class TokenObject : IEquatable<TokenObject>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TokenObject" /> class.
        ///     Initializes a new instance of the <see cref="TokenObject" />class.
        /// </summary>
        /// <param name="Token">Token.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Active">Active.</param>
        public TokenObject(string Token = null, string Id = null, bool? Active = null)
        {
            this.Token = Token;
            this.Id = Id;
            this.Active = Active;
        }


        /// <summary>
        ///     Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public bool? Active { get; set; }

        /// <summary>
        ///     Returns true if TokenObject instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
                    ) &&
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                    ) &&
                (
                    Active == other.Active ||
                    Active != null &&
                    Active.Equals(other.Active)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenObject {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");

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
            return Equals(obj as TokenObject);
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

                if (Token != null)
                    hash = hash*59 + Token.GetHashCode();

                if (Id != null)
                    hash = hash*59 + Id.GetHashCode();

                if (Active != null)
                    hash = hash*59 + Active.GetHashCode();

                return hash;
            }
        }
    }
}