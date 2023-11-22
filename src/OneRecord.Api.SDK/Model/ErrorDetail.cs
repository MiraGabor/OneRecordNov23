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
    /// ErrorDetail
    /// </summary>
    [DataContract(Name = "ErrorDetail")]
    public partial class ErrorDetail : IEquatable<ErrorDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsApihasCode">ApihasCode.</param>
        /// <param name="httpsApihasMessage">ApihasMessage.</param>
        /// <param name="httpsApihasProperty">ApihasProperty.</param>
        /// <param name="httpsApihasResource">ApihasResource.</param>
        public ErrorDetail(string httpsId = default(string), List<string> httpsType = default(List<string>), string httpsApihasCode = default(string), string httpsApihasMessage = default(string), string httpsApihasProperty = default(string), string httpsApihasResource = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsApihasCode = httpsApihasCode;
            this.HttpsApihasMessage = httpsApihasMessage;
            this.HttpsApihasProperty = httpsApihasProperty;
            this.HttpsApihasResource = httpsApihasResource;
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
        /// Gets or Sets ApihasCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasCode", EmitDefaultValue = false)]
        public string HttpsApihasCode { get; set; }

        /// <summary>
        /// Gets or Sets ApihasMessage
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasMessage", EmitDefaultValue = false)]
        public string HttpsApihasMessage { get; set; }

        /// <summary>
        /// Gets or Sets ApihasProperty
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasProperty", EmitDefaultValue = false)]
        public string HttpsApihasProperty { get; set; }

        /// <summary>
        /// Gets or Sets ApihasResource
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasResource", EmitDefaultValue = false)]
        public string HttpsApihasResource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorDetail {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  ApihasCode: ").Append(HttpsApihasCode).Append("\n");
            sb.Append("  ApihasMessage: ").Append(HttpsApihasMessage).Append("\n");
            sb.Append("  ApihasProperty: ").Append(HttpsApihasProperty).Append("\n");
            sb.Append("  ApihasResource: ").Append(HttpsApihasResource).Append("\n");
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
            return this.Equals(httpsInput as ErrorDetail);
        }

        /// <summary>
        /// Returns true if ErrorDetail instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of ErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetail httpsInput)
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
                    this.HttpsApihasCode == httpsInput.HttpsApihasCode ||
                    (this.HttpsApihasCode != null &&
                    this.HttpsApihasCode.Equals(httpsInput.HttpsApihasCode))
                ) && 
                (
                    this.HttpsApihasMessage == httpsInput.HttpsApihasMessage ||
                    (this.HttpsApihasMessage != null &&
                    this.HttpsApihasMessage.Equals(httpsInput.HttpsApihasMessage))
                ) && 
                (
                    this.HttpsApihasProperty == httpsInput.HttpsApihasProperty ||
                    (this.HttpsApihasProperty != null &&
                    this.HttpsApihasProperty.Equals(httpsInput.HttpsApihasProperty))
                ) && 
                (
                    this.HttpsApihasResource == httpsInput.HttpsApihasResource ||
                    (this.HttpsApihasResource != null &&
                    this.HttpsApihasResource.Equals(httpsInput.HttpsApihasResource))
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
                if (this.HttpsApihasCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasCode.GetHashCode();
                }
                if (this.HttpsApihasMessage != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasMessage.GetHashCode();
                }
                if (this.HttpsApihasProperty != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasProperty.GetHashCode();
                }
                if (this.HttpsApihasResource != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasResource.GetHashCode();
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