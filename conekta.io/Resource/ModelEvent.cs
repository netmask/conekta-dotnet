using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using conekta.io.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace conekta.io.Resource
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ModelEvent : IEquatable<ModelEvent>
    {

        public static List<ModelEvent> FindAll()
        {
            var api = new DefaultApi();
            return api.EventsGet();
        }

        public static List<ModelEvent> Where(string query)
        {
            var api = new DefaultApi();
            var parsedParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(query);

            return api.EventsGet(parsedParams);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEvent" /> class.
        /// Initializes a new instance of the <see cref="ModelEvent" />class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="WebhookStatus">WebhookStatus.</param>
        /// <param name="WebhookLogs">WebhookLogs.</param>
        /// <param name="Livemode">Livemode.</param>
        /// <param name="Id">Id.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="Type">Type.</param>
        /// <param name="CreatedAt">CreatedAt.</param>

        public ModelEvent(Dictionary<string, Object> Data = null, string WebhookStatus = null, List<WebhookLog> WebhookLogs = null, string Livemode = null, string Id = null, string _Object = null, string Type = null, string CreatedAt = null)
        {
            this.Data = Data;
            this.WebhookStatus = WebhookStatus;
            this.WebhookLogs = WebhookLogs;
            this.Livemode = Livemode;
            this.Id = Id;
            this._Object = _Object;
            this.Type = Type;
            this.CreatedAt = CreatedAt;

        }


        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Gets or Sets WebhookStatus
        /// </summary>
        [DataMember(Name = "webhook_status", EmitDefaultValue = false)]
        public string WebhookStatus { get; set; }

        /// <summary>
        /// Gets or Sets WebhookLogs
        /// </summary>
        [DataMember(Name = "webhook_logs", EmitDefaultValue = false)]
        public List<WebhookLog> WebhookLogs { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = false)]
        public string Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string _Object { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelEvent {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  WebhookStatus: ").Append(WebhookStatus).Append("\n");
            sb.Append("  WebhookLogs: ").Append(WebhookLogs).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");

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
            return this.Equals(obj as ModelEvent);
        }

        /// <summary>
        /// Returns true if ModelEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.WebhookStatus == other.WebhookStatus ||
                    this.WebhookStatus != null &&
                    this.WebhookStatus.Equals(other.WebhookStatus)
                ) &&
                (
                    this.WebhookLogs == other.WebhookLogs ||
                    this.WebhookLogs != null &&
                    this.WebhookLogs.SequenceEqual(other.WebhookLogs)
                ) &&
                (
                    this.Livemode == other.Livemode ||
                    this.Livemode != null &&
                    this.Livemode.Equals(other.Livemode)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
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

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                if (this.WebhookStatus != null)
                    hash = hash * 59 + this.WebhookStatus.GetHashCode();

                if (this.WebhookLogs != null)
                    hash = hash * 59 + this.WebhookLogs.GetHashCode();

                if (this.Livemode != null)
                    hash = hash * 59 + this.Livemode.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();

                return hash;
            }
        }

    }
}
