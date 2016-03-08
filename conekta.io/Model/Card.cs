using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Card : IEquatable<Card>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Card" /> class.
        ///     Initializes a new instance of the <see cref="Card" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Last4">Last4.</param>
        /// <param name="ExpMonth">ExpMonth.</param>
        /// <param name="ExpYear">ExpYear.</param>
        /// <param name="Active">Active.</param>
        /// <param name="Address">Address.</param>
        public Card(string Id = null, string _Object = null, string CreatedAt = null, string Name = null,
            string Last4 = null, string ExpMonth = null, string ExpYear = null, string Active = null,
            BillingAddress Address = null)
        {
            this.Id = Id;
            this._Object = _Object;
            this.CreatedAt = CreatedAt;
            this.Name = Name;
            this.Last4 = Last4;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.Active = Active;
            this.Address = Address;
        }


        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets _Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string _Object { get; set; }

        /// <summary>
        ///     Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets Last4
        /// </summary>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        ///     Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name = "exp_month", EmitDefaultValue = false)]
        public string ExpMonth { get; set; }

        /// <summary>
        ///     Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name = "exp_year", EmitDefaultValue = false)]
        public string ExpYear { get; set; }

        /// <summary>
        ///     Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public string Active { get; set; }

        /// <summary>
        ///     Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public BillingAddress Address { get; set; }

        /// <summary>
        ///     Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                    ) &&
                (
                    _Object == other._Object ||
                    _Object != null &&
                    _Object.Equals(other._Object)
                    ) &&
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                    ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                    ) &&
                (
                    Last4 == other.Last4 ||
                    Last4 != null &&
                    Last4.Equals(other.Last4)
                    ) &&
                (
                    ExpMonth == other.ExpMonth ||
                    ExpMonth != null &&
                    ExpMonth.Equals(other.ExpMonth)
                    ) &&
                (
                    ExpYear == other.ExpYear ||
                    ExpYear != null &&
                    ExpYear.Equals(other.ExpYear)
                    ) &&
                (
                    Active == other.Active ||
                    Active != null &&
                    Active.Equals(other.Active)
                    ) &&
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");

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
            return Equals(obj as Card);
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

                if (Id != null)
                    hash = hash*59 + Id.GetHashCode();

                if (_Object != null)
                    hash = hash*59 + _Object.GetHashCode();

                if (CreatedAt != null)
                    hash = hash*59 + CreatedAt.GetHashCode();

                if (Name != null)
                    hash = hash*59 + Name.GetHashCode();

                if (Last4 != null)
                    hash = hash*59 + Last4.GetHashCode();

                if (ExpMonth != null)
                    hash = hash*59 + ExpMonth.GetHashCode();

                if (ExpYear != null)
                    hash = hash*59 + ExpYear.GetHashCode();

                if (Active != null)
                    hash = hash*59 + Active.GetHashCode();

                if (Address != null)
                    hash = hash*59 + Address.GetHashCode();

                return hash;
            }
        }
    }
}