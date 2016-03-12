using System;
using System.Runtime.Serialization;
using System.Text;
using conekta.io.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Plan : IEquatable<Plan>
    {

        public static Plan Create(JObject planParams)
        {
            var api  = new DefaultApi();
            return api.PlansPost(planParams.ToObject<Plan>());
        }

        public void Update(JObject planParams)
        {
            var api = new DefaultApi();
            LoadFrom(api.PlansPlanIdPut(this.Id, planParams.ToObject<Plan>()));        
        }

        public void Delete()
        {
            var api = new DefaultApi();
            LoadFrom(api.PlansPlanIdDelete(this.Id));
        }


        /// <summary>
        ///     Initializes a new instance of the <see cref="Plan" /> class.
        ///     Initializes a new instance of the <see cref="Plan" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="Livemode">Livemode.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Interval">Interval.</param>
        /// <param name="Frequency">Frequency.</param>
        /// <param name="IntervalTotalCount">IntervalTotalCount.</param>
        /// <param name="TrialPeriodDays">TrialPeriodDays.</param>
        public Plan(string Id = null, string _Object = null, bool? Livemode = null, string CreatedAt = null,
            string Name = null, string Amount = null, string Currency = null, String Interval = null,
            int? Frequency = null, int? IntervalTotalCount = null, int? TrialPeriodDays = null)
        {
            this.Id = Id;
            this._Object = _Object;
            this.Livemode = Livemode;
            this.CreatedAt = CreatedAt;
            this.Name = Name;
            this.Amount = Amount;
            this.Currency = Currency;
            this.Interval = Interval;
            this.Frequency = Frequency;
            this.IntervalTotalCount = IntervalTotalCount;
            this.TrialPeriodDays = TrialPeriodDays;
        }

        public void LoadFrom(Plan plan)
        {
            this.Id = plan.Id;
            this._Object = plan._Object;
            this.Livemode = plan.Livemode;
            this.CreatedAt = plan.CreatedAt;
            this.Name = plan.Name;
            this.Amount = plan.Amount;
            this.Currency = plan.Currency;
            this.Interval = plan.Interval;
            this.Frequency = plan.Frequency;
            this.IntervalTotalCount = plan.IntervalTotalCount;
            this.TrialPeriodDays = plan.TrialPeriodDays;
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
        ///     Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = false)]
        public bool? Livemode { get; set; }

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
        ///     Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        ///     Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        ///     Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public String Interval { get; set; }

        /// <summary>
        ///     Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public int? Frequency { get; set; }

        /// <summary>
        ///     Gets or Sets IntervalTotalCount
        /// </summary>
        [DataMember(Name = "interval_total_count", EmitDefaultValue = false)]
        public int? IntervalTotalCount { get; set; }

        /// <summary>
        ///     Gets or Sets TrialPeriodDays
        /// </summary>
        [DataMember(Name = "trial_period_days", EmitDefaultValue = false)]
        public int? TrialPeriodDays { get; set; }

        /// <summary>
        ///     Returns true if Plan instances are equal
        /// </summary>
        /// <param name="other">Instance of Plan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plan other)
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
                    Livemode == other.Livemode ||
                    Livemode != null &&
                    Livemode.Equals(other.Livemode)
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
                    Interval == other.Interval ||
                    Interval != null &&
                    Interval.Equals(other.Interval)
                    ) &&
                (
                    Frequency == other.Frequency ||
                    Frequency != null &&
                    Frequency.Equals(other.Frequency)
                    ) &&
                (
                    IntervalTotalCount == other.IntervalTotalCount ||
                    IntervalTotalCount != null &&
                    IntervalTotalCount.Equals(other.IntervalTotalCount)
                    ) &&
                (
                    TrialPeriodDays == other.TrialPeriodDays ||
                    TrialPeriodDays != null &&
                    TrialPeriodDays.Equals(other.TrialPeriodDays)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Plan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  IntervalTotalCount: ").Append(IntervalTotalCount).Append("\n");
            sb.Append("  TrialPeriodDays: ").Append(TrialPeriodDays).Append("\n");

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
            return Equals(obj as Plan);
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

                if (Livemode != null)
                    hash = hash*59 + Livemode.GetHashCode();

                if (CreatedAt != null)
                    hash = hash*59 + CreatedAt.GetHashCode();

                if (Name != null)
                    hash = hash*59 + Name.GetHashCode();

                if (Amount != null)
                    hash = hash*59 + Amount.GetHashCode();

                if (Currency != null)
                    hash = hash*59 + Currency.GetHashCode();

                if (Interval != null)
                    hash = hash*59 + Interval.GetHashCode();

                if (Frequency != null)
                    hash = hash*59 + Frequency.GetHashCode();

                if (IntervalTotalCount != null)
                    hash = hash*59 + IntervalTotalCount.GetHashCode();

                if (TrialPeriodDays != null)
                    hash = hash*59 + TrialPeriodDays.GetHashCode();

                return hash;
            }
        }
    }
}