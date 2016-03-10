using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Refunds : IEquatable<Refunds>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Refunds" /> class.
        ///     Initializes a new instance of the <see cref="Refunds" />class.
        /// </summary>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Transaction">Transaction.</param>
        public Refunds(string CreatedAt = null, int? Amount = null, string Currency = null, string Transaction = null)
        {
            this.CreatedAt = CreatedAt;
            this.Amount = Amount;
            this.Currency = Currency;
            this.Transaction = Transaction;
        }


        /// <summary>
        ///     Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int? Amount { get; set; }

        /// <summary>
        ///     Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        ///     Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public string Transaction { get; set; }

        /// <summary>
        ///     Returns true if Refunds instances are equal
        /// </summary>
        /// <param name="other">Instance of Refunds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Refunds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                    ) &&
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                    ) &&
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                    ) &&
                (
                    Transaction == other.Transaction ||
                    Transaction != null &&
                    Transaction.Equals(other.Transaction)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refunds {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");

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
            return Equals(obj as Refunds);
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

                if (CreatedAt != null)
                    hash = hash*59 + CreatedAt.GetHashCode();

                if (Amount != null)
                    hash = hash*59 + Amount.GetHashCode();

                if (Currency != null)
                    hash = hash*59 + Currency.GetHashCode();

                if (Transaction != null)
                    hash = hash*59 + Transaction.GetHashCode();

                return hash;
            }
        }
    }
}