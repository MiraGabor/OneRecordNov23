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
    /// AccessPermissions
    /// </summary>
    [DataContract(Name = "AccessPermissions")]
    public partial class AccessPermissions : IEquatable<AccessPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissions" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsApihasLogisticsAgent">ApihasLogisticsAgent.</param>
        /// <param name="httpsApihasLogisticsObject">ApihasLogisticsObject.</param>
        /// <param name="httpsApihasPermission">ApihasPermission.</param>
        public AccessPermissions(string httpsId = default(string), List<string> httpsType = default(List<string>), LogisticsAgent httpsApihasLogisticsAgent = default(LogisticsAgent), LogisticsObject httpsApihasLogisticsObject = default(LogisticsObject), List<Permission> httpsApihasPermission = default(List<Permission>))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsApihasLogisticsAgent = httpsApihasLogisticsAgent;
            this.HttpsApihasLogisticsObject = httpsApihasLogisticsObject;
            this.HttpsApihasPermission = httpsApihasPermission;
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
        /// Gets or Sets ApihasLogisticsAgent
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasLogisticsAgent", EmitDefaultValue = false)]
        public LogisticsAgent HttpsApihasLogisticsAgent { get; set; }

        /// <summary>
        /// Gets or Sets ApihasLogisticsObject
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasLogisticsObject", EmitDefaultValue = false)]
        public LogisticsObject HttpsApihasLogisticsObject { get; set; }

        /// <summary>
        /// Gets or Sets ApihasPermission
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasPermission", EmitDefaultValue = false)]
        public List<Permission> HttpsApihasPermission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessPermissions {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  ApihasLogisticsAgent: ").Append(HttpsApihasLogisticsAgent).Append("\n");
            sb.Append("  ApihasLogisticsObject: ").Append(HttpsApihasLogisticsObject).Append("\n");
            sb.Append("  ApihasPermission: ").Append(HttpsApihasPermission).Append("\n");
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
            return this.Equals(httpsInput as AccessPermissions);
        }

        /// <summary>
        /// Returns true if AccessPermissions instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of AccessPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessPermissions httpsInput)
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
                    this.HttpsApihasLogisticsAgent == httpsInput.HttpsApihasLogisticsAgent ||
                    (this.HttpsApihasLogisticsAgent != null &&
                    this.HttpsApihasLogisticsAgent.Equals(httpsInput.HttpsApihasLogisticsAgent))
                ) && 
                (
                    this.HttpsApihasLogisticsObject == httpsInput.HttpsApihasLogisticsObject ||
                    (this.HttpsApihasLogisticsObject != null &&
                    this.HttpsApihasLogisticsObject.Equals(httpsInput.HttpsApihasLogisticsObject))
                ) && 
                (
                    this.HttpsApihasPermission == httpsInput.HttpsApihasPermission ||
                    this.HttpsApihasPermission != null &&
                    httpsInput.HttpsApihasPermission != null &&
                    this.HttpsApihasPermission.SequenceEqual(httpsInput.HttpsApihasPermission)
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
                if (this.HttpsApihasLogisticsAgent != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasLogisticsAgent.GetHashCode();
                }
                if (this.HttpsApihasLogisticsObject != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasLogisticsObject.GetHashCode();
                }
                if (this.HttpsApihasPermission != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasPermission.GetHashCode();
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
