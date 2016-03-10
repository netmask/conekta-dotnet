using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class BillingAddress : IEquatable<BillingAddress>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BillingAddress" /> class.
        ///     Initializes a new instance of the <see cref="BillingAddress" />class.
        /// </summary>
        /// <param name="Street1">Street1.</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Street3">Street3.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip.</param>
        /// <param name="Country">Country.</param>
        /// <param name="TaxId">TaxId.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Email">Email.</param>
        public BillingAddress(string Street1 = null, string Street2 = null, string Street3 = null, string City = null,
            string State = null, string Zip = null, string Country = null, string TaxId = null,
            string CompanyName = null, string Phone = null, string Email = null)
        {
            this.Street1 = Street1;
            this.Street2 = Street2;
            this.Street3 = Street3;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
            this.TaxId = TaxId;
            this.CompanyName = CompanyName;
            this.Phone = Phone;
            this.Email = Email;
        }


        /// <summary>
        ///     Gets or Sets Street1
        /// </summary>
        [DataMember(Name = "street1", EmitDefaultValue = false)]
        public string Street1 { get; set; }

        /// <summary>
        ///     Gets or Sets Street2
        /// </summary>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        ///     Gets or Sets Street3
        /// </summary>
        [DataMember(Name = "street3", EmitDefaultValue = false)]
        public string Street3 { get; set; }

        /// <summary>
        ///     Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        ///     Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        ///     Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        ///     Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        ///     Gets or Sets TaxId
        /// </summary>
        [DataMember(Name = "tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        ///     Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        ///     Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        ///     Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        ///     Returns true if BillingAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Street1 == other.Street1 ||
                    Street1 != null &&
                    Street1.Equals(other.Street1)
                    ) &&
                (
                    Street2 == other.Street2 ||
                    Street2 != null &&
                    Street2.Equals(other.Street2)
                    ) &&
                (
                    Street3 == other.Street3 ||
                    Street3 != null &&
                    Street3.Equals(other.Street3)
                    ) &&
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                    ) &&
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                    ) &&
                (
                    Zip == other.Zip ||
                    Zip != null &&
                    Zip.Equals(other.Zip)
                    ) &&
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
                    ) &&
                (
                    TaxId == other.TaxId ||
                    TaxId != null &&
                    TaxId.Equals(other.TaxId)
                    ) &&
                (
                    CompanyName == other.CompanyName ||
                    CompanyName != null &&
                    CompanyName.Equals(other.CompanyName)
                    ) &&
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                    ) &&
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingAddress {\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Street3: ").Append(Street3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");

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
            return Equals(obj as BillingAddress);
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

                if (Street1 != null)
                    hash = hash*59 + Street1.GetHashCode();

                if (Street2 != null)
                    hash = hash*59 + Street2.GetHashCode();

                if (Street3 != null)
                    hash = hash*59 + Street3.GetHashCode();

                if (City != null)
                    hash = hash*59 + City.GetHashCode();

                if (State != null)
                    hash = hash*59 + State.GetHashCode();

                if (Zip != null)
                    hash = hash*59 + Zip.GetHashCode();

                if (Country != null)
                    hash = hash*59 + Country.GetHashCode();

                if (TaxId != null)
                    hash = hash*59 + TaxId.GetHashCode();

                if (CompanyName != null)
                    hash = hash*59 + CompanyName.GetHashCode();

                if (Phone != null)
                    hash = hash*59 + Phone.GetHashCode();

                if (Email != null)
                    hash = hash*59 + Email.GetHashCode();

                return hash;
            }
        }
    }
}