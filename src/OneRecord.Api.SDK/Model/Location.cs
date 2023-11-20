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
    /// Location
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
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
        /// <param name="httpsCargoaddress">Cargoaddress.</param>
        /// <param name="httpsCargoforActions">CargoforActions.</param>
        /// <param name="httpsCargogeolocation">Cargogeolocation.</param>
        /// <param name="httpsCargocode">Cargocode.</param>
        /// <param name="httpsCargolocationName">CargolocationName.</param>
        /// <param name="httpsCargolocationType">CargolocationType.</param>
        public Location(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<IotDevice> httpsCargoattachedIotDevices = default(List<IotDevice>), List<LogisticsAction> httpsCargoinvolvedInActions = default(List<LogisticsAction>), Address httpsCargoaddress = default(Address), List<LogisticsAction> httpsCargoforActions = default(List<LogisticsAction>), Geolocation httpsCargogeolocation = default(Geolocation), string httpsCargocode = default(string), string httpsCargolocationName = default(string), string httpsCargolocationType = default(string))
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
            this.HttpsCargoaddress = httpsCargoaddress;
            this.HttpsCargoforActions = httpsCargoforActions;
            this.HttpsCargogeolocation = httpsCargogeolocation;
            this.HttpsCargocode = httpsCargocode;
            this.HttpsCargolocationName = httpsCargolocationName;
            this.HttpsCargolocationType = httpsCargolocationType;
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
        /// Gets or Sets Cargoaddress
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#address", EmitDefaultValue = false)]
        public Address HttpsCargoaddress { get; set; }

        /// <summary>
        /// Gets or Sets CargoforActions
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#forActions", EmitDefaultValue = false)]
        public List<LogisticsAction> HttpsCargoforActions { get; set; }

        /// <summary>
        /// Gets or Sets Cargogeolocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#geolocation", EmitDefaultValue = false)]
        public Geolocation HttpsCargogeolocation { get; set; }

        /// <summary>
        /// Gets or Sets Cargocode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#code", EmitDefaultValue = false)]
        public string HttpsCargocode { get; set; }

        /// <summary>
        /// Gets or Sets CargolocationName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#locationName", EmitDefaultValue = false)]
        public string HttpsCargolocationName { get; set; }

        /// <summary>
        /// Gets or Sets CargolocationType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#locationType", EmitDefaultValue = false)]
        public string HttpsCargolocationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargoattachedIotDevices: ").Append(HttpsCargoattachedIotDevices).Append("\n");
            sb.Append("  CargoinvolvedInActions: ").Append(HttpsCargoinvolvedInActions).Append("\n");
            sb.Append("  Cargoaddress: ").Append(HttpsCargoaddress).Append("\n");
            sb.Append("  CargoforActions: ").Append(HttpsCargoforActions).Append("\n");
            sb.Append("  Cargogeolocation: ").Append(HttpsCargogeolocation).Append("\n");
            sb.Append("  Cargocode: ").Append(HttpsCargocode).Append("\n");
            sb.Append("  CargolocationName: ").Append(HttpsCargolocationName).Append("\n");
            sb.Append("  CargolocationType: ").Append(HttpsCargolocationType).Append("\n");
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
            return this.Equals(httpsInput as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location httpsInput)
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
                    this.HttpsCargoaddress == httpsInput.HttpsCargoaddress ||
                    (this.HttpsCargoaddress != null &&
                    this.HttpsCargoaddress.Equals(httpsInput.HttpsCargoaddress))
                ) && 
                (
                    this.HttpsCargoforActions == httpsInput.HttpsCargoforActions ||
                    this.HttpsCargoforActions != null &&
                    httpsInput.HttpsCargoforActions != null &&
                    this.HttpsCargoforActions.SequenceEqual(httpsInput.HttpsCargoforActions)
                ) && 
                (
                    this.HttpsCargogeolocation == httpsInput.HttpsCargogeolocation ||
                    (this.HttpsCargogeolocation != null &&
                    this.HttpsCargogeolocation.Equals(httpsInput.HttpsCargogeolocation))
                ) && 
                (
                    this.HttpsCargocode == httpsInput.HttpsCargocode ||
                    (this.HttpsCargocode != null &&
                    this.HttpsCargocode.Equals(httpsInput.HttpsCargocode))
                ) && 
                (
                    this.HttpsCargolocationName == httpsInput.HttpsCargolocationName ||
                    (this.HttpsCargolocationName != null &&
                    this.HttpsCargolocationName.Equals(httpsInput.HttpsCargolocationName))
                ) && 
                (
                    this.HttpsCargolocationType == httpsInput.HttpsCargolocationType ||
                    (this.HttpsCargolocationType != null &&
                    this.HttpsCargolocationType.Equals(httpsInput.HttpsCargolocationType))
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
                if (this.HttpsCargoaddress != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoaddress.GetHashCode();
                }
                if (this.HttpsCargoforActions != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoforActions.GetHashCode();
                }
                if (this.HttpsCargogeolocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargogeolocation.GetHashCode();
                }
                if (this.HttpsCargocode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocode.GetHashCode();
                }
                if (this.HttpsCargolocationName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargolocationName.GetHashCode();
                }
                if (this.HttpsCargolocationType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargolocationType.GetHashCode();
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
