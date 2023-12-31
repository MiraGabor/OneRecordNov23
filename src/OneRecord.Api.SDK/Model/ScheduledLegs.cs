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
    /// ScheduledLegs
    /// </summary>
    [DataContract(Name = "ScheduledLegs")]
    public partial class ScheduledLegs : IEquatable<ScheduledLegs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledLegs" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargoarrivalLocation">CargoarrivalLocation.</param>
        /// <param name="httpsCargodepartureLocation">CargodepartureLocation.</param>
        /// <param name="httpsCargoarrivalDate">CargoarrivalDate.</param>
        /// <param name="httpsCargodepartureDate">CargodepartureDate.</param>
        /// <param name="httpsCargolegSequenceNumber">CargolegSequenceNumber.</param>
        /// <param name="httpsCargotransportIdentifier">CargotransportIdentifier.</param>
        public ScheduledLegs(string httpsId = default(string), List<string> httpsType = default(List<string>), Location httpsCargoarrivalLocation = default(Location), Location httpsCargodepartureLocation = default(Location), DateTime httpsCargoarrivalDate = default(DateTime), DateTime httpsCargodepartureDate = default(DateTime), int httpsCargolegSequenceNumber = default(int), string httpsCargotransportIdentifier = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargoarrivalLocation = httpsCargoarrivalLocation;
            this.HttpsCargodepartureLocation = httpsCargodepartureLocation;
            this.HttpsCargoarrivalDate = httpsCargoarrivalDate;
            this.HttpsCargodepartureDate = httpsCargodepartureDate;
            this.HttpsCargolegSequenceNumber = httpsCargolegSequenceNumber;
            this.HttpsCargotransportIdentifier = httpsCargotransportIdentifier;
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
        /// Gets or Sets CargoarrivalLocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#arrivalLocation", EmitDefaultValue = false)]
        public Location HttpsCargoarrivalLocation { get; set; }

        /// <summary>
        /// Gets or Sets CargodepartureLocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#departureLocation", EmitDefaultValue = false)]
        public Location HttpsCargodepartureLocation { get; set; }

        /// <summary>
        /// Gets or Sets CargoarrivalDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#arrivalDate", EmitDefaultValue = false)]
        public DateTime HttpsCargoarrivalDate { get; set; }

        /// <summary>
        /// Gets or Sets CargodepartureDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#departureDate", EmitDefaultValue = false)]
        public DateTime HttpsCargodepartureDate { get; set; }

        /// <summary>
        /// Gets or Sets CargolegSequenceNumber
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#legSequenceNumber", EmitDefaultValue = false)]
        public int HttpsCargolegSequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets CargotransportIdentifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#transportIdentifier", EmitDefaultValue = false)]
        public string HttpsCargotransportIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduledLegs {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  CargoarrivalLocation: ").Append(HttpsCargoarrivalLocation).Append("\n");
            sb.Append("  CargodepartureLocation: ").Append(HttpsCargodepartureLocation).Append("\n");
            sb.Append("  CargoarrivalDate: ").Append(HttpsCargoarrivalDate).Append("\n");
            sb.Append("  CargodepartureDate: ").Append(HttpsCargodepartureDate).Append("\n");
            sb.Append("  CargolegSequenceNumber: ").Append(HttpsCargolegSequenceNumber).Append("\n");
            sb.Append("  CargotransportIdentifier: ").Append(HttpsCargotransportIdentifier).Append("\n");
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
            return this.Equals(httpsInput as ScheduledLegs);
        }

        /// <summary>
        /// Returns true if ScheduledLegs instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of ScheduledLegs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledLegs httpsInput)
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
                    this.HttpsCargoarrivalLocation == httpsInput.HttpsCargoarrivalLocation ||
                    (this.HttpsCargoarrivalLocation != null &&
                    this.HttpsCargoarrivalLocation.Equals(httpsInput.HttpsCargoarrivalLocation))
                ) && 
                (
                    this.HttpsCargodepartureLocation == httpsInput.HttpsCargodepartureLocation ||
                    (this.HttpsCargodepartureLocation != null &&
                    this.HttpsCargodepartureLocation.Equals(httpsInput.HttpsCargodepartureLocation))
                ) && 
                (
                    this.HttpsCargoarrivalDate == httpsInput.HttpsCargoarrivalDate ||
                    (this.HttpsCargoarrivalDate != null &&
                    this.HttpsCargoarrivalDate.Equals(httpsInput.HttpsCargoarrivalDate))
                ) && 
                (
                    this.HttpsCargodepartureDate == httpsInput.HttpsCargodepartureDate ||
                    (this.HttpsCargodepartureDate != null &&
                    this.HttpsCargodepartureDate.Equals(httpsInput.HttpsCargodepartureDate))
                ) && 
                (
                    this.HttpsCargolegSequenceNumber == httpsInput.HttpsCargolegSequenceNumber ||
                    this.HttpsCargolegSequenceNumber.Equals(httpsInput.HttpsCargolegSequenceNumber)
                ) && 
                (
                    this.HttpsCargotransportIdentifier == httpsInput.HttpsCargotransportIdentifier ||
                    (this.HttpsCargotransportIdentifier != null &&
                    this.HttpsCargotransportIdentifier.Equals(httpsInput.HttpsCargotransportIdentifier))
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
                if (this.HttpsCargoarrivalLocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoarrivalLocation.GetHashCode();
                }
                if (this.HttpsCargodepartureLocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodepartureLocation.GetHashCode();
                }
                if (this.HttpsCargoarrivalDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoarrivalDate.GetHashCode();
                }
                if (this.HttpsCargodepartureDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodepartureDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargolegSequenceNumber.GetHashCode();
                if (this.HttpsCargotransportIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargotransportIdentifier.GetHashCode();
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
