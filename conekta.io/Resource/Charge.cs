using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using conekta.io.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta.io.Resource
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Charge : IEquatable<Charge>
    {
        public static Charge Create(String charge)
        {
            return Create(JObject.Parse(charge));
        }

        public static Charge Create(JObject charge)
        {
            var api = new DefaultApi();
            return api.ChargesPost(charge.ToObject<Charge>());
        }

        public static Charge Find(String id)
        {
            var api = new DefaultApi();
            return api.ChargesChargeIdGet(id);
        }

        public Charge Refund()
        {
            return Refund(this.Amount);
        }

        public Charge Refund(int? amount)
        {
            var api = new DefaultApi();
            return api.ChargesChargeIdRefundPost(this.Id, new AmountQty(amount));
        }

        public Charge capture()
        {
            var api = new DefaultApi();
            return api.ChargesChargeIdCapturePost(this.Id);
        }

        public static List<Charge> Where(string query)
        {
            var api = new DefaultApi();
            var parsedParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(query);

            return api.ChargesGet();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// Initializes a new instance of the <see cref="Charge" />class.
        /// </summary>
        /// <param name="Id">Charge object id.</param>
        /// <param name="Status">Charge status.</param>
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

        public Charge(string Id = null, bool Capture = true, string Status = null, string MonthlyInstallments = null, List<Refunds> Refunds = null, bool? Livemode = null, Cash Cash = null, string Description = null, int? Amount = null, string Currency = null, string ReferenceId = null, ChargeBank Bank = null, string Card = null, string FailureCode = null, string FailureMessage = null, PaymentMethod PaymentMethod = null, Details Details = null)
        {
            this.Id = Id;
            this.Status = Status;
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
            this.Capture = Capture;
        }


        [DataMember(Name = "capture", EmitDefaultValue = true)]
        public bool Capture { get; set; }

        /// <summary>
        /// Charge object id
        /// </summary>
        /// <value>Charge object id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Charge status
        /// </summary>
        /// <value>Charge status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstallments
        /// </summary>
        [DataMember(Name = "monthly_installments", EmitDefaultValue = false)]
        public string MonthlyInstallments { get; set; }

        /// <summary>
        /// Gets or Sets Refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public List<Refunds> Refunds { get; set; }

        /// <summary>
        /// Live mode
        /// </summary>
        /// <value>Live mode</value>
        [DataMember(Name = "livemode", EmitDefaultValue = false)]
        public bool? Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Cash
        /// </summary>
        [DataMember(Name = "cash", EmitDefaultValue = false)]
        public Cash Cash { get; set; }

        /// <summary>
        /// Charge Description
        /// </summary>
        /// <value>Charge Description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// ammount without decimal places
        /// </summary>
        /// <value>ammount without decimal places</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public ChargeBank Bank { get; set; }

        /// <summary>
        /// token card
        /// </summary>
        /// <value>token card</value>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public string Card { get; set; }

        /// <summary>
        /// Gets or Sets FailureCode
        /// </summary>
        [DataMember(Name = "failure_code", EmitDefaultValue = false)]
        public string FailureCode { get; set; }

        /// <summary>
        /// Gets or Sets FailureMessage
        /// </summary>
        [DataMember(Name = "failure_message", EmitDefaultValue = false)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Details Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Charge);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.MonthlyInstallments == other.MonthlyInstallments ||
                    this.MonthlyInstallments != null &&
                    this.MonthlyInstallments.Equals(other.MonthlyInstallments)
                ) &&
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
                ) &&
                (
                    this.Livemode == other.Livemode ||
                    this.Livemode != null &&
                    this.Livemode.Equals(other.Livemode)
                ) &&
                (
                    this.Cash == other.Cash ||
                    this.Cash != null &&
                    this.Cash.Equals(other.Cash)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) &&
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) &&
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
                ) &&
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) &&
                (
                    this.FailureCode == other.FailureCode ||
                    this.FailureCode != null &&
                    this.FailureCode.Equals(other.FailureCode)
                ) &&
                (
                    this.FailureMessage == other.FailureMessage ||
                    this.FailureMessage != null &&
                    this.FailureMessage.Equals(other.FailureMessage)
                ) &&
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.MonthlyInstallments != null)
                    hash = hash * 59 + this.MonthlyInstallments.GetHashCode();

                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();

                if (this.Livemode != null)
                    hash = hash * 59 + this.Livemode.GetHashCode();

                if (this.Cash != null)
                    hash = hash * 59 + this.Cash.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();

                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();

                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();

                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();

                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();

                if (this.FailureCode != null)
                    hash = hash * 59 + this.FailureCode.GetHashCode();

                if (this.FailureMessage != null)
                    hash = hash * 59 + this.FailureMessage.GetHashCode();

                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                return hash;
            }
        }

    }
}