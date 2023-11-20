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
    /// Party
    /// </summary>
    [DataContract(Name = "Party")]
    public partial class Party : IEquatable<Party>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Party" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargoorganization">Cargoorganization.</param>
        /// <param name="httpsCargootherIdentifiers">CargootherIdentifiers.</param>
        /// <param name="httpsCargopartyDetails">CargopartyDetails.</param>
        /// <param name="httpsCargorole">Cargorole.</param>
        public Party(string httpsId = default(string), List<string> httpsType = default(List<string>), Organization httpsCargoorganization = default(Organization), List<OtherIdentifier> httpsCargootherIdentifiers = default(List<OtherIdentifier>), Company httpsCargopartyDetails = default(Company), string httpsCargorole = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargoorganization = httpsCargoorganization;
            this.HttpsCargootherIdentifiers = httpsCargootherIdentifiers;
            this.HttpsCargopartyDetails = httpsCargopartyDetails;
            this.HttpsCargorole = httpsCargorole;
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
        /// Gets or Sets Cargoorganization
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#organization", EmitDefaultValue = false)]
        public Organization HttpsCargoorganization { get; set; }

        /// <summary>
        /// Gets or Sets CargootherIdentifiers
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#otherIdentifiers", EmitDefaultValue = false)]
        public List<OtherIdentifier> HttpsCargootherIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets CargopartyDetails
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#partyDetails", EmitDefaultValue = false)]
        public Company HttpsCargopartyDetails { get; set; }

        /// <summary>
        /// Gets or Sets Cargorole
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#role", EmitDefaultValue = false)]
        public string HttpsCargorole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Party {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargoorganization: ").Append(HttpsCargoorganization).Append("\n");
            sb.Append("  CargootherIdentifiers: ").Append(HttpsCargootherIdentifiers).Append("\n");
            sb.Append("  CargopartyDetails: ").Append(HttpsCargopartyDetails).Append("\n");
            sb.Append("  Cargorole: ").Append(HttpsCargorole).Append("\n");
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
            return this.Equals(httpsInput as Party);
        }

        /// <summary>
        /// Returns true if Party instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Party to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Party httpsInput)
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
                    this.HttpsCargoorganization == httpsInput.HttpsCargoorganization ||
                    (this.HttpsCargoorganization != null &&
                    this.HttpsCargoorganization.Equals(httpsInput.HttpsCargoorganization))
                ) && 
                (
                    this.HttpsCargootherIdentifiers == httpsInput.HttpsCargootherIdentifiers ||
                    this.HttpsCargootherIdentifiers != null &&
                    httpsInput.HttpsCargootherIdentifiers != null &&
                    this.HttpsCargootherIdentifiers.SequenceEqual(httpsInput.HttpsCargootherIdentifiers)
                ) && 
                (
                    this.HttpsCargopartyDetails == httpsInput.HttpsCargopartyDetails ||
                    (this.HttpsCargopartyDetails != null &&
                    this.HttpsCargopartyDetails.Equals(httpsInput.HttpsCargopartyDetails))
                ) && 
                (
                    this.HttpsCargorole == httpsInput.HttpsCargorole ||
                    (this.HttpsCargorole != null &&
                    this.HttpsCargorole.Equals(httpsInput.HttpsCargorole))
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
                if (this.HttpsCargoorganization != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoorganization.GetHashCode();
                }
                if (this.HttpsCargootherIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargootherIdentifiers.GetHashCode();
                }
                if (this.HttpsCargopartyDetails != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargopartyDetails.GetHashCode();
                }
                if (this.HttpsCargorole != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorole.GetHashCode();
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
