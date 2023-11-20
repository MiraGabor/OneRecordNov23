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
    /// Geolocation
    /// </summary>
    [DataContract(Name = "Geolocation")]
    public partial class Geolocation : IEquatable<Geolocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargoelevation">Cargoelevation.</param>
        /// <param name="httpsCargogeolocationUnit">CargogeolocationUnit.</param>
        /// <param name="httpsCargolatitude">Cargolatitude.</param>
        /// <param name="httpsCargolongitude">Cargolongitude.</param>
        public Geolocation(string httpsId = default(string), List<string> httpsType = default(List<string>), Value httpsCargoelevation = default(Value), string httpsCargogeolocationUnit = default(string), double httpsCargolatitude = default(double), double httpsCargolongitude = default(double))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargoelevation = httpsCargoelevation;
            this.HttpsCargogeolocationUnit = httpsCargogeolocationUnit;
            this.HttpsCargolatitude = httpsCargolatitude;
            this.HttpsCargolongitude = httpsCargolongitude;
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
        /// Gets or Sets Cargoelevation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#elevation", EmitDefaultValue = false)]
        public Value HttpsCargoelevation { get; set; }

        /// <summary>
        /// Gets or Sets CargogeolocationUnit
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#geolocationUnit", EmitDefaultValue = false)]
        public string HttpsCargogeolocationUnit { get; set; }

        /// <summary>
        /// Gets or Sets Cargolatitude
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#latitude", EmitDefaultValue = false)]
        public double HttpsCargolatitude { get; set; }

        /// <summary>
        /// Gets or Sets Cargolongitude
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#longitude", EmitDefaultValue = false)]
        public double HttpsCargolongitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Geolocation {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargoelevation: ").Append(HttpsCargoelevation).Append("\n");
            sb.Append("  CargogeolocationUnit: ").Append(HttpsCargogeolocationUnit).Append("\n");
            sb.Append("  Cargolatitude: ").Append(HttpsCargolatitude).Append("\n");
            sb.Append("  Cargolongitude: ").Append(HttpsCargolongitude).Append("\n");
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
            return this.Equals(httpsInput as Geolocation);
        }

        /// <summary>
        /// Returns true if Geolocation instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Geolocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Geolocation httpsInput)
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
                    this.HttpsCargoelevation == httpsInput.HttpsCargoelevation ||
                    (this.HttpsCargoelevation != null &&
                    this.HttpsCargoelevation.Equals(httpsInput.HttpsCargoelevation))
                ) && 
                (
                    this.HttpsCargogeolocationUnit == httpsInput.HttpsCargogeolocationUnit ||
                    (this.HttpsCargogeolocationUnit != null &&
                    this.HttpsCargogeolocationUnit.Equals(httpsInput.HttpsCargogeolocationUnit))
                ) && 
                (
                    this.HttpsCargolatitude == httpsInput.HttpsCargolatitude ||
                    this.HttpsCargolatitude.Equals(httpsInput.HttpsCargolatitude)
                ) && 
                (
                    this.HttpsCargolongitude == httpsInput.HttpsCargolongitude ||
                    this.HttpsCargolongitude.Equals(httpsInput.HttpsCargolongitude)
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
                if (this.HttpsCargoelevation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoelevation.GetHashCode();
                }
                if (this.HttpsCargogeolocationUnit != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargogeolocationUnit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargolatitude.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargolongitude.GetHashCode();
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
