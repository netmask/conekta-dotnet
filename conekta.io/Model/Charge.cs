using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Charge : IEquatable<Charge>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Charge" /> class.
        ///     Initializes a new instance of the <see cref="Charge" />class.
        /// </summary>
        /// <param name="Id">Charge object id.</param>
        /// <param name="MonthlyInstallments">MonthlyInstallments.</param>
        /// <param name="Refunds">Refunds.</param>
        /// <param name="Livemode">Live mode.</param>
        /// <param name="Cash">Cash.</param>
        /// <param name="Description">Charge Description.</param>
        /// <param name="Amount">ammount without decimal places.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="ReferenceId">ReferenceId.</param>
        /// <param name="Bank">Bank.</param>
        /// <param name="Card">token card.</param>
        /// <param name="FailureCode">FailureCode.</param>
        /// <param name="FailureMessage">FailureMessage.</param>
        /// <param name="PaymentMethod">PaymentMethod.</param>
        /// <param name="Details">Details.</param>
        public Charge(string Id = null, string MonthlyInstallments = null, List<Refunds> Refunds = null,
            bool? Livemode = null, Cash Cash = null, string Description = null, int? Amount = null,
            string Currency = null, string ReferenceId = null, ChargeBank Bank = null, string Card = null,
            string FailureCode = null, string FailureMessage = null, PaymentMethod PaymentMethod = null,
            Details Details = null)
        {
            this.Id = Id;
            this.MonthlyInstallments = MonthlyInstallments;
            this.Refunds = Refunds;
            this.Livemode = Livemode;
            this.Cash = Cash;
            this.Description = Description;
            this.Amount = Amount;
            this.Currency = Currency;
            this.ReferenceId = ReferenceId;
            this.Bank = Bank;
            this.Card = Card;
            this.FailureCode = FailureCode;
            this.FailureMessage = FailureMessage;
            this.PaymentMethod = PaymentMethod;
            this.Details = Details;
        }


        /// <summary>
        ///     Charge object id
        /// </summary>
        /// <value>Charge object id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets MonthlyInstallments
        /// </summary>
        [DataMember(Name = "monthly_installments", EmitDefaultValue = false)]
        public string MonthlyInstallments { get; set; }

        /// <summary>
        ///     Gets or Sets Refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public List<Refunds> Refunds { get; set; }

        /// <summary>
        ///     Live mode
        /// </summary>
        /// <value>Live mode</value>
        [DataMember(Name = "livemode", EmitDefaultValue = false)]
        public bool? Livemode { get; set; }

        /// <summary>
        ///     Gets or Sets Cash
        /// </summary>
        [DataMember(Name = "cash", EmitDefaultValue = false)]
        public Cash Cash { get; set; }

        /// <summary>
        ///     Charge Description
        /// </summary>
        /// <value>Charge Description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     ammount without decimal places
        /// </summary>
        /// <value>ammount without decimal places</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int? Amount { get; set; }

        /// <summary>
        ///     Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        ///     Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        ///     Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public ChargeBank Bank { get; set; }

        /// <summary>
        ///     token card
        /// </summary>
        /// <value>token card</value>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public string Card { get; set; }

        /// <summary>
        ///     Gets or Sets FailureCode
        /// </summary>
        [DataMember(Name = "failure_code", EmitDefaultValue = false)]
        public string FailureCode { get; set; }

        /// <summary>
        ///     Gets or Sets FailureMessage
        /// </summary>
        [DataMember(Name = "failure_message", EmitDefaultValue = false)]
        public string FailureMessage { get; set; }

        /// <summary>
        ///     Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        ///     Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Details Details { get; set; }

        /// <summary>
        ///     Returns true if Charge instances are equal
        /// </summary>
        /// <param name="other">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge other)
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
                    MonthlyInstallments == other.MonthlyInstallments ||
                    MonthlyInstallments != null &&
                    MonthlyInstallments.Equals(other.MonthlyInstallments)
                    ) &&
                (
                    Refunds == other.Refunds ||
                    Refunds != null &&
                    Refunds.SequenceEqual(other.Refunds)
                    ) &&
                (
                    Livemode == other.Livemode ||
                    Livemode != null &&
                    Livemode.Equals(other.Livemode)
                    ) &&
                (
                    Cash == other.Cash ||
                    Cash != null &&
                    Cash.Equals(other.Cash)
                    ) &&
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    ReferenceId == other.ReferenceId ||
                    ReferenceId != null &&
                    ReferenceId.Equals(other.ReferenceId)
                    ) &&
                (
                    Bank == other.Bank ||
                    Bank != null &&
                    Bank.Equals(other.Bank)
                    ) &&
                (
                    Card == other.Card ||
                    Card != null &&
                    Card.Equals(other.Card)
                    ) &&
                (
                    FailureCode == other.FailureCode ||
                    FailureCode != null &&
                    FailureCode.Equals(other.FailureCode)
                    ) &&
                (
                    FailureMessage == other.FailureMessage ||
                    FailureMessage != null &&
                    FailureMessage.Equals(other.FailureMessage)
                    ) &&
                (
                    PaymentMethod == other.PaymentMethod ||
                    PaymentMethod != null &&
                    PaymentMethod.Equals(other.PaymentMethod)
                    ) &&
                (
                    Details == other.Details ||
                    Details != null &&
                    Details.Equals(other.Details)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MonthlyInstallments: ").Append(MonthlyInstallments).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Cash: ").Append(Cash).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  FailureCode: ").Append(FailureCode).Append("\n");
            sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");

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
            return Equals(obj as Charge);
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

                if (MonthlyInstallments != null)
                    hash = hash*59 + MonthlyInstallments.GetHashCode();

                if (Refunds != null)
                    hash = hash*59 + Refunds.GetHashCode();

                if (Livemode != null)
                    hash = hash*59 + Livemode.GetHashCode();

                if (Cash != null)
                    hash = hash*59 + Cash.GetHashCode();

                if (Description != null)
                    hash = hash*59 + Description.GetHashCode();

                if (Amount != null)
                    hash = hash*59 + Amount.GetHashCode();

                if (Currency != null)
                    hash = hash*59 + Currency.GetHashCode();

                if (ReferenceId != null)
                    hash = hash*59 + ReferenceId.GetHashCode();

                if (Bank != null)
                    hash = hash*59 + Bank.GetHashCode();

                if (Card != null)
                    hash = hash*59 + Card.GetHashCode();

                if (FailureCode != null)
                    hash = hash*59 + FailureCode.GetHashCode();

                if (FailureMessage != null)
                    hash = hash*59 + FailureMessage.GetHashCode();

                if (PaymentMethod != null)
                    hash = hash*59 + PaymentMethod.GetHashCode();

                if (Details != null)
                    hash = hash*59 + Details.GetHashCode();

                return hash;
            }
        }
    }
}