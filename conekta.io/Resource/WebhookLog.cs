using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace conekta.io.Resource
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class WebhookLog : IEquatable<WebhookLog>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLog" /> class.
        /// Initializes a new instance of the <see cref="WebhookLog" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Url">Url.</param>
        /// <param name="FailedAttempts">FailedAttempts.</param>
        /// <param name="LastHttpResponseStatus">LastHttpResponseStatus.</param>
        /// <param name="_Object">_Object.</param>
        /// <param name="LastAttemptedAt">LastAttemptedAt.</param>

        public WebhookLog(string Id = null, string Url = null, string FailedAttempts = null, string LastHttpResponseStatus = null, string _Object = null, string LastAttemptedAt = null)
        {
            this.Id = Id;
            this.Url = Url;
            this.FailedAttempts = FailedAttempts;
            this.LastHttpResponseStatus = LastHttpResponseStatus;
            this._Object = _Object;
            this.LastAttemptedAt = LastAttemptedAt;

        }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets FailedAttempts
        /// </summary>
        [DataMember(Name = "failed_attempts", EmitDefaultValue = false)]
        public string FailedAttempts { get; set; }

        /// <summary>
        /// Gets or Sets LastHttpResponseStatus
        /// </summary>
        [DataMember(Name = "last_http_response_status", EmitDefaultValue = false)]
        public string LastHttpResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string _Object { get; set; }

        /// <summary>
        /// Gets or Sets LastAttemptedAt
        /// </summary>
        [DataMember(Name = "last_attempted_at", EmitDefaultValue = false)]
        public string LastAttemptedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
            sb.Append("  LastHttpResponseStatus: ").Append(LastHttpResponseStatus).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  LastAttemptedAt: ").Append(LastAttemptedAt).Append("\n");

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
            return this.Equals(obj as WebhookLog);
        }

        /// <summary>
        /// Returns true if WebhookLog instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLog other)
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.FailedAttempts == other.FailedAttempts ||
                    this.FailedAttempts != null &&
                    this.FailedAttempts.Equals(other.FailedAttempts)
                ) &&
                (
                    this.LastHttpResponseStatus == other.LastHttpResponseStatus ||
                    this.LastHttpResponseStatus != null &&
                    this.LastHttpResponseStatus.Equals(other.LastHttpResponseStatus)
                ) &&
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) &&
                (
                    this.LastAttemptedAt == other.LastAttemptedAt ||
                    this.LastAttemptedAt != null &&
                    this.LastAttemptedAt.Equals(other.LastAttemptedAt)
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

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.FailedAttempts != null)
                    hash = hash * 59 + this.FailedAttempts.GetHashCode();

                if (this.LastHttpResponseStatus != null)
                    hash = hash * 59 + this.LastHttpResponseStatus.GetHashCode();

                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();

                if (this.LastAttemptedAt != null)
                    hash = hash * 59 + this.LastAttemptedAt.GetHashCode();

                return hash;
            }
        }

    }
}
