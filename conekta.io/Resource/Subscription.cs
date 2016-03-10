using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Subscription : IEquatable<Subscription>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Subscription" /> class.
        ///     Initializes a new instance of the <see cref="Subscription" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Card">Card.</param>
        /// <param name="PlanId">PlanId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Start">Start.</param>
        /// <param name="BillingCycleStart">BillingCycleStart.</param>
        /// <param name="BillingCycleEnd">BillingCycleEnd.</param>
        public Subscription(string Id = null, string Card = null, string PlanId = null, string Status = null,
            string Start = null, string BillingCycleStart = null, string BillingCycleEnd = null)
        {
            this.Id = Id;
            this.Card = Card;
            this.PlanId = PlanId;
            this.Status = Status;
            this.Start = Start;
            this.BillingCycleStart = BillingCycleStart;
            this.BillingCycleEnd = BillingCycleEnd;
        }


        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public string Card { get; set; }

        /// <summary>
        ///     Gets or Sets PlanId
        /// </summary>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        ///     Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        ///     Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public string Start { get; set; }

        /// <summary>
        ///     Gets or Sets BillingCycleStart
        /// </summary>
        [DataMember(Name = "billing_cycle_start", EmitDefaultValue = false)]
        public string BillingCycleStart { get; set; }

        /// <summary>
        ///     Gets or Sets BillingCycleEnd
        /// </summary>
        [DataMember(Name = "billing_cycle_end", EmitDefaultValue = false)]
        public string BillingCycleEnd { get; set; }

        /// <summary>
        ///     Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="other">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription other)
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
                    Card == other.Card ||
                    Card != null &&
                    Card.Equals(other.Card)
                    ) &&
                (
                    PlanId == other.PlanId ||
                    PlanId != null &&
                    PlanId.Equals(other.PlanId)
                    ) &&
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                    ) &&
                (
                    Start == other.Start ||
                    Start != null &&
                    Start.Equals(other.Start)
                    ) &&
                (
                    BillingCycleStart == other.BillingCycleStart ||
                    BillingCycleStart != null &&
                    BillingCycleStart.Equals(other.BillingCycleStart)
                    ) &&
                (
                    BillingCycleEnd == other.BillingCycleEnd ||
                    BillingCycleEnd != null &&
                    BillingCycleEnd.Equals(other.BillingCycleEnd)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  BillingCycleStart: ").Append(BillingCycleStart).Append("\n");
            sb.Append("  BillingCycleEnd: ").Append(BillingCycleEnd).Append("\n");

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
            return Equals(obj as Subscription);
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

                if (Card != null)
                    hash = hash*59 + Card.GetHashCode();

                if (PlanId != null)
                    hash = hash*59 + PlanId.GetHashCode();

                if (Status != null)
                    hash = hash*59 + Status.GetHashCode();

                if (Start != null)
                    hash = hash*59 + Start.GetHashCode();

                if (BillingCycleStart != null)
                    hash = hash*59 + BillingCycleStart.GetHashCode();

                if (BillingCycleEnd != null)
                    hash = hash*59 + BillingCycleEnd.GetHashCode();

                return hash;
            }
        }
    }
}