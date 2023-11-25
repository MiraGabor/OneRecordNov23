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
    /// CompanyBranch
    /// </summary>
    [DataContract(Name = "CompanyBranch")]
    public partial class CompanyBranch : IEquatable<CompanyBranch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyBranch" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargobasedAtLocation">CargobasedAtLocation.</param>
        /// <param name="httpsCargocontactPersons">CargocontactPersons.</param>
        /// <param name="httpsCargootherIdentifiers">CargootherIdentifiers.</param>
        /// <param name="httpsCargoparentOrganization">CargoparentOrganization.</param>
        /// <param name="httpsCargosubOrganization">CargosubOrganization.</param>
        /// <param name="httpsCargoname">Cargoname.</param>
        /// <param name="httpsCargoshortName">CargoshortName.</param>
        /// <param name="httpsCargocompany">Cargocompany.</param>
        /// <param name="httpsCargobranchName">CargobranchName.</param>
        /// <param name="httpsCargoiataCargoAgentLocationIdentifier">CargoiataCargoAgentLocationIdentifier.</param>
        public CompanyBranch(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), Location httpsCargobasedAtLocation = default(Location), List<Actor> httpsCargocontactPersons = default(List<Actor>), List<OtherIdentifier> httpsCargootherIdentifiers = default(List<OtherIdentifier>), Organization httpsCargoparentOrganization = default(Organization), List<Organization> httpsCargosubOrganization = default(List<Organization>), string httpsCargoname = default(string), string httpsCargoshortName = default(string), Company httpsCargocompany = default(Company), string httpsCargobranchName = default(string), string httpsCargoiataCargoAgentLocationIdentifier = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargobasedAtLocation = httpsCargobasedAtLocation;
            this.HttpsCargocontactPersons = httpsCargocontactPersons;
            this.HttpsCargootherIdentifiers = httpsCargootherIdentifiers;
            this.HttpsCargoparentOrganization = httpsCargoparentOrganization;
            this.HttpsCargosubOrganization = httpsCargosubOrganization;
            this.HttpsCargoname = httpsCargoname;
            this.HttpsCargoshortName = httpsCargoshortName;
            this.HttpsCargocompany = httpsCargocompany;
            this.HttpsCargobranchName = httpsCargobranchName;
            this.HttpsCargoiataCargoAgentLocationIdentifier = httpsCargoiataCargoAgentLocationIdentifier;
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
        /// Gets or Sets CargobasedAtLocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#basedAtLocation", EmitDefaultValue = false)]
        public Location HttpsCargobasedAtLocation { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactPersons
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactPersons", EmitDefaultValue = false)]
        public List<Actor> HttpsCargocontactPersons { get; set; }

        /// <summary>
        /// Gets or Sets CargootherIdentifiers
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#otherIdentifiers", EmitDefaultValue = false)]
        public List<OtherIdentifier> HttpsCargootherIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets CargoparentOrganization
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#parentOrganization", EmitDefaultValue = false)]
        public Organization HttpsCargoparentOrganization { get; set; }

        /// <summary>
        /// Gets or Sets CargosubOrganization
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#subOrganization", EmitDefaultValue = false)]
        public List<Organization> HttpsCargosubOrganization { get; set; }

        /// <summary>
        /// Gets or Sets Cargoname
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#name", EmitDefaultValue = false)]
        public string HttpsCargoname { get; set; }

        /// <summary>
        /// Gets or Sets CargoshortName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#shortName", EmitDefaultValue = false)]
        public string HttpsCargoshortName { get; set; }

        /// <summary>
        /// Gets or Sets Cargocompany
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#company", EmitDefaultValue = false)]
        public Company HttpsCargocompany { get; set; }

        /// <summary>
        /// Gets or Sets CargobranchName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#branchName", EmitDefaultValue = false)]
        public string HttpsCargobranchName { get; set; }

        /// <summary>
        /// Gets or Sets CargoiataCargoAgentLocationIdentifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#iataCargoAgentLocationIdentifier", EmitDefaultValue = false)]
        public string HttpsCargoiataCargoAgentLocationIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyBranch {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargobasedAtLocation: ").Append(HttpsCargobasedAtLocation).Append("\n");
            sb.Append("  CargocontactPersons: ").Append(HttpsCargocontactPersons).Append("\n");
            sb.Append("  CargootherIdentifiers: ").Append(HttpsCargootherIdentifiers).Append("\n");
            sb.Append("  CargoparentOrganization: ").Append(HttpsCargoparentOrganization).Append("\n");
            sb.Append("  CargosubOrganization: ").Append(HttpsCargosubOrganization).Append("\n");
            sb.Append("  Cargoname: ").Append(HttpsCargoname).Append("\n");
            sb.Append("  CargoshortName: ").Append(HttpsCargoshortName).Append("\n");
            sb.Append("  Cargocompany: ").Append(HttpsCargocompany).Append("\n");
            sb.Append("  CargobranchName: ").Append(HttpsCargobranchName).Append("\n");
            sb.Append("  CargoiataCargoAgentLocationIdentifier: ").Append(HttpsCargoiataCargoAgentLocationIdentifier).Append("\n");
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
            return this.Equals(httpsInput as CompanyBranch);
        }

        /// <summary>
        /// Returns true if CompanyBranch instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of CompanyBranch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyBranch httpsInput)
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
                    this.HttpsCargobasedAtLocation == httpsInput.HttpsCargobasedAtLocation ||
                    (this.HttpsCargobasedAtLocation != null &&
                    this.HttpsCargobasedAtLocation.Equals(httpsInput.HttpsCargobasedAtLocation))
                ) && 
                (
                    this.HttpsCargocontactPersons == httpsInput.HttpsCargocontactPersons ||
                    this.HttpsCargocontactPersons != null &&
                    httpsInput.HttpsCargocontactPersons != null &&
                    this.HttpsCargocontactPersons.SequenceEqual(httpsInput.HttpsCargocontactPersons)
                ) && 
                (
                    this.HttpsCargootherIdentifiers == httpsInput.HttpsCargootherIdentifiers ||
                    this.HttpsCargootherIdentifiers != null &&
                    httpsInput.HttpsCargootherIdentifiers != null &&
                    this.HttpsCargootherIdentifiers.SequenceEqual(httpsInput.HttpsCargootherIdentifiers)
                ) && 
                (
                    this.HttpsCargoparentOrganization == httpsInput.HttpsCargoparentOrganization ||
                    (this.HttpsCargoparentOrganization != null &&
                    this.HttpsCargoparentOrganization.Equals(httpsInput.HttpsCargoparentOrganization))
                ) && 
                (
                    this.HttpsCargosubOrganization == httpsInput.HttpsCargosubOrganization ||
                    this.HttpsCargosubOrganization != null &&
                    httpsInput.HttpsCargosubOrganization != null &&
                    this.HttpsCargosubOrganization.SequenceEqual(httpsInput.HttpsCargosubOrganization)
                ) && 
                (
                    this.HttpsCargoname == httpsInput.HttpsCargoname ||
                    (this.HttpsCargoname != null &&
                    this.HttpsCargoname.Equals(httpsInput.HttpsCargoname))
                ) && 
                (
                    this.HttpsCargoshortName == httpsInput.HttpsCargoshortName ||
                    (this.HttpsCargoshortName != null &&
                    this.HttpsCargoshortName.Equals(httpsInput.HttpsCargoshortName))
                ) && 
                (
                    this.HttpsCargocompany == httpsInput.HttpsCargocompany ||
                    (this.HttpsCargocompany != null &&
                    this.HttpsCargocompany.Equals(httpsInput.HttpsCargocompany))
                ) && 
                (
                    this.HttpsCargobranchName == httpsInput.HttpsCargobranchName ||
                    (this.HttpsCargobranchName != null &&
                    this.HttpsCargobranchName.Equals(httpsInput.HttpsCargobranchName))
                ) && 
                (
                    this.HttpsCargoiataCargoAgentLocationIdentifier == httpsInput.HttpsCargoiataCargoAgentLocationIdentifier ||
                    (this.HttpsCargoiataCargoAgentLocationIdentifier != null &&
                    this.HttpsCargoiataCargoAgentLocationIdentifier.Equals(httpsInput.HttpsCargoiataCargoAgentLocationIdentifier))
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
                if (this.HttpsCargobasedAtLocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargobasedAtLocation.GetHashCode();
                }
                if (this.HttpsCargocontactPersons != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactPersons.GetHashCode();
                }
                if (this.HttpsCargootherIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargootherIdentifiers.GetHashCode();
                }
                if (this.HttpsCargoparentOrganization != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoparentOrganization.GetHashCode();
                }
                if (this.HttpsCargosubOrganization != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargosubOrganization.GetHashCode();
                }
                if (this.HttpsCargoname != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoname.GetHashCode();
                }
                if (this.HttpsCargoshortName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoshortName.GetHashCode();
                }
                if (this.HttpsCargocompany != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocompany.GetHashCode();
                }
                if (this.HttpsCargobranchName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargobranchName.GetHashCode();
                }
                if (this.HttpsCargoiataCargoAgentLocationIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoiataCargoAgentLocationIdentifier.GetHashCode();
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
