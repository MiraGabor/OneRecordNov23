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
    /// Person
    /// </summary>
    [DataContract(Name = "Person")]
    public partial class Person : IEquatable<Person>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargoassociatedOrganization">CargoassociatedOrganization.</param>
        /// <param name="httpsCargoassociatedBranch">CargoassociatedBranch.</param>
        /// <param name="httpsCargocontactDetails">CargocontactDetails.</param>
        /// <param name="httpsCargodocuments">Cargodocuments.</param>
        /// <param name="httpsCargocontactRole">CargocontactRole.</param>
        /// <param name="httpsCargodepartment">Cargodepartment.</param>
        /// <param name="httpsCargoemployeeId">CargoemployeeId.</param>
        /// <param name="httpsCargofirstName">CargofirstName.</param>
        /// <param name="httpsCargojobTitle">CargojobTitle.</param>
        /// <param name="httpsCargolastName">CargolastName.</param>
        /// <param name="httpsCargomiddleName">CargomiddleName.</param>
        /// <param name="httpsCargosalutation">Cargosalutation.</param>
        public Person(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), Organization httpsCargoassociatedOrganization = default(Organization), CompanyBranch httpsCargoassociatedBranch = default(CompanyBranch), List<ContactDetail> httpsCargocontactDetails = default(List<ContactDetail>), List<ExternalReference> httpsCargodocuments = default(List<ExternalReference>), string httpsCargocontactRole = default(string), string httpsCargodepartment = default(string), string httpsCargoemployeeId = default(string), string httpsCargofirstName = default(string), string httpsCargojobTitle = default(string), string httpsCargolastName = default(string), string httpsCargomiddleName = default(string), string httpsCargosalutation = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargoassociatedOrganization = httpsCargoassociatedOrganization;
            this.HttpsCargoassociatedBranch = httpsCargoassociatedBranch;
            this.HttpsCargocontactDetails = httpsCargocontactDetails;
            this.HttpsCargodocuments = httpsCargodocuments;
            this.HttpsCargocontactRole = httpsCargocontactRole;
            this.HttpsCargodepartment = httpsCargodepartment;
            this.HttpsCargoemployeeId = httpsCargoemployeeId;
            this.HttpsCargofirstName = httpsCargofirstName;
            this.HttpsCargojobTitle = httpsCargojobTitle;
            this.HttpsCargolastName = httpsCargolastName;
            this.HttpsCargomiddleName = httpsCargomiddleName;
            this.HttpsCargosalutation = httpsCargosalutation;
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
        /// Gets or Sets CargoassociatedOrganization
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#associatedOrganization", EmitDefaultValue = false)]
        public Organization HttpsCargoassociatedOrganization { get; set; }

        /// <summary>
        /// Gets or Sets CargoassociatedBranch
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#associatedBranch", EmitDefaultValue = false)]
        public CompanyBranch HttpsCargoassociatedBranch { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactDetails
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactDetails", EmitDefaultValue = false)]
        public List<ContactDetail> HttpsCargocontactDetails { get; set; }

        /// <summary>
        /// Gets or Sets Cargodocuments
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#documents", EmitDefaultValue = false)]
        public List<ExternalReference> HttpsCargodocuments { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactRole
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactRole", EmitDefaultValue = false)]
        public string HttpsCargocontactRole { get; set; }

        /// <summary>
        /// Gets or Sets Cargodepartment
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#department", EmitDefaultValue = false)]
        public string HttpsCargodepartment { get; set; }

        /// <summary>
        /// Gets or Sets CargoemployeeId
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#employeeId", EmitDefaultValue = false)]
        public string HttpsCargoemployeeId { get; set; }

        /// <summary>
        /// Gets or Sets CargofirstName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#firstName", EmitDefaultValue = false)]
        public string HttpsCargofirstName { get; set; }

        /// <summary>
        /// Gets or Sets CargojobTitle
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#jobTitle", EmitDefaultValue = false)]
        public string HttpsCargojobTitle { get; set; }

        /// <summary>
        /// Gets or Sets CargolastName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#lastName", EmitDefaultValue = false)]
        public string HttpsCargolastName { get; set; }

        /// <summary>
        /// Gets or Sets CargomiddleName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#middleName", EmitDefaultValue = false)]
        public string HttpsCargomiddleName { get; set; }

        /// <summary>
        /// Gets or Sets Cargosalutation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#salutation", EmitDefaultValue = false)]
        public string HttpsCargosalutation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Person {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargoassociatedOrganization: ").Append(HttpsCargoassociatedOrganization).Append("\n");
            sb.Append("  CargoassociatedBranch: ").Append(HttpsCargoassociatedBranch).Append("\n");
            sb.Append("  CargocontactDetails: ").Append(HttpsCargocontactDetails).Append("\n");
            sb.Append("  Cargodocuments: ").Append(HttpsCargodocuments).Append("\n");
            sb.Append("  CargocontactRole: ").Append(HttpsCargocontactRole).Append("\n");
            sb.Append("  Cargodepartment: ").Append(HttpsCargodepartment).Append("\n");
            sb.Append("  CargoemployeeId: ").Append(HttpsCargoemployeeId).Append("\n");
            sb.Append("  CargofirstName: ").Append(HttpsCargofirstName).Append("\n");
            sb.Append("  CargojobTitle: ").Append(HttpsCargojobTitle).Append("\n");
            sb.Append("  CargolastName: ").Append(HttpsCargolastName).Append("\n");
            sb.Append("  CargomiddleName: ").Append(HttpsCargomiddleName).Append("\n");
            sb.Append("  Cargosalutation: ").Append(HttpsCargosalutation).Append("\n");
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
            return this.Equals(httpsInput as Person);
        }

        /// <summary>
        /// Returns true if Person instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Person to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Person httpsInput)
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
                    this.HttpsCargoassociatedOrganization == httpsInput.HttpsCargoassociatedOrganization ||
                    (this.HttpsCargoassociatedOrganization != null &&
                    this.HttpsCargoassociatedOrganization.Equals(httpsInput.HttpsCargoassociatedOrganization))
                ) && 
                (
                    this.HttpsCargoassociatedBranch == httpsInput.HttpsCargoassociatedBranch ||
                    (this.HttpsCargoassociatedBranch != null &&
                    this.HttpsCargoassociatedBranch.Equals(httpsInput.HttpsCargoassociatedBranch))
                ) && 
                (
                    this.HttpsCargocontactDetails == httpsInput.HttpsCargocontactDetails ||
                    this.HttpsCargocontactDetails != null &&
                    httpsInput.HttpsCargocontactDetails != null &&
                    this.HttpsCargocontactDetails.SequenceEqual(httpsInput.HttpsCargocontactDetails)
                ) && 
                (
                    this.HttpsCargodocuments == httpsInput.HttpsCargodocuments ||
                    this.HttpsCargodocuments != null &&
                    httpsInput.HttpsCargodocuments != null &&
                    this.HttpsCargodocuments.SequenceEqual(httpsInput.HttpsCargodocuments)
                ) && 
                (
                    this.HttpsCargocontactRole == httpsInput.HttpsCargocontactRole ||
                    (this.HttpsCargocontactRole != null &&
                    this.HttpsCargocontactRole.Equals(httpsInput.HttpsCargocontactRole))
                ) && 
                (
                    this.HttpsCargodepartment == httpsInput.HttpsCargodepartment ||
                    (this.HttpsCargodepartment != null &&
                    this.HttpsCargodepartment.Equals(httpsInput.HttpsCargodepartment))
                ) && 
                (
                    this.HttpsCargoemployeeId == httpsInput.HttpsCargoemployeeId ||
                    (this.HttpsCargoemployeeId != null &&
                    this.HttpsCargoemployeeId.Equals(httpsInput.HttpsCargoemployeeId))
                ) && 
                (
                    this.HttpsCargofirstName == httpsInput.HttpsCargofirstName ||
                    (this.HttpsCargofirstName != null &&
                    this.HttpsCargofirstName.Equals(httpsInput.HttpsCargofirstName))
                ) && 
                (
                    this.HttpsCargojobTitle == httpsInput.HttpsCargojobTitle ||
                    (this.HttpsCargojobTitle != null &&
                    this.HttpsCargojobTitle.Equals(httpsInput.HttpsCargojobTitle))
                ) && 
                (
                    this.HttpsCargolastName == httpsInput.HttpsCargolastName ||
                    (this.HttpsCargolastName != null &&
                    this.HttpsCargolastName.Equals(httpsInput.HttpsCargolastName))
                ) && 
                (
                    this.HttpsCargomiddleName == httpsInput.HttpsCargomiddleName ||
                    (this.HttpsCargomiddleName != null &&
                    this.HttpsCargomiddleName.Equals(httpsInput.HttpsCargomiddleName))
                ) && 
                (
                    this.HttpsCargosalutation == httpsInput.HttpsCargosalutation ||
                    (this.HttpsCargosalutation != null &&
                    this.HttpsCargosalutation.Equals(httpsInput.HttpsCargosalutation))
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
                if (this.HttpsCargoassociatedOrganization != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoassociatedOrganization.GetHashCode();
                }
                if (this.HttpsCargoassociatedBranch != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoassociatedBranch.GetHashCode();
                }
                if (this.HttpsCargocontactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactDetails.GetHashCode();
                }
                if (this.HttpsCargodocuments != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodocuments.GetHashCode();
                }
                if (this.HttpsCargocontactRole != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactRole.GetHashCode();
                }
                if (this.HttpsCargodepartment != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodepartment.GetHashCode();
                }
                if (this.HttpsCargoemployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoemployeeId.GetHashCode();
                }
                if (this.HttpsCargofirstName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargofirstName.GetHashCode();
                }
                if (this.HttpsCargojobTitle != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargojobTitle.GetHashCode();
                }
                if (this.HttpsCargolastName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargolastName.GetHashCode();
                }
                if (this.HttpsCargomiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomiddleName.GetHashCode();
                }
                if (this.HttpsCargosalutation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargosalutation.GetHashCode();
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
