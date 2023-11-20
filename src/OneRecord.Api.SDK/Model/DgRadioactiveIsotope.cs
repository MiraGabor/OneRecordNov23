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
    /// DgRadioactiveIsotope
    /// </summary>
    [DataContract(Name = "DgRadioactiveIsotope")]
    public partial class DgRadioactiveIsotope : IEquatable<DgRadioactiveIsotope>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgRadioactiveIsotope" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargocontentOfDgProductRadioactive">CargocontentOfDgProductRadioactive.</param>
        /// <param name="httpsCargoactivityLevelMeasure">CargoactivityLevelMeasure.</param>
        /// <param name="httpsCargocriticalitySafetyIndexNumeric">CargocriticalitySafetyIndexNumeric.</param>
        /// <param name="httpsCargoisotopeId">CargoisotopeId.</param>
        /// <param name="httpsCargoisotopeName">CargoisotopeName.</param>
        /// <param name="httpsCargolowDispersibleIndicator">CargolowDispersibleIndicator.</param>
        /// <param name="httpsCargophysicalChemicalForm">CargophysicalChemicalForm.</param>
        /// <param name="httpsCargospecialFormIndicator">CargospecialFormIndicator.</param>
        public DgRadioactiveIsotope(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), DgProductRadioactive httpsCargocontentOfDgProductRadioactive = default(DgProductRadioactive), string httpsCargoactivityLevelMeasure = default(string), string httpsCargocriticalitySafetyIndexNumeric = default(string), string httpsCargoisotopeId = default(string), string httpsCargoisotopeName = default(string), bool httpsCargolowDispersibleIndicator = default(bool), string httpsCargophysicalChemicalForm = default(string), bool httpsCargospecialFormIndicator = default(bool))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargocontentOfDgProductRadioactive = httpsCargocontentOfDgProductRadioactive;
            this.HttpsCargoactivityLevelMeasure = httpsCargoactivityLevelMeasure;
            this.HttpsCargocriticalitySafetyIndexNumeric = httpsCargocriticalitySafetyIndexNumeric;
            this.HttpsCargoisotopeId = httpsCargoisotopeId;
            this.HttpsCargoisotopeName = httpsCargoisotopeName;
            this.HttpsCargolowDispersibleIndicator = httpsCargolowDispersibleIndicator;
            this.HttpsCargophysicalChemicalForm = httpsCargophysicalChemicalForm;
            this.HttpsCargospecialFormIndicator = httpsCargospecialFormIndicator;
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
        /// Gets or Sets CargocontentOfDgProductRadioactive
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contentOfDgProductRadioactive", EmitDefaultValue = false)]
        public DgProductRadioactive HttpsCargocontentOfDgProductRadioactive { get; set; }

        /// <summary>
        /// Gets or Sets CargoactivityLevelMeasure
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#activityLevelMeasure", EmitDefaultValue = false)]
        public string HttpsCargoactivityLevelMeasure { get; set; }

        /// <summary>
        /// Gets or Sets CargocriticalitySafetyIndexNumeric
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#criticalitySafetyIndexNumeric", EmitDefaultValue = false)]
        public string HttpsCargocriticalitySafetyIndexNumeric { get; set; }

        /// <summary>
        /// Gets or Sets CargoisotopeId
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#isotopeId", EmitDefaultValue = false)]
        public string HttpsCargoisotopeId { get; set; }

        /// <summary>
        /// Gets or Sets CargoisotopeName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#isotopeName", EmitDefaultValue = false)]
        public string HttpsCargoisotopeName { get; set; }

        /// <summary>
        /// Gets or Sets CargolowDispersibleIndicator
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#lowDispersibleIndicator", EmitDefaultValue = true)]
        public bool HttpsCargolowDispersibleIndicator { get; set; }

        /// <summary>
        /// Gets or Sets CargophysicalChemicalForm
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#physicalChemicalForm", EmitDefaultValue = false)]
        public string HttpsCargophysicalChemicalForm { get; set; }

        /// <summary>
        /// Gets or Sets CargospecialFormIndicator
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#specialFormIndicator", EmitDefaultValue = true)]
        public bool HttpsCargospecialFormIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgRadioactiveIsotope {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargocontentOfDgProductRadioactive: ").Append(HttpsCargocontentOfDgProductRadioactive).Append("\n");
            sb.Append("  CargoactivityLevelMeasure: ").Append(HttpsCargoactivityLevelMeasure).Append("\n");
            sb.Append("  CargocriticalitySafetyIndexNumeric: ").Append(HttpsCargocriticalitySafetyIndexNumeric).Append("\n");
            sb.Append("  CargoisotopeId: ").Append(HttpsCargoisotopeId).Append("\n");
            sb.Append("  CargoisotopeName: ").Append(HttpsCargoisotopeName).Append("\n");
            sb.Append("  CargolowDispersibleIndicator: ").Append(HttpsCargolowDispersibleIndicator).Append("\n");
            sb.Append("  CargophysicalChemicalForm: ").Append(HttpsCargophysicalChemicalForm).Append("\n");
            sb.Append("  CargospecialFormIndicator: ").Append(HttpsCargospecialFormIndicator).Append("\n");
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
            return this.Equals(httpsInput as DgRadioactiveIsotope);
        }

        /// <summary>
        /// Returns true if DgRadioactiveIsotope instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of DgRadioactiveIsotope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DgRadioactiveIsotope httpsInput)
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
                    this.HttpsCargocontentOfDgProductRadioactive == httpsInput.HttpsCargocontentOfDgProductRadioactive ||
                    (this.HttpsCargocontentOfDgProductRadioactive != null &&
                    this.HttpsCargocontentOfDgProductRadioactive.Equals(httpsInput.HttpsCargocontentOfDgProductRadioactive))
                ) && 
                (
                    this.HttpsCargoactivityLevelMeasure == httpsInput.HttpsCargoactivityLevelMeasure ||
                    (this.HttpsCargoactivityLevelMeasure != null &&
                    this.HttpsCargoactivityLevelMeasure.Equals(httpsInput.HttpsCargoactivityLevelMeasure))
                ) && 
                (
                    this.HttpsCargocriticalitySafetyIndexNumeric == httpsInput.HttpsCargocriticalitySafetyIndexNumeric ||
                    (this.HttpsCargocriticalitySafetyIndexNumeric != null &&
                    this.HttpsCargocriticalitySafetyIndexNumeric.Equals(httpsInput.HttpsCargocriticalitySafetyIndexNumeric))
                ) && 
                (
                    this.HttpsCargoisotopeId == httpsInput.HttpsCargoisotopeId ||
                    (this.HttpsCargoisotopeId != null &&
                    this.HttpsCargoisotopeId.Equals(httpsInput.HttpsCargoisotopeId))
                ) && 
                (
                    this.HttpsCargoisotopeName == httpsInput.HttpsCargoisotopeName ||
                    (this.HttpsCargoisotopeName != null &&
                    this.HttpsCargoisotopeName.Equals(httpsInput.HttpsCargoisotopeName))
                ) && 
                (
                    this.HttpsCargolowDispersibleIndicator == httpsInput.HttpsCargolowDispersibleIndicator ||
                    this.HttpsCargolowDispersibleIndicator.Equals(httpsInput.HttpsCargolowDispersibleIndicator)
                ) && 
                (
                    this.HttpsCargophysicalChemicalForm == httpsInput.HttpsCargophysicalChemicalForm ||
                    (this.HttpsCargophysicalChemicalForm != null &&
                    this.HttpsCargophysicalChemicalForm.Equals(httpsInput.HttpsCargophysicalChemicalForm))
                ) && 
                (
                    this.HttpsCargospecialFormIndicator == httpsInput.HttpsCargospecialFormIndicator ||
                    this.HttpsCargospecialFormIndicator.Equals(httpsInput.HttpsCargospecialFormIndicator)
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
                if (this.HttpsCargocontentOfDgProductRadioactive != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontentOfDgProductRadioactive.GetHashCode();
                }
                if (this.HttpsCargoactivityLevelMeasure != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoactivityLevelMeasure.GetHashCode();
                }
                if (this.HttpsCargocriticalitySafetyIndexNumeric != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocriticalitySafetyIndexNumeric.GetHashCode();
                }
                if (this.HttpsCargoisotopeId != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoisotopeId.GetHashCode();
                }
                if (this.HttpsCargoisotopeName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoisotopeName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargolowDispersibleIndicator.GetHashCode();
                if (this.HttpsCargophysicalChemicalForm != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargophysicalChemicalForm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargospecialFormIndicator.GetHashCode();
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
