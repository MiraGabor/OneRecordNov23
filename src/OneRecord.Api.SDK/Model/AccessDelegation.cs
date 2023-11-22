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
    /// AccessDelegation
    /// </summary>
    [DataContract(Name = "AccessDelegation")]
    public partial class AccessDelegation : IEquatable<AccessDelegation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessDelegation" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsApihasLogisticsObject">ApihasLogisticsObject.</param>
        /// <param name="httpsApihasPermission">ApihasPermission.</param>
        /// <param name="httpsApiisRequestedFor">ApiisRequestedFor.</param>
        /// <param name="httpsApihasDescription">ApihasDescription.</param>
        /// <param name="httpsApinotifyRequestStatusChange">ApinotifyRequestStatusChange.</param>
        public AccessDelegation(string httpsId = default(string), List<string> httpsType = default(List<string>), List<LogisticsObject> httpsApihasLogisticsObject = default(List<LogisticsObject>), List<Permission> httpsApihasPermission = default(List<Permission>), List<Organization> httpsApiisRequestedFor = default(List<Organization>), string httpsApihasDescription = default(string), bool httpsApinotifyRequestStatusChange = default(bool))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsApihasLogisticsObject = httpsApihasLogisticsObject;
            this.HttpsApihasPermission = httpsApihasPermission;
            this.HttpsApiisRequestedFor = httpsApiisRequestedFor;
            this.HttpsApihasDescription = httpsApihasDescription;
            this.HttpsApinotifyRequestStatusChange = httpsApinotifyRequestStatusChange;
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
        /// Gets or Sets ApihasLogisticsObject
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasLogisticsObject", EmitDefaultValue = false)]
        public List<LogisticsObject> HttpsApihasLogisticsObject { get; set; }

        /// <summary>
        /// Gets or Sets ApihasPermission
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasPermission", EmitDefaultValue = false)]
        public List<Permission> HttpsApihasPermission { get; set; }

        /// <summary>
        /// Gets or Sets ApiisRequestedFor
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#isRequestedFor", EmitDefaultValue = false)]
        public List<Organization> HttpsApiisRequestedFor { get; set; }

        /// <summary>
        /// Gets or Sets ApihasDescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasDescription", EmitDefaultValue = false)]
        public string HttpsApihasDescription { get; set; }

        /// <summary>
        /// Gets or Sets ApinotifyRequestStatusChange
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#notifyRequestStatusChange", EmitDefaultValue = true)]
        public bool HttpsApinotifyRequestStatusChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessDelegation {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  ApihasLogisticsObject: ").Append(HttpsApihasLogisticsObject).Append("\n");
            sb.Append("  ApihasPermission: ").Append(HttpsApihasPermission).Append("\n");
            sb.Append("  ApiisRequestedFor: ").Append(HttpsApiisRequestedFor).Append("\n");
            sb.Append("  ApihasDescription: ").Append(HttpsApihasDescription).Append("\n");
            sb.Append("  ApinotifyRequestStatusChange: ").Append(HttpsApinotifyRequestStatusChange).Append("\n");
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
            return this.Equals(httpsInput as AccessDelegation);
        }

        /// <summary>
        /// Returns true if AccessDelegation instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of AccessDelegation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessDelegation httpsInput)
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
                    this.HttpsApihasLogisticsObject == httpsInput.HttpsApihasLogisticsObject ||
                    this.HttpsApihasLogisticsObject != null &&
                    httpsInput.HttpsApihasLogisticsObject != null &&
                    this.HttpsApihasLogisticsObject.SequenceEqual(httpsInput.HttpsApihasLogisticsObject)
                ) && 
                (
                    this.HttpsApihasPermission == httpsInput.HttpsApihasPermission ||
                    this.HttpsApihasPermission != null &&
                    httpsInput.HttpsApihasPermission != null &&
                    this.HttpsApihasPermission.SequenceEqual(httpsInput.HttpsApihasPermission)
                ) && 
                (
                    this.HttpsApiisRequestedFor == httpsInput.HttpsApiisRequestedFor ||
                    this.HttpsApiisRequestedFor != null &&
                    httpsInput.HttpsApiisRequestedFor != null &&
                    this.HttpsApiisRequestedFor.SequenceEqual(httpsInput.HttpsApiisRequestedFor)
                ) && 
                (
                    this.HttpsApihasDescription == httpsInput.HttpsApihasDescription ||
                    (this.HttpsApihasDescription != null &&
                    this.HttpsApihasDescription.Equals(httpsInput.HttpsApihasDescription))
                ) && 
                (
                    this.HttpsApinotifyRequestStatusChange == httpsInput.HttpsApinotifyRequestStatusChange ||
                    this.HttpsApinotifyRequestStatusChange.Equals(httpsInput.HttpsApinotifyRequestStatusChange)
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
                if (this.HttpsApihasLogisticsObject != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasLogisticsObject.GetHashCode();
                }
                if (this.HttpsApihasPermission != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasPermission.GetHashCode();
                }
                if (this.HttpsApiisRequestedFor != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApiisRequestedFor.GetHashCode();
                }
                if (this.HttpsApihasDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsApinotifyRequestStatusChange.GetHashCode();
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