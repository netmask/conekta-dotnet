using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class BaseClient : IEquatable<BaseClient>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseClient" /> class.
        ///     Initializes a new instance of the <see cref="BaseClient" />class.
        /// </summary>
        /// <param name="Plan">Plan.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Cards">Cards.</param>
        public BaseClient(string Plan = null, string Name = null, string Email = null, string Phone = null,
            List<string> Cards = null)
        {
            this.Plan = Plan;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Cards = Cards;
        }


        /// <summary>
        ///     Gets or Sets Plan
        /// </summary>
        [DataMember(Name = "plan", EmitDefaultValue = false)]
        public string Plan { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        ///     Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        ///     Gets or Sets Cards
        /// </summary>
        [DataMember(Name = "cards", EmitDefaultValue = false)]
        public List<string> Cards { get; set; }

        /// <summary>
        ///     Returns true if BaseClient instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseClient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Plan == other.Plan ||
                    Plan != null &&
                    Plan.Equals(other.Plan)
                    ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                    ) &&
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                    ) &&
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                    ) &&
                (
                    Cards == other.Cards ||
                    Cards != null &&
                    Cards.SequenceEqual(other.Cards)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseClient {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");

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
            return Equals(obj as BaseClient);
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

                if (Plan != null)
                    hash = hash*59 + Plan.GetHashCode();

                if (Name != null)
                    hash = hash*59 + Name.GetHashCode();

                if (Email != null)
                    hash = hash*59 + Email.GetHashCode();

                if (Phone != null)
                    hash = hash*59 + Phone.GetHashCode();

                if (Cards != null)
                    hash = hash*59 + Cards.GetHashCode();

                return hash;
            }
        }
    }
}