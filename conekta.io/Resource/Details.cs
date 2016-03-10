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
    public class Details : IEquatable<Details>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Details" /> class.
        ///     Initializes a new instance of the <see cref="Details" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        public Details(string Name = null, string Phone = null, string Email = null, Customer Customer = null,
            List<LineItem> LineItems = null, BillingAddress BillingAddress = null)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Customer = Customer;
            this.LineItems = LineItems;
            this.BillingAddress = BillingAddress;
        }


        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
        ///     Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        ///     Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        ///     Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billing_address", EmitDefaultValue = false)]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        ///     Returns true if Details instances are equal
        /// </summary>
        /// <param name="other">Instance of Details to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Details other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    ) &&
                (
                    Customer == other.Customer ||
                    Customer != null &&
                    Customer.Equals(other.Customer)
                    ) &&
                (
                    LineItems == other.LineItems ||
                    LineItems != null &&
                    LineItems.SequenceEqual(other.LineItems)
                    ) &&
                (
                    BillingAddress == other.BillingAddress ||
                    BillingAddress != null &&
                    BillingAddress.Equals(other.BillingAddress)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Details {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");

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
            return Equals(obj as Details);
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

                if (Name != null)
                    hash = hash*59 + Name.GetHashCode();

                if (Phone != null)
                    hash = hash*59 + Phone.GetHashCode();

                if (Email != null)
                    hash = hash*59 + Email.GetHashCode();

                if (Customer != null)
                    hash = hash*59 + Customer.GetHashCode();

                if (LineItems != null)
                    hash = hash*59 + LineItems.GetHashCode();

                if (BillingAddress != null)
                    hash = hash*59 + BillingAddress.GetHashCode();

                return hash;
            }
        }
    }
}