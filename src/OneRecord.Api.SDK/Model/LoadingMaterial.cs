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
    /// LoadingMaterial
    /// </summary>
    [DataContract(Name = "LoadingMaterial")]
    public partial class LoadingMaterial : IEquatable<LoadingMaterial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadingMaterial" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargoattachedIotDevices">CargoattachedIotDevices.</param>
        /// <param name="httpsCargoinvolvedInActions">CargoinvolvedInActions.</param>
        /// <param name="httpsCargomanufacturer">Cargomanufacturer.</param>
        /// <param name="httpsCargootherIdentifiers">CargootherIdentifiers.</param>
        /// <param name="httpsCargodescription">Cargodescription.</param>
        /// <param name="httpsCargomaterialModel">CargomaterialModel.</param>
        /// <param name="httpsCargomaterialType">CargomaterialType.</param>
        /// <param name="httpsCargoserialNumber">CargoserialNumber.</param>
        public LoadingMaterial(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<IotDevice> httpsCargoattachedIotDevices = default(List<IotDevice>), List<LogisticsAction> httpsCargoinvolvedInActions = default(List<LogisticsAction>), Organization httpsCargomanufacturer = default(Organization), List<OtherIdentifier> httpsCargootherIdentifiers = default(List<OtherIdentifier>), string httpsCargodescription = default(string), string httpsCargomaterialModel = default(string), string httpsCargomaterialType = default(string), string httpsCargoserialNumber = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargoattachedIotDevices = httpsCargoattachedIotDevices;
            this.HttpsCargoinvolvedInActions = httpsCargoinvolvedInActions;
            this.HttpsCargomanufacturer = httpsCargomanufacturer;
            this.HttpsCargootherIdentifiers = httpsCargootherIdentifiers;
            this.HttpsCargodescription = httpsCargodescription;
            this.HttpsCargomaterialModel = httpsCargomaterialModel;
            this.HttpsCargomaterialType = httpsCargomaterialType;
            this.HttpsCargoserialNumber = httpsCargoserialNumber;
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
        /// Gets or Sets CargoattachedIotDevices
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#attachedIotDevices", EmitDefaultValue = false)]
        public List<IotDevice> HttpsCargoattachedIotDevices { get; set; }

        /// <summary>
        /// Gets or Sets CargoinvolvedInActions
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#involvedInActions", EmitDefaultValue = false)]
        public List<LogisticsAction> HttpsCargoinvolvedInActions { get; set; }

        /// <summary>
        /// Gets or Sets Cargomanufacturer
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#manufacturer", EmitDefaultValue = false)]
        public Organization HttpsCargomanufacturer { get; set; }

        /// <summary>
        /// Gets or Sets CargootherIdentifiers
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#otherIdentifiers", EmitDefaultValue = false)]
        public List<OtherIdentifier> HttpsCargootherIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets Cargodescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#description", EmitDefaultValue = false)]
        public string HttpsCargodescription { get; set; }

        /// <summary>
        /// Gets or Sets CargomaterialModel
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#materialModel", EmitDefaultValue = false)]
        public string HttpsCargomaterialModel { get; set; }

        /// <summary>
        /// Gets or Sets CargomaterialType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#materialType", EmitDefaultValue = false)]
        public string HttpsCargomaterialType { get; set; }

        /// <summary>
        /// Gets or Sets CargoserialNumber
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#serialNumber", EmitDefaultValue = false)]
        public string HttpsCargoserialNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoadingMaterial {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargoattachedIotDevices: ").Append(HttpsCargoattachedIotDevices).Append("\n");
            sb.Append("  CargoinvolvedInActions: ").Append(HttpsCargoinvolvedInActions).Append("\n");
            sb.Append("  Cargomanufacturer: ").Append(HttpsCargomanufacturer).Append("\n");
            sb.Append("  CargootherIdentifiers: ").Append(HttpsCargootherIdentifiers).Append("\n");
            sb.Append("  Cargodescription: ").Append(HttpsCargodescription).Append("\n");
            sb.Append("  CargomaterialModel: ").Append(HttpsCargomaterialModel).Append("\n");
            sb.Append("  CargomaterialType: ").Append(HttpsCargomaterialType).Append("\n");
            sb.Append("  CargoserialNumber: ").Append(HttpsCargoserialNumber).Append("\n");
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
            return this.Equals(httpsInput as LoadingMaterial);
        }

        /// <summary>
        /// Returns true if LoadingMaterial instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of LoadingMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadingMaterial httpsInput)
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
                    this.HttpsCargoattachedIotDevices == httpsInput.HttpsCargoattachedIotDevices ||
                    this.HttpsCargoattachedIotDevices != null &&
                    httpsInput.HttpsCargoattachedIotDevices != null &&
                    this.HttpsCargoattachedIotDevices.SequenceEqual(httpsInput.HttpsCargoattachedIotDevices)
                ) && 
                (
                    this.HttpsCargoinvolvedInActions == httpsInput.HttpsCargoinvolvedInActions ||
                    this.HttpsCargoinvolvedInActions != null &&
                    httpsInput.HttpsCargoinvolvedInActions != null &&
                    this.HttpsCargoinvolvedInActions.SequenceEqual(httpsInput.HttpsCargoinvolvedInActions)
                ) && 
                (
                    this.HttpsCargomanufacturer == httpsInput.HttpsCargomanufacturer ||
                    (this.HttpsCargomanufacturer != null &&
                    this.HttpsCargomanufacturer.Equals(httpsInput.HttpsCargomanufacturer))
                ) && 
                (
                    this.HttpsCargootherIdentifiers == httpsInput.HttpsCargootherIdentifiers ||
                    this.HttpsCargootherIdentifiers != null &&
                    httpsInput.HttpsCargootherIdentifiers != null &&
                    this.HttpsCargootherIdentifiers.SequenceEqual(httpsInput.HttpsCargootherIdentifiers)
                ) && 
                (
                    this.HttpsCargodescription == httpsInput.HttpsCargodescription ||
                    (this.HttpsCargodescription != null &&
                    this.HttpsCargodescription.Equals(httpsInput.HttpsCargodescription))
                ) && 
                (
                    this.HttpsCargomaterialModel == httpsInput.HttpsCargomaterialModel ||
                    (this.HttpsCargomaterialModel != null &&
                    this.HttpsCargomaterialModel.Equals(httpsInput.HttpsCargomaterialModel))
                ) && 
                (
                    this.HttpsCargomaterialType == httpsInput.HttpsCargomaterialType ||
                    (this.HttpsCargomaterialType != null &&
                    this.HttpsCargomaterialType.Equals(httpsInput.HttpsCargomaterialType))
                ) && 
                (
                    this.HttpsCargoserialNumber == httpsInput.HttpsCargoserialNumber ||
                    (this.HttpsCargoserialNumber != null &&
                    this.HttpsCargoserialNumber.Equals(httpsInput.HttpsCargoserialNumber))
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
                if (this.HttpsCargoattachedIotDevices != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoattachedIotDevices.GetHashCode();
                }
                if (this.HttpsCargoinvolvedInActions != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoinvolvedInActions.GetHashCode();
                }
                if (this.HttpsCargomanufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomanufacturer.GetHashCode();
                }
                if (this.HttpsCargootherIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargootherIdentifiers.GetHashCode();
                }
                if (this.HttpsCargodescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodescription.GetHashCode();
                }
                if (this.HttpsCargomaterialModel != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomaterialModel.GetHashCode();
                }
                if (this.HttpsCargomaterialType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomaterialType.GetHashCode();
                }
                if (this.HttpsCargoserialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoserialNumber.GetHashCode();
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