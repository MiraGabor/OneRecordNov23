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
    /// Change
    /// </summary>
    [DataContract(Name = "Change")]
    public partial class Change : IEquatable<Change>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Change" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsApihasLogisticsObject">ApihasLogisticsObject.</param>
        /// <param name="httpsApihasOperation">ApihasOperation.</param>
        /// <param name="httpsApihasDescription">ApihasDescription.</param>
        /// <param name="httpsApihasRevision">ApihasRevision.</param>
        /// <param name="httpsApinotifyRequestStatusChange">ApinotifyRequestStatusChange.</param>
        public Change(string httpsId = default(string), List<string> httpsType = default(List<string>), LogisticsObject httpsApihasLogisticsObject = default(LogisticsObject), List<Operation> httpsApihasOperation = default(List<Operation>), string httpsApihasDescription = default(string), List<string> httpsApihasRevision = default(List<string>), bool httpsApinotifyRequestStatusChange = default(bool))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsApihasLogisticsObject = httpsApihasLogisticsObject;
            this.HttpsApihasOperation = httpsApihasOperation;
            this.HttpsApihasDescription = httpsApihasDescription;
            this.HttpsApihasRevision = httpsApihasRevision;
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
        public LogisticsObject HttpsApihasLogisticsObject { get; set; }

        /// <summary>
        /// Gets or Sets ApihasOperation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasOperation", EmitDefaultValue = false)]
        public List<Operation> HttpsApihasOperation { get; set; }

        /// <summary>
        /// Gets or Sets ApihasDescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasDescription", EmitDefaultValue = false)]
        public string HttpsApihasDescription { get; set; }

        /// <summary>
        /// Gets or Sets ApihasRevision
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/api#hasRevision", EmitDefaultValue = false)]
        public List<string> HttpsApihasRevision { get; set; }

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
            sb.Append("class Change {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  ApihasLogisticsObject: ").Append(HttpsApihasLogisticsObject).Append("\n");
            sb.Append("  ApihasOperation: ").Append(HttpsApihasOperation).Append("\n");
            sb.Append("  ApihasDescription: ").Append(HttpsApihasDescription).Append("\n");
            sb.Append("  ApihasRevision: ").Append(HttpsApihasRevision).Append("\n");
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
            return this.Equals(httpsInput as Change);
        }

        /// <summary>
        /// Returns true if Change instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Change to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Change httpsInput)
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
                    (this.HttpsApihasLogisticsObject != null &&
                    this.HttpsApihasLogisticsObject.Equals(httpsInput.HttpsApihasLogisticsObject))
                ) && 
                (
                    this.HttpsApihasOperation == httpsInput.HttpsApihasOperation ||
                    this.HttpsApihasOperation != null &&
                    httpsInput.HttpsApihasOperation != null &&
                    this.HttpsApihasOperation.SequenceEqual(httpsInput.HttpsApihasOperation)
                ) && 
                (
                    this.HttpsApihasDescription == httpsInput.HttpsApihasDescription ||
                    (this.HttpsApihasDescription != null &&
                    this.HttpsApihasDescription.Equals(httpsInput.HttpsApihasDescription))
                ) && 
                (
                    this.HttpsApihasRevision == httpsInput.HttpsApihasRevision ||
                    this.HttpsApihasRevision != null &&
                    httpsInput.HttpsApihasRevision != null &&
                    this.HttpsApihasRevision.SequenceEqual(httpsInput.HttpsApihasRevision)
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
                if (this.HttpsApihasOperation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasOperation.GetHashCode();
                }
                if (this.HttpsApihasDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasDescription.GetHashCode();
                }
                if (this.HttpsApihasRevision != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsApihasRevision.GetHashCode();
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
