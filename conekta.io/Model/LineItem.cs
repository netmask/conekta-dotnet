using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class LineItem : IEquatable<LineItem>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LineItem" /> class.
        ///     Initializes a new instance of the <see cref="LineItem" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="UnitPrice">UnitPrice.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="Category">Category.</param>
        public LineItem(string Name = null, string Description = null, int? UnitPrice = null, int? Quantity = null,
            string Sku = null, string Category = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.Sku = Sku;
            this.Category = Category;
        }


        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name = "unit_price", EmitDefaultValue = false)]
        public int? UnitPrice { get; set; }

        /// <summary>
        ///     Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        ///     Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        ///     Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        ///     Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                    ) &&
                (
                    UnitPrice == other.UnitPrice ||
                    UnitPrice != null &&
                    UnitPrice.Equals(other.UnitPrice)
                    ) &&
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                    ) &&
                (
                    Sku == other.Sku ||
                    Sku != null &&
                    Sku.Equals(other.Sku)
                    ) &&
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");

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
            return Equals(obj as LineItem);
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

                if (Description != null)
                    hash = hash*59 + Description.GetHashCode();

                if (UnitPrice != null)
                    hash = hash*59 + UnitPrice.GetHashCode();

                if (Quantity != null)
                    hash = hash*59 + Quantity.GetHashCode();

                if (Sku != null)
                    hash = hash*59 + Sku.GetHashCode();

                if (Category != null)
                    hash = hash*59 + Category.GetHashCode();

                return hash;
            }
        }
    }
}