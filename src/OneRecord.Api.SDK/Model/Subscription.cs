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
    /// Subscription
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class Subscription : IEquatable<Subscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsApihasSubscriber">ApihasSubscriber.</param>
        /// <param name="httpsApihasTopicType">ApihasTopicType.</param>
        /// <param name="httpsApiexpiresAt">ApiexpiresAt.</param>
        /// <param name="httpsApihasContentType">ApihasContentType.</param>
        /// <param name="httpsApihasDescription">ApihasDescription.</param>
        /// <param name="httpsApihasTopic">ApihasTopic.</param>
        /// <param name="httpsApinotifyRequestStatusChange">ApinotifyRequestStatusChange.</param>
        /// <param name="httpsApisendLogisticsObjectBody">ApisendLogisticsObjectBody.</param>
        /// <param name="httpsApiincludeSubscriptionEventType">ApiincludeSubscriptionEventType.</param>
        public Subscription(string httpsId = default(string), List<string> httpsType = default(List<string>), Organization httpsApihasSubscriber = default(Organization), TopicType httpsApihasTopicType = default(TopicType), DateTime httpsApiexpiresAt = default(DateTime), List<string> httpsApihasContentType = default(List<string>), string httpsApihasDescription = default(string), string httpsApihasTopic = default(string), List<string> httpsApinotifyRequestStatusChange = default(List<string>), List<string> httpsApisendLogisticsObjectBody = default(List<string>), List<string> httpsApiincludeSubscriptionEventType = default(List<string>))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsApihasSubscriber = httpsApihasSubscriber;
            this.HttpsApihasTopicType = httpsApihasTopicType;
            this.HttpsApiexpiresAt = httpsApiexpiresAt;
            this.HttpsApihasContentType = httpsApihasContentType;
            this.HttpsApihasDescription = httpsApihasDescription;
            this.HttpsApihasTopic = httpsApihasTopic;
            this.HttpsApinotifyRequestStatusChange = httpsApinotifyRequestStatusChange;
            this.HttpsApisendLogisticsObjectBody = httpsApisendLogisticsObjectBody;
            this.HttpsApiincludeSubscriptionEventType = httpsApiincludeSubscriptionEventType;
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
        /// Gets or Sets ApihasSubscriber
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasSubscriber", EmitDefaultValue = false)]
        public Organization HttpsApihasSubscriber { get; set; }

        /// <summary>
        /// Gets or Sets ApihasTopicType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasTopicType", EmitDefaultValue = false)]
        public TopicType HttpsApihasTopicType { get; set; }

        /// <summary>
        /// Gets or Sets ApiexpiresAt
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#expiresAt", EmitDefaultValue = false)]
        public DateTime HttpsApiexpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets ApihasContentType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasContentType", EmitDefaultValue = false)]
        public List<string> HttpsApihasContentType { get; set; }

        /// <summary>
        /// Gets or Sets ApihasDescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasDescription", EmitDefaultValue = false)]
        public string HttpsApihasDescription { get; set; }

        /// <summary>
        /// Gets or Sets ApihasTopic
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasTopic", EmitDefaultValue = false)]
        public string HttpsApihasTopic { get; set; }

        /// <summary>
        /// Gets or Sets ApinotifyRequestStatusChange
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#notifyRequestStatusChange", EmitDefaultValue = false)]
        public List<string> HttpsApinotifyRequestStatusChange { get; set; }

        /// <summary>
        /// Gets or Sets ApisendLogisticsObjectBody
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#sendLogisticsObjectBody", EmitDefaultValue = false)]
        public List<string> HttpsApisendLogisticsObjectBody { get; set; }

        /// <summary>
        /// Gets or Sets ApiincludeSubscriptionEventType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#includeSubscriptionEventType", EmitDefaultValue = false)]
        public List<string> HttpsApiincludeSubscriptionEventType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  ApihasSubscriber: ").Append(HttpsApihasSubscriber).Append("\n");
            sb.Append("  ApihasTopicType: ").Append(HttpsApihasTopicType).Append("\n");
            sb.Append("  ApiexpiresAt: ").Append(HttpsApiexpiresAt).Append("\n");
            sb.Append("  ApihasContentType: ").Append(HttpsApihasContentType).Append("\n");
            sb.Append("  ApihasDescription: ").Append(HttpsApihasDescription).Append("\n");
            sb.Append("  ApihasTopic: ").Append(HttpsApihasTopic).Append("\n");
            sb.Append("  ApinotifyRequestStatusChange: ").Append(HttpsApinotifyRequestStatusChange).Append("\n");
            sb.Append("  ApisendLogisticsObjectBody: ").Append(HttpsApisendLogisticsObjectBody).Append("\n");
            sb.Append("  ApiincludeSubscriptionEventType: ").Append(HttpsApiincludeSubscriptionEventType).Append("\n");
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
            return this.Equals(httpsInput as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription httpsInput)
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
                    this.HttpsApihasSubscriber == httpsInput.HttpsApihasSubscriber ||
                    (this.HttpsApihasSubscriber != null &&
                    this.HttpsApihasSubscriber.Equals(httpsInput.HttpsApihasSubscriber))
                ) && 
                (
                    this.HttpsApihasTopicType == httpsInput.HttpsApihasTopicType ||
                    (this.HttpsApihasTopicType != null &&
                    this.HttpsApihasTopicType.Equals(httpsInput.HttpsApihasTopicType))
                ) && 
                (
                    this.HttpsApiexpiresAt == httpsInput.HttpsApiexpiresAt ||
                    (this.HttpsApiexpiresAt != null &&
                    this.HttpsApiexpiresAt.Equals(httpsInput.HttpsApiexpiresAt))
                ) && 
                (
                    this.HttpsApihasContentType == httpsInput.HttpsApihasContentType ||
                    this.HttpsApihasContentType != null &&
                    httpsInput.HttpsApihasContentType != null &&
                    this.HttpsApihasContentType.SequenceEqual(httpsInput.HttpsApihasContentType)
                ) && 
                (
                    this.HttpsApihasDescription == httpsInput.HttpsApihasDescription ||
                    (this.HttpsApihasDescription != null &&
                    this.HttpsApihasDescription.Equals(httpsInput.HttpsApihasDescription))
                ) && 
                (
                    this.HttpsApihasTopic == httpsInput.HttpsApihasTopic ||
                    (this.HttpsApihasTopic != null &&
                    this.HttpsApihasTopic.Equals(httpsInput.HttpsApihasTopic))
                ) && 
                (
                    this.HttpsApinotifyRequestStatusChange == httpsInput.HttpsApinotifyRequestStatusChange ||
                    this.HttpsApinotifyRequestStatusChange != null &&
                    httpsInput.HttpsApinotifyRequestStatusChange != null &&
                    this.HttpsApinotifyRequestStatusChange.SequenceEqual(httpsInput.HttpsApinotifyRequestStatusChange)
                ) && 
                (
                    this.HttpsApisendLogisticsObjectBody == httpsInput.HttpsApisendLogisticsObjectBody ||
                    this.HttpsApisendLogisticsObjectBody != null &&
                    httpsInput.HttpsApisendLogisticsObjectBody != null &&
                    this.HttpsApisendLogisticsObjectBody.SequenceEqual(httpsInput.HttpsApisendLogisticsObjectBody)
                ) && 
                (
                    this.HttpsApiincludeSubscriptionEventType == httpsInput.HttpsApiincludeSubscriptionEventType ||
                    this.HttpsApiincludeSubscriptionEventType != null &&
                    httpsInput.HttpsApiincludeSubscriptionEventType != null &&
                    this.HttpsApiincludeSubscriptionEventType.SequenceEqual(httpsInput.HttpsApiincludeSubscriptionEventType)
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
                if (this.HttpsApihasSubscriber != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasSubscriber.GetHashCode();
                }
                if (this.HttpsApihasTopicType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasTopicType.GetHashCode();
                }
                if (this.HttpsApiexpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApiexpiresAt.GetHashCode();
                }
                if (this.HttpsApihasContentType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasContentType.GetHashCode();
                }
                if (this.HttpsApihasDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasDescription.GetHashCode();
                }
                if (this.HttpsApihasTopic != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasTopic.GetHashCode();
                }
                if (this.HttpsApinotifyRequestStatusChange != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApinotifyRequestStatusChange.GetHashCode();
                }
                if (this.HttpsApisendLogisticsObjectBody != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApisendLogisticsObjectBody.GetHashCode();
                }
                if (this.HttpsApiincludeSubscriptionEventType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApiincludeSubscriptionEventType.GetHashCode();
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
