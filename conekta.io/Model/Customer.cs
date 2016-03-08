using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Customer : IEquatable<Customer>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Customer" /> class.
        ///     Initializes a new instance of the <see cref="Customer" />class.
        /// </summary>
        /// <param name="LoggedIn">LoggedIn.</param>
        /// <param name="SuccessfulPurchases">SuccessfulPurchases.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="OfflinePayments">OfflinePayments.</param>
        /// <param name="Score">Score.</param>
        public Customer(string LoggedIn = null, int? SuccessfulPurchases = null, int? CreatedAt = null,
            int? UpdatedAt = null, int? OfflinePayments = null, int? Score = null)
        {
            this.LoggedIn = LoggedIn;
            this.SuccessfulPurchases = SuccessfulPurchases;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.OfflinePayments = OfflinePayments;
            this.Score = Score;
        }


        /// <summary>
        ///     Gets or Sets LoggedIn
        /// </summary>
        [DataMember(Name = "logged_in", EmitDefaultValue = false)]
        public string LoggedIn { get; set; }

        /// <summary>
        ///     Gets or Sets SuccessfulPurchases
        /// </summary>
        [DataMember(Name = "successful_purchases", EmitDefaultValue = false)]
        public int? SuccessfulPurchases { get; set; }

        /// <summary>
        ///     Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public int? CreatedAt { get; set; }

        /// <summary>
        ///     Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public int? UpdatedAt { get; set; }

        /// <summary>
        ///     Gets or Sets OfflinePayments
        /// </summary>
        [DataMember(Name = "offline_payments", EmitDefaultValue = false)]
        public int? OfflinePayments { get; set; }

        /// <summary>
        ///     Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public int? Score { get; set; }

        /// <summary>
        ///     Returns true if Customer instances are equal
        /// </summary>
        /// <param name="other">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    LoggedIn == other.LoggedIn ||
                    LoggedIn != null &&
                    LoggedIn.Equals(other.LoggedIn)
                    ) &&
                (
                    SuccessfulPurchases == other.SuccessfulPurchases ||
                    SuccessfulPurchases != null &&
                    SuccessfulPurchases.Equals(other.SuccessfulPurchases)
                    ) &&
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                    ) &&
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                    ) &&
                (
                    OfflinePayments == other.OfflinePayments ||
                    OfflinePayments != null &&
                    OfflinePayments.Equals(other.OfflinePayments)
                    ) &&
                (
                    Score == other.Score ||
                    Score != null &&
                    Score.Equals(other.Score)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  LoggedIn: ").Append(LoggedIn).Append("\n");
            sb.Append("  SuccessfulPurchases: ").Append(SuccessfulPurchases).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  OfflinePayments: ").Append(OfflinePayments).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");

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
            return Equals(obj as Customer);
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

                if (LoggedIn != null)
                    hash = hash*59 + LoggedIn.GetHashCode();

                if (SuccessfulPurchases != null)
                    hash = hash*59 + SuccessfulPurchases.GetHashCode();

                if (CreatedAt != null)
                    hash = hash*59 + CreatedAt.GetHashCode();

                if (UpdatedAt != null)
                    hash = hash*59 + UpdatedAt.GetHashCode();

                if (OfflinePayments != null)
                    hash = hash*59 + OfflinePayments.GetHashCode();

                if (Score != null)
                    hash = hash*59 + Score.GetHashCode();

                return hash;
            }
        }
    }
}