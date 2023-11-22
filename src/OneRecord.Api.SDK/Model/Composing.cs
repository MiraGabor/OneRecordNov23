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
    /// Composing
    /// </summary>
    [DataContract(Name = "Composing")]
    public partial class Composing : IEquatable<Composing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Composing" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargocontactDetails">CargocontactDetails.</param>
        /// <param name="httpsCargocontactPersons">CargocontactPersons.</param>
        /// <param name="httpsCargolocationOfPerformance">CargolocationOfPerformance.</param>
        /// <param name="httpsCargoservedActivity">CargoservedActivity.</param>
        /// <param name="httpsCargoactionEndTime">CargoactionEndTime.</param>
        /// <param name="httpsCargoactionStartTime">CargoactionStartTime.</param>
        /// <param name="httpsCargoactionTimeType">CargoactionTimeType.</param>
        /// <param name="httpsCargocomposedMaterials">CargocomposedMaterials.</param>
        /// <param name="httpsCargocomposedPieces">CargocomposedPieces.</param>
        /// <param name="httpsCargoloadingUnit">CargoloadingUnit.</param>
        /// <param name="httpsCargocompositionType">CargocompositionType.</param>
        public Composing(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<ContactDetail> httpsCargocontactDetails = default(List<ContactDetail>), List<Person> httpsCargocontactPersons = default(List<Person>), Location httpsCargolocationOfPerformance = default(Location), LogisticsActivity httpsCargoservedActivity = default(LogisticsActivity), DateTime httpsCargoactionEndTime = default(DateTime), DateTime httpsCargoactionStartTime = default(DateTime), string httpsCargoactionTimeType = default(string), List<LoadingMaterial> httpsCargocomposedMaterials = default(List<LoadingMaterial>), List<Piece> httpsCargocomposedPieces = default(List<Piece>), LoadingUnit httpsCargoloadingUnit = default(LoadingUnit), string httpsCargocompositionType = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargocontactDetails = httpsCargocontactDetails;
            this.HttpsCargocontactPersons = httpsCargocontactPersons;
            this.HttpsCargolocationOfPerformance = httpsCargolocationOfPerformance;
            this.HttpsCargoservedActivity = httpsCargoservedActivity;
            this.HttpsCargoactionEndTime = httpsCargoactionEndTime;
            this.HttpsCargoactionStartTime = httpsCargoactionStartTime;
            this.HttpsCargoactionTimeType = httpsCargoactionTimeType;
            this.HttpsCargocomposedMaterials = httpsCargocomposedMaterials;
            this.HttpsCargocomposedPieces = httpsCargocomposedPieces;
            this.HttpsCargoloadingUnit = httpsCargoloadingUnit;
            this.HttpsCargocompositionType = httpsCargocompositionType;
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
        /// Gets or Sets Cargochecks
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#checks", EmitDefaultValue = false)]
        public List<Check> HttpsCargochecks { get; set; }

        /// <summary>
        /// Gets or Sets Cargoevents
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#events", EmitDefaultValue = false)]
        public List<LogisticsEvent> HttpsCargoevents { get; set; }

        /// <summary>
        /// Gets or Sets CargoexternalReferences
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#externalReferences", EmitDefaultValue = false)]
        public List<ExternalReference> HttpsCargoexternalReferences { get; set; }

        /// <summary>
        /// Gets or Sets CargocompanyIdentifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#companyIdentifier", EmitDefaultValue = false)]
        public string HttpsCargocompanyIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CargoskeletonIndicator
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#skeletonIndicator", EmitDefaultValue = true)]
        public bool HttpsCargoskeletonIndicator { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactDetails
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactDetails", EmitDefaultValue = false)]
        public List<ContactDetail> HttpsCargocontactDetails { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactPersons
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactPersons", EmitDefaultValue = false)]
        public List<Person> HttpsCargocontactPersons { get; set; }

        /// <summary>
        /// Gets or Sets CargolocationOfPerformance
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#locationOfPerformance", EmitDefaultValue = false)]
        public Location HttpsCargolocationOfPerformance { get; set; }

        /// <summary>
        /// Gets or Sets CargoservedActivity
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#servedActivity", EmitDefaultValue = false)]
        public LogisticsActivity HttpsCargoservedActivity { get; set; }

        /// <summary>
        /// Gets or Sets CargoactionEndTime
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#actionEndTime", EmitDefaultValue = false)]
        public DateTime HttpsCargoactionEndTime { get; set; }

        /// <summary>
        /// Gets or Sets CargoactionStartTime
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#actionStartTime", EmitDefaultValue = false)]
        public DateTime HttpsCargoactionStartTime { get; set; }

        /// <summary>
        /// Gets or Sets CargoactionTimeType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#actionTimeType", EmitDefaultValue = false)]
        public string HttpsCargoactionTimeType { get; set; }

        /// <summary>
        /// Gets or Sets CargocomposedMaterials
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#composedMaterials", EmitDefaultValue = false)]
        public List<LoadingMaterial> HttpsCargocomposedMaterials { get; set; }

        /// <summary>
        /// Gets or Sets CargocomposedPieces
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#composedPieces", EmitDefaultValue = false)]
        public List<Piece> HttpsCargocomposedPieces { get; set; }

        /// <summary>
        /// Gets or Sets CargoloadingUnit
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#loadingUnit", EmitDefaultValue = false)]
        public LoadingUnit HttpsCargoloadingUnit { get; set; }

        /// <summary>
        /// Gets or Sets CargocompositionType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#compositionType", EmitDefaultValue = false)]
        public string HttpsCargocompositionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Composing {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargocontactDetails: ").Append(HttpsCargocontactDetails).Append("\n");
            sb.Append("  CargocontactPersons: ").Append(HttpsCargocontactPersons).Append("\n");
            sb.Append("  CargolocationOfPerformance: ").Append(HttpsCargolocationOfPerformance).Append("\n");
            sb.Append("  CargoservedActivity: ").Append(HttpsCargoservedActivity).Append("\n");
            sb.Append("  CargoactionEndTime: ").Append(HttpsCargoactionEndTime).Append("\n");
            sb.Append("  CargoactionStartTime: ").Append(HttpsCargoactionStartTime).Append("\n");
            sb.Append("  CargoactionTimeType: ").Append(HttpsCargoactionTimeType).Append("\n");
            sb.Append("  CargocomposedMaterials: ").Append(HttpsCargocomposedMaterials).Append("\n");
            sb.Append("  CargocomposedPieces: ").Append(HttpsCargocomposedPieces).Append("\n");
            sb.Append("  CargoloadingUnit: ").Append(HttpsCargoloadingUnit).Append("\n");
            sb.Append("  CargocompositionType: ").Append(HttpsCargocompositionType).Append("\n");
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
            return this.Equals(httpsInput as Composing);
        }

        /// <summary>
        /// Returns true if Composing instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Composing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Composing httpsInput)
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
                    this.HttpsCargochecks == httpsInput.HttpsCargochecks ||
                    this.HttpsCargochecks != null &&
                    httpsInput.HttpsCargochecks != null &&
                    this.HttpsCargochecks.SequenceEqual(httpsInput.HttpsCargochecks)
                ) && 
                (
                    this.HttpsCargoevents == httpsInput.HttpsCargoevents ||
                    this.HttpsCargoevents != null &&
                    httpsInput.HttpsCargoevents != null &&
                    this.HttpsCargoevents.SequenceEqual(httpsInput.HttpsCargoevents)
                ) && 
                (
                    this.HttpsCargoexternalReferences == httpsInput.HttpsCargoexternalReferences ||
                    this.HttpsCargoexternalReferences != null &&
                    httpsInput.HttpsCargoexternalReferences != null &&
                    this.HttpsCargoexternalReferences.SequenceEqual(httpsInput.HttpsCargoexternalReferences)
                ) && 
                (
                    this.HttpsCargocompanyIdentifier == httpsInput.HttpsCargocompanyIdentifier ||
                    (this.HttpsCargocompanyIdentifier != null &&
                    this.HttpsCargocompanyIdentifier.Equals(httpsInput.HttpsCargocompanyIdentifier))
                ) && 
                (
                    this.HttpsCargoskeletonIndicator == httpsInput.HttpsCargoskeletonIndicator ||
                    this.HttpsCargoskeletonIndicator.Equals(httpsInput.HttpsCargoskeletonIndicator)
                ) && 
                (
                    this.HttpsCargocontactDetails == httpsInput.HttpsCargocontactDetails ||
                    this.HttpsCargocontactDetails != null &&
                    httpsInput.HttpsCargocontactDetails != null &&
                    this.HttpsCargocontactDetails.SequenceEqual(httpsInput.HttpsCargocontactDetails)
                ) && 
                (
                    this.HttpsCargocontactPersons == httpsInput.HttpsCargocontactPersons ||
                    this.HttpsCargocontactPersons != null &&
                    httpsInput.HttpsCargocontactPersons != null &&
                    this.HttpsCargocontactPersons.SequenceEqual(httpsInput.HttpsCargocontactPersons)
                ) && 
                (
                    this.HttpsCargolocationOfPerformance == httpsInput.HttpsCargolocationOfPerformance ||
                    (this.HttpsCargolocationOfPerformance != null &&
                    this.HttpsCargolocationOfPerformance.Equals(httpsInput.HttpsCargolocationOfPerformance))
                ) && 
                (
                    this.HttpsCargoservedActivity == httpsInput.HttpsCargoservedActivity ||
                    (this.HttpsCargoservedActivity != null &&
                    this.HttpsCargoservedActivity.Equals(httpsInput.HttpsCargoservedActivity))
                ) && 
                (
                    this.HttpsCargoactionEndTime == httpsInput.HttpsCargoactionEndTime ||
                    (this.HttpsCargoactionEndTime != null &&
                    this.HttpsCargoactionEndTime.Equals(httpsInput.HttpsCargoactionEndTime))
                ) && 
                (
                    this.HttpsCargoactionStartTime == httpsInput.HttpsCargoactionStartTime ||
                    (this.HttpsCargoactionStartTime != null &&
                    this.HttpsCargoactionStartTime.Equals(httpsInput.HttpsCargoactionStartTime))
                ) && 
                (
                    this.HttpsCargoactionTimeType == httpsInput.HttpsCargoactionTimeType ||
                    (this.HttpsCargoactionTimeType != null &&
                    this.HttpsCargoactionTimeType.Equals(httpsInput.HttpsCargoactionTimeType))
                ) && 
                (
                    this.HttpsCargocomposedMaterials == httpsInput.HttpsCargocomposedMaterials ||
                    this.HttpsCargocomposedMaterials != null &&
                    httpsInput.HttpsCargocomposedMaterials != null &&
                    this.HttpsCargocomposedMaterials.SequenceEqual(httpsInput.HttpsCargocomposedMaterials)
                ) && 
                (
                    this.HttpsCargocomposedPieces == httpsInput.HttpsCargocomposedPieces ||
                    this.HttpsCargocomposedPieces != null &&
                    httpsInput.HttpsCargocomposedPieces != null &&
                    this.HttpsCargocomposedPieces.SequenceEqual(httpsInput.HttpsCargocomposedPieces)
                ) && 
                (
                    this.HttpsCargoloadingUnit == httpsInput.HttpsCargoloadingUnit ||
                    (this.HttpsCargoloadingUnit != null &&
                    this.HttpsCargoloadingUnit.Equals(httpsInput.HttpsCargoloadingUnit))
                ) && 
                (
                    this.HttpsCargocompositionType == httpsInput.HttpsCargocompositionType ||
                    (this.HttpsCargocompositionType != null &&
                    this.HttpsCargocompositionType.Equals(httpsInput.HttpsCargocompositionType))
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
                if (this.HttpsCargochecks != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargochecks.GetHashCode();
                }
                if (this.HttpsCargoevents != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoevents.GetHashCode();
                }
                if (this.HttpsCargoexternalReferences != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoexternalReferences.GetHashCode();
                }
                if (this.HttpsCargocompanyIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocompanyIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargoskeletonIndicator.GetHashCode();
                if (this.HttpsCargocontactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactDetails.GetHashCode();
                }
                if (this.HttpsCargocontactPersons != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactPersons.GetHashCode();
                }
                if (this.HttpsCargolocationOfPerformance != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargolocationOfPerformance.GetHashCode();
                }
                if (this.HttpsCargoservedActivity != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoservedActivity.GetHashCode();
                }
                if (this.HttpsCargoactionEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoactionEndTime.GetHashCode();
                }
                if (this.HttpsCargoactionStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoactionStartTime.GetHashCode();
                }
                if (this.HttpsCargoactionTimeType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoactionTimeType.GetHashCode();
                }
                if (this.HttpsCargocomposedMaterials != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocomposedMaterials.GetHashCode();
                }
                if (this.HttpsCargocomposedPieces != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocomposedPieces.GetHashCode();
                }
                if (this.HttpsCargoloadingUnit != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoloadingUnit.GetHashCode();
                }
                if (this.HttpsCargocompositionType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocompositionType.GetHashCode();
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
