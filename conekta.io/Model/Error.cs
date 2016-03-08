using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace conekta.io.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Error : IEquatable<Error>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Error" /> class.
        ///     Initializes a new instance of the <see cref="Error" />class.
        /// </summary>
        /// <param name="_Object">_Object.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Message">Message.</param>
        /// <param name="MessageToPurchaser">MessageToPurchaser.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Param">Param.</param>
        public Error(string _Object = null, string Type = null, string Message = null, string MessageToPurchaser = null,
            string Code = null, string Param = null)
        {
            this._Object = _Object;
            this.Type = Type;
            this.Message = Message;
            this.MessageToPurchaser = MessageToPurchaser;
            this.Code = Code;
            this.Param = Param;
        }


        /// <summary>
        ///     Gets or Sets _Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string _Object { get; set; }

        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or Sets MessageToPurchaser
        /// </summary>
        [DataMember(Name = "message_to_purchaser", EmitDefaultValue = false)]
        public string MessageToPurchaser { get; set; }

        /// <summary>
        ///     Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        ///     Gets or Sets Param
        /// </summary>
        [DataMember(Name = "param", EmitDefaultValue = false)]
        public string Param { get; set; }

        /// <summary>
        ///     Returns true if Error instances are equal
        /// </summary>
        /// <param name="other">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error other)
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
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                    ) &&
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                    ) &&
                (
                    MessageToPurchaser == other.MessageToPurchaser ||
                    MessageToPurchaser != null &&
                    MessageToPurchaser.Equals(other.MessageToPurchaser)
                    ) &&
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                    ) &&
                (
                    Param == other.Param ||
                    Param != null &&
                    Param.Equals(other.Param)
                    );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageToPurchaser: ").Append(MessageToPurchaser).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Param: ").Append(Param).Append("\n");

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
            return Equals(obj as Error);
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

                if (Type != null)
                    hash = hash*59 + Type.GetHashCode();

                if (Message != null)
                    hash = hash*59 + Message.GetHashCode();

                if (MessageToPurchaser != null)
                    hash = hash*59 + MessageToPurchaser.GetHashCode();

                if (Code != null)
                    hash = hash*59 + Code.GetHashCode();

                if (Param != null)
                    hash = hash*59 + Param.GetHashCode();

                return hash;
            }
        }
    }
}