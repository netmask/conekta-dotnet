using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class PaymentMethod : IEquatable<PaymentMethod>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PaymentMethod" /> class.
        ///     Initializes a new instance of the <see cref="PaymentMethod" />class.
        /// </summary>
        /// <param name="_Object">_Object.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ExpMonth">ExpMonth.</param>
        /// <param name="ExpYear">ExpYear.</param>
        /// <param name="AuthCode">AuthCode.</param>
        /// <param name="Last4">Last4.</param>
        /// <param name="Brand">Brand.</param>
        /// <param name="Type">Type.</param>
        /// <param name="BarcodeUrl">BarcodeUrl.</param>
        /// <param name="Barcode">Barcode.</param>
        /// <param name="Address">Address.</param>
        public PaymentMethod(string _Object = null, string Name = null, int? ExpMonth = null, int? ExpYear = null,
            string AuthCode = null, string Last4 = null, string Brand = null, string Type = null,
            string BarcodeUrl = null, string Barcode = null, BillingAddress Address = null)
        {
            this._Object = _Object;
            this.Name = Name;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.AuthCode = AuthCode;
            this.Last4 = Last4;
            this.Brand = Brand;
            this.Type = Type;
            this.BarcodeUrl = BarcodeUrl;
            this.Barcode = Barcode;
            this.Address = Address;
        }


        /// <summary>
        ///     Gets or Sets _Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string _Object { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name = "exp_month", EmitDefaultValue = false)]
        public int? ExpMonth { get; set; }

        /// <summary>
        ///     Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name = "exp_year", EmitDefaultValue = false)]
        public int? ExpYear { get; set; }

        /// <summary>
        ///     Gets or Sets AuthCode
        /// </summary>
        [DataMember(Name = "auth_code", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     Gets or Sets Last4
        /// </summary>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        ///     Gets or Sets Brand
        /// </summary>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Gets or Sets BarcodeUrl
        /// </summary>
        [DataMember(Name = "barcode_url", EmitDefaultValue = false)]
        public string BarcodeUrl { get; set; }

        /// <summary>
        ///     Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "barcode", EmitDefaultValue = false)]
        public string Barcode { get; set; }

        /// <summary>
        ///     Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public BillingAddress Address { get; set; }

        /// <summary>
        ///     Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    _Object == other._Object ||
                    _Object != null &&
                    _Object.Equals(other._Object)
                    ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    AuthCode == other.AuthCode ||
                    AuthCode != null &&
                    AuthCode.Equals(other.AuthCode)
                    ) &&
                (
                    Last4 == other.Last4 ||
                    Last4 != null &&
                    Last4.Equals(other.Last4)
                    ) &&
                (
                    Brand == other.Brand ||
                    Brand != null &&
                    Brand.Equals(other.Brand)
                    ) &&
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                    ) &&
                (
                    BarcodeUrl == other.BarcodeUrl ||
                    BarcodeUrl != null &&
                    BarcodeUrl.Equals(other.BarcodeUrl)
                    ) &&
                (
                    Barcode == other.Barcode ||
                    Barcode != null &&
                    Barcode.Equals(other.Barcode)
                    ) &&
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BarcodeUrl: ").Append(BarcodeUrl).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");

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
            return Equals(obj as PaymentMethod);
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

                if (_Object != null)
                    hash = hash*59 + _Object.GetHashCode();

                if (Name != null)
                    hash = hash*59 + Name.GetHashCode();

                if (ExpMonth != null)
                    hash = hash*59 + ExpMonth.GetHashCode();

                if (ExpYear != null)
                    hash = hash*59 + ExpYear.GetHashCode();

                if (AuthCode != null)
                    hash = hash*59 + AuthCode.GetHashCode();

                if (Last4 != null)
                    hash = hash*59 + Last4.GetHashCode();

                if (Brand != null)
                    hash = hash*59 + Brand.GetHashCode();

                if (Type != null)
                    hash = hash*59 + Type.GetHashCode();

                if (BarcodeUrl != null)
                    hash = hash*59 + BarcodeUrl.GetHashCode();

                if (Barcode != null)
                    hash = hash*59 + Barcode.GetHashCode();

                if (Address != null)
                    hash = hash*59 + Address.GetHashCode();

                return hash;
            }
        }
    }
}