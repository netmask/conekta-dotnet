using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class SubscriptionReference : IEquatable<SubscriptionReference>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SubscriptionReference" /> class.
        ///     Initializes a new instance of the <see cref="SubscriptionReference" />class.
        /// </summary>
        /// <param name="Plan">Plan.</param>
        /// <param name="Card">Card.</param>
        public SubscriptionReference(string Plan = null, string Card = null)
        {
            this.Plan = Plan;
            this.Card = Card;
        }


        /// <summary>
        ///     Gets or Sets Plan
        /// </summary>
        [DataMember(Name = "plan", EmitDefaultValue = false)]
        public string Plan { get; set; }

        /// <summary>
        ///     Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public string Card { get; set; }

        /// <summary>
        ///     Returns true if SubscriptionReference instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionReference other)
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
                    Card == other.Card ||
                    Card != null &&
                    Card.Equals(other.Card)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionReference {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");

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
            return Equals(obj as SubscriptionReference);
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

                if (Card != null)
                    hash = hash*59 + Card.GetHashCode();

                return hash;
            }
        }
    }
}