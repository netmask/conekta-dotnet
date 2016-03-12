using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using conekta.io.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta.io.Resource
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Customer : IEquatable<Customer>
    {

        public static Customer Create(JObject customer)
        {
            var api = new DefaultApi();
            return api.CustomersPost(customer.ToObject<BaseClient>());
        }

        public static Customer Find(String id)
        {
            var api = new DefaultApi();
            return api.CustomersCustomerIdGet(id);
        }

        public void Update(JObject customer)
        {           
            var api = new DefaultApi();
            this.LoadFromCustomer(api.CustomersCustomerIdPut(this.Id, customer.ToObject<BaseClient>()));
        }

        public void Delete()
        {
            var api = new DefaultApi();
            LoadFromCustomer(api.CustomersCustomerIdDelete(this.Id));
        }

        public void CreateCard(JObject newCard)
        {
            var api = new DefaultApi();
            var card = api.CustomersCustomerIdCardsPost(this.Id, newCard.ToObject<TokenObject>());
            card.Customer = this;
            this.Cards.Add(card);            
        }

        public void DeleteCard(Card card)
        {
            var api = new DefaultApi();
            api.CustomersCustomerIdCardsCardIdDelete(this.Id, card.Id);
            this.Cards.Remove(card);
        }

        public Subscription CreateSubscription(JObject subscriptionObject)
        {
            var api = new DefaultApi();
            this.Subscription = api.CustomersCustomerIdSubscriptionPost(this.Id, subscriptionObject.ToObject<SubscriptionReference>());
            this.Subscription.Customer = this;        
            return this.Subscription;
        }


        /// <sumary>
        ///     Initializes a new instance of the <see cref="Customer" /> class.
        ///     Initializes a new instance of the <see cref="Customer" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="Livemode">Livemode.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="DefaultCard">DefaultCard.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        /// <param name="ShippingAddress">ShippingAddress.</param>
        /// <param name="Cards">Cards.</param>
        /// <param name="Subscriptions">Subscriptions.</param>
        public Customer(string Id = null, string _Object = null, string Livemode = null, string CreatedAt = null,
            string Name = null, string Email = null, string Phone = null, string DefaultCard = null,
            BillingAddress BillingAddress = null, BillingAddress ShippingAddress = null,
            List<Card> Cards = null, Subscription Subscription = null, bool Deleted = false)
        {
            this.Id = Id;
            this._Object = _Object;
            this.Livemode = Livemode;
            this.CreatedAt = CreatedAt;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.DefaultCard = DefaultCard;
            this.BillingAddress = BillingAddress;
            this.ShippingAddress = ShippingAddress;
            this.Cards = Cards;
            this.Subscription = Subscription;
            this.Deleted = Deleted;
            
            foreach (var card in Cards)
            {
                card.Customer = this;
            }
        }

        public void LoadFromCustomer(Customer customer)
        {
            this.Id = customer.Id;
            this._Object = customer._Object;
            this.Livemode = customer.Livemode;
            this.CreatedAt = customer.CreatedAt;
            this.Name = customer.Name;
            this.Email = customer.Email;
            this.Phone = customer.Phone;
            this.DefaultCard = customer.DefaultCard;
            this.Deleted = customer.Deleted;

        }


        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool Deleted { get; set; }

        /// <summary>
        ///     Gets or Sets _Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string _Object { get; set; }

        /// <summary>
        ///     Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = false)]
        public string Livemode { get; set; }

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
        ///     Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        ///     Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        ///     Gets or Sets DefaultCard
        /// </summary>
        [DataMember(Name = "default_card", EmitDefaultValue = false)]
        public string DefaultCard { get; set; }

        /// <summary>
        ///     Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billing_address", EmitDefaultValue = false)]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        ///     Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public BillingAddress ShippingAddress { get; set; }

        /// <summary>
        ///     Gets or Sets Cards
        /// </summary>
        [DataMember(Name = "cards", EmitDefaultValue = false)]
        public List<Card> Cards { get; set; }

        /// <summary>
        ///     Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public Subscription Subscription { get; set; }

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
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                    ) &&
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                    ) &&
                (
                    DefaultCard == other.DefaultCard ||
                    DefaultCard != null &&
                    DefaultCard.Equals(other.DefaultCard)
                    ) &&
                (
                    BillingAddress == other.BillingAddress ||
                    BillingAddress != null &&
                    BillingAddress.Equals(other.BillingAddress)
                    ) &&
                (
                    ShippingAddress == other.ShippingAddress ||
                    ShippingAddress != null &&
                    ShippingAddress.Equals(other.ShippingAddress)
                    ) &&
                (
                    Cards == other.Cards ||
                    Cards != null &&
                    Cards.SequenceEqual(other.Cards)
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
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  DefaultCard: ").Append(DefaultCard).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");

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

                if (Email != null)
                    hash = hash*59 + Email.GetHashCode();

                if (Phone != null)
                    hash = hash*59 + Phone.GetHashCode();

                if (DefaultCard != null)
                    hash = hash*59 + DefaultCard.GetHashCode();

                if (BillingAddress != null)
                    hash = hash*59 + BillingAddress.GetHashCode();

                if (ShippingAddress != null)
                    hash = hash*59 + ShippingAddress.GetHashCode();

                if (Cards != null)
                    hash = hash*59 + Cards.GetHashCode();

                return hash;
            }
        }
    }
}