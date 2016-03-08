using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class TokenizedCard : IEquatable<TokenizedCard>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TokenizedCard" /> class.
        ///     Initializes a new instance of the <see cref="TokenizedCard" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Last4">Last4.</param>
        /// <param name="ExpMonth">ExpMonth.</param>
        /// <param name="ExpYear">ExpYear.</param>
        /// <param name="Active">Active.</param>
        public TokenizedCard(string Id = null, string Name = null, string Last4 = null, string ExpMonth = null,
            string ExpYear = null, string Active = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Last4 = Last4;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.Active = Active;
        }


        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
        ///     Returns true if TokenizedCard instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenizedCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenizedCard other)
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
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenizedCard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
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
            return Equals(obj as TokenizedCard);
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

                return hash;
            }
        }
    }
}