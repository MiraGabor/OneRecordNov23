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
    /// Measurement
    /// </summary>
    [DataContract(Name = "Measurement")]
    public partial class Measurement : IEquatable<Measurement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Measurement" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargomeasurementValue">CargomeasurementValue.</param>
        /// <param name="httpsCargorecordedGeolocation">CargorecordedGeolocation.</param>
        /// <param name="httpsCargomeasurementTimestamp">CargomeasurementTimestamp.</param>
        public Measurement(string httpsId = default(string), List<string> httpsType = default(List<string>), Value httpsCargomeasurementValue = default(Value), Geolocation httpsCargorecordedGeolocation = default(Geolocation), DateTime httpsCargomeasurementTimestamp = default(DateTime))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargomeasurementValue = httpsCargomeasurementValue;
            this.HttpsCargorecordedGeolocation = httpsCargorecordedGeolocation;
            this.HttpsCargomeasurementTimestamp = httpsCargomeasurementTimestamp;
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
        /// Gets or Sets CargomeasurementValue
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#measurementValue", EmitDefaultValue = false)]
        public Value HttpsCargomeasurementValue { get; set; }

        /// <summary>
        /// Gets or Sets CargorecordedGeolocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#recordedGeolocation", EmitDefaultValue = false)]
        public Geolocation HttpsCargorecordedGeolocation { get; set; }

        /// <summary>
        /// Gets or Sets CargomeasurementTimestamp
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#measurementTimestamp", EmitDefaultValue = false)]
        public DateTime HttpsCargomeasurementTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Measurement {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  CargomeasurementValue: ").Append(HttpsCargomeasurementValue).Append("\n");
            sb.Append("  CargorecordedGeolocation: ").Append(HttpsCargorecordedGeolocation).Append("\n");
            sb.Append("  CargomeasurementTimestamp: ").Append(HttpsCargomeasurementTimestamp).Append("\n");
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
            return this.Equals(httpsInput as Measurement);
        }

        /// <summary>
        /// Returns true if Measurement instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Measurement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Measurement httpsInput)
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
                    this.HttpsCargomeasurementValue == httpsInput.HttpsCargomeasurementValue ||
                    (this.HttpsCargomeasurementValue != null &&
                    this.HttpsCargomeasurementValue.Equals(httpsInput.HttpsCargomeasurementValue))
                ) && 
                (
                    this.HttpsCargorecordedGeolocation == httpsInput.HttpsCargorecordedGeolocation ||
                    (this.HttpsCargorecordedGeolocation != null &&
                    this.HttpsCargorecordedGeolocation.Equals(httpsInput.HttpsCargorecordedGeolocation))
                ) && 
                (
                    this.HttpsCargomeasurementTimestamp == httpsInput.HttpsCargomeasurementTimestamp ||
                    (this.HttpsCargomeasurementTimestamp != null &&
                    this.HttpsCargomeasurementTimestamp.Equals(httpsInput.HttpsCargomeasurementTimestamp))
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
                if (this.HttpsCargomeasurementValue != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomeasurementValue.GetHashCode();
                }
                if (this.HttpsCargorecordedGeolocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorecordedGeolocation.GetHashCode();
                }
                if (this.HttpsCargomeasurementTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomeasurementTimestamp.GetHashCode();
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
