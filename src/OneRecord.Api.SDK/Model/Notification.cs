/*
 * ONE Record API Documentation
 *
 * This OpenAPI specification describes the API endpoint structure of an ONE Record API implementation.<br/><br/><b>Note:</b><br/>The included schemas can only be used to generate JSON-LD in the extended document form.<br/>However, to be fully ONE Record compliant, any ONE Record API (and any compliant ONE Record client)<br/><b>MUST</b> support at least the expanded, compacted, and flattened document forms.<br/><br/>More information about the ONE Record specification are available on [IATA Github repository](https://github.com/IATA-Cargo/ONE-Record) and on the [ONE Record Developer Portal](https://onerecord.iata.org).
 *
 * The version of the OpenAPI document: 2.0.0-dev
 * Contact: onerecord@iata.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OneRecord.Api.SDK.Model
{
    /// <summary>
    /// Notification
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class Notification : IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsApihasEventType">ApihasEventType.</param>
        /// <param name="httpsApihasLogisticsObject">ApihasLogisticsObject.</param>
        /// <param name="httpsApihasLogisticsObjectType">ApihasLogisticsObjectType.</param>
        /// <param name="httpsApiisTriggeredBy">ApiisTriggeredBy.</param>
        /// <param name="httpsApihasChangedProperty">ApihasChangedProperty.</param>
        public Notification(string httpsId = default(string), List<string> httpsType = default(List<string>), NotificationEventType httpsApihasEventType = default(NotificationEventType), LogisticsObject httpsApihasLogisticsObject = default(LogisticsObject), string httpsApihasLogisticsObjectType = default(string), ActionRequest httpsApiisTriggeredBy = default(ActionRequest), List<string> httpsApihasChangedProperty = default(List<string>))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsApihasEventType = httpsApihasEventType;
            this.HttpsApihasLogisticsObject = httpsApihasLogisticsObject;
            this.HttpsApihasLogisticsObjectType = httpsApihasLogisticsObjectType;
            this.HttpsApiisTriggeredBy = httpsApiisTriggeredBy;
            this.HttpsApihasChangedProperty = httpsApihasChangedProperty;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "@id", EmitDefaultValue = false)]
        public string HttpsId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "@type", EmitDefaultValue = false)]
        public List<string> HttpsType { get; set; }

        /// <summary>
        /// Gets or Sets ApihasEventType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasEventType", EmitDefaultValue = false)]
        public NotificationEventType HttpsApihasEventType { get; set; }

        /// <summary>
        /// Gets or Sets ApihasLogisticsObject
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasLogisticsObject", EmitDefaultValue = false)]
        public LogisticsObject HttpsApihasLogisticsObject { get; set; }

        /// <summary>
        /// Gets or Sets ApihasLogisticsObjectType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasLogisticsObjectType", EmitDefaultValue = false)]
        public string HttpsApihasLogisticsObjectType { get; set; }

        /// <summary>
        /// Gets or Sets ApiisTriggeredBy
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#isTriggeredBy", EmitDefaultValue = false)]
        public ActionRequest HttpsApiisTriggeredBy { get; set; }

        /// <summary>
        /// Gets or Sets ApihasChangedProperty
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasChangedProperty", EmitDefaultValue = false)]
        public List<string> HttpsApihasChangedProperty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  ApihasEventType: ").Append(HttpsApihasEventType).Append("\n");
            sb.Append("  ApihasLogisticsObject: ").Append(HttpsApihasLogisticsObject).Append("\n");
            sb.Append("  ApihasLogisticsObjectType: ").Append(HttpsApihasLogisticsObjectType).Append("\n");
            sb.Append("  ApiisTriggeredBy: ").Append(HttpsApiisTriggeredBy).Append("\n");
            sb.Append("  ApihasChangedProperty: ").Append(HttpsApihasChangedProperty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="httpsInput">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object httpsInput)
        {
            return this.Equals(httpsInput as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification httpsInput)
        {
            if (httpsInput == null)
            {
                return false;
            }
            return 
                (
                    this.HttpsId == httpsInput.HttpsId ||
                    (this.HttpsId != null &&
                    this.HttpsId.Equals(httpsInput.HttpsId))
                ) && 
                (
                    this.HttpsType == httpsInput.HttpsType ||
                    this.HttpsType != null &&
                    httpsInput.HttpsType != null &&
                    this.HttpsType.SequenceEqual(httpsInput.HttpsType)
                ) && 
                (
                    this.HttpsApihasEventType == httpsInput.HttpsApihasEventType ||
                    (this.HttpsApihasEventType != null &&
                    this.HttpsApihasEventType.Equals(httpsInput.HttpsApihasEventType))
                ) && 
                (
                    this.HttpsApihasLogisticsObject == httpsInput.HttpsApihasLogisticsObject ||
                    (this.HttpsApihasLogisticsObject != null &&
                    this.HttpsApihasLogisticsObject.Equals(httpsInput.HttpsApihasLogisticsObject))
                ) && 
                (
                    this.HttpsApihasLogisticsObjectType == httpsInput.HttpsApihasLogisticsObjectType ||
                    (this.HttpsApihasLogisticsObjectType != null &&
                    this.HttpsApihasLogisticsObjectType.Equals(httpsInput.HttpsApihasLogisticsObjectType))
                ) && 
                (
                    this.HttpsApiisTriggeredBy == httpsInput.HttpsApiisTriggeredBy ||
                    (this.HttpsApiisTriggeredBy != null &&
                    this.HttpsApiisTriggeredBy.Equals(httpsInput.HttpsApiisTriggeredBy))
                ) && 
                (
                    this.HttpsApihasChangedProperty == httpsInput.HttpsApihasChangedProperty ||
                    this.HttpsApihasChangedProperty != null &&
                    httpsInput.HttpsApihasChangedProperty != null &&
                    this.HttpsApihasChangedProperty.SequenceEqual(httpsInput.HttpsApihasChangedProperty)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.HttpsId != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsId.GetHashCode();
                }
                if (this.HttpsType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsType.GetHashCode();
                }
                if (this.HttpsApihasEventType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasEventType.GetHashCode();
                }
                if (this.HttpsApihasLogisticsObject != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasLogisticsObject.GetHashCode();
                }
                if (this.HttpsApihasLogisticsObjectType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasLogisticsObjectType.GetHashCode();
                }
                if (this.HttpsApiisTriggeredBy != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApiisTriggeredBy.GetHashCode();
                }
                if (this.HttpsApihasChangedProperty != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasChangedProperty.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="httpsValidationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext httpsValidationContext)
        {
            yield break;
        }
    }

}
