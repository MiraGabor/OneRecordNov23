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
    /// Check
    /// </summary>
    [DataContract(Name = "Check")]
    public partial class Check : LogisticsObject, IEquatable<Check>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="checks">Cargochecks.</param>
        /// <param name="events">Cargoevents.</param>
        /// <param name="externalReferences">CargoexternalReferences.</param>
        /// <param name="companyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="skeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="contactDetails">CargocontactDetails.</param>
        /// <param name="contactPersons">CargocontactPersons.</param>
        /// <param name="locationOfPerformance">CargolocationOfPerformance.</param>
        /// <param name="servedActivity">CargoservedActivity.</param>
        /// <param name="actionEndTime">CargoactionEndTime.</param>
        /// <param name="actionStartTime">CargoactionStartTime.</param>
        /// <param name="actionTimeType">CargoactionTimeType.</param>
        /// <param name="checkTotalResult">CargocheckTotalResult.</param>
        /// <param name="checkedObject">CargocheckedObject.</param>
        /// <param name="checker">Cargochecker.</param>
        /// <param name="usedTemplate">CargousedTemplate.</param>
        public Check(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> checks = default(List<Check>), List<LogisticsEvent> events = default(List<LogisticsEvent>), List<ExternalReference> externalReferences = default(List<ExternalReference>), string companyIdentifier = default(string), bool skeletonIndicator = default(bool), List<ContactDetail> contactDetails = default(List<ContactDetail>), List<Person> contactPersons = default(List<Person>), Location locationOfPerformance = default(Location), LogisticsActivity servedActivity = default(LogisticsActivity), DateTime actionEndTime = default(DateTime), DateTime actionStartTime = default(DateTime), string actionTimeType = default(string), CheckTotalResult checkTotalResult = default(CheckTotalResult), LogisticsObject checkedObject = default(LogisticsObject), Actor checker = default(Actor), CheckTemplate usedTemplate = default(CheckTemplate))
        {
            this.Id = httpsId;
            this.Type = httpsType;
            this.Checks = checks;
            this.Events = events;
            this.ExternalReferences = externalReferences;
            this.CompanyIdentifier = companyIdentifier;
            this.SkeletonIndicator = skeletonIndicator;
            this.ContactDetails = contactDetails;
            this.ContactPersons = contactPersons;
            this.LocationOfPerformance = locationOfPerformance;
            this.ServedActivity = servedActivity;
            this.ActionEndTime = actionEndTime;
            this.ActionStartTime = actionStartTime;
            this.ActionTimeType = actionTimeType;
            this.CheckTotalResult = checkTotalResult;
            this.CheckedObject = checkedObject;
            this.Checker = checker;
            this.UsedTemplate = usedTemplate;
        }

        ///// <summary>
        ///// Gets or Sets Id
        ///// </summary>
        //[DataMember(Name = "@id", EmitDefaultValue = false)]
        //public string HttpsId { get; set; }

        ///// <summary>
        ///// Gets or Sets Type
        ///// </summary>
        //[DataMember(Name = "@type", EmitDefaultValue = false)]
        //public List<string> HttpsType { get; set; }

        ///// <summary>
        ///// Gets or Sets Cargochecks
        ///// </summary>
        //[DataMember(Name = "cargo:checks", EmitDefaultValue = false)]
        //public List<Check> checks { get; set; }

        ///// <summary>
        ///// Gets or Sets Cargoevents
        ///// </summary>
        //[DataMember(Name = "cargo:events", EmitDefaultValue = false)]
        //public List<LogisticsEvent> events { get; set; }

        ///// <summary>
        ///// Gets or Sets CargoexternalReferences
        ///// </summary>
        //[DataMember(Name = "cargo:externalReferences", EmitDefaultValue = false)]
        //public List<ExternalReference> externalReferences { get; set; }

        ///// <summary>
        ///// Gets or Sets CargocompanyIdentifier
        ///// </summary>
        //[DataMember(Name = "cargo:companyIdentifier", EmitDefaultValue = false)]
        //public string companyIdentifier { get; set; }

        ///// <summary>
        ///// Gets or Sets CargoskeletonIndicator
        ///// </summary>
        //[DataMember(Name = "cargo:skeletonIndicator", EmitDefaultValue = true)]
        //public bool skeletonIndicator { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactDetails
        /// </summary>
        [DataMember(Name = "cargo:contactDetails", EmitDefaultValue = false)]
        public List<ContactDetail> ContactDetails { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactPersons
        /// </summary>
        [DataMember(Name = "cargo:contactPersons", EmitDefaultValue = false)]
        public List<Person> ContactPersons { get; set; }

        /// <summary>
        /// Gets or Sets CargolocationOfPerformance
        /// </summary>
        [DataMember(Name = "cargo:locationOfPerformance", EmitDefaultValue = false)]
        public Location LocationOfPerformance { get; set; }

        /// <summary>
        /// Gets or Sets CargoservedActivity
        /// </summary>
        [DataMember(Name = "cargo:servedActivity", EmitDefaultValue = false)]
        public LogisticsActivity ServedActivity { get; set; }

        /// <summary>
        /// Gets or Sets CargoactionEndTime
        /// </summary>
        [DataMember(Name = "cargo:actionEndTime", EmitDefaultValue = false)]
        public DateTime ActionEndTime { get; set; }

        /// <summary>
        /// Gets or Sets CargoactionStartTime
        /// </summary>
        [DataMember(Name = "cargo:actionStartTime", EmitDefaultValue = false)]
        public DateTime ActionStartTime { get; set; }

        /// <summary>
        /// Gets or Sets CargoactionTimeType
        /// </summary>
        [DataMember(Name = "cargo:actionTimeType", EmitDefaultValue = false)]
        public string ActionTimeType { get; set; }

        /// <summary>
        /// Gets or Sets CargocheckTotalResult
        /// </summary>
        [DataMember(Name = "cargo:checkTotalResult", EmitDefaultValue = false)]
        public CheckTotalResult CheckTotalResult { get; set; }

        /// <summary>
        /// Gets or Sets CargocheckedObject
        /// </summary>
        [DataMember(Name = "cargo:checkedObject", EmitDefaultValue = false)]
        public LogisticsObject CheckedObject { get; set; }

        /// <summary>
        /// Gets or Sets Cargochecker
        /// </summary>
        [DataMember(Name = "cargo:checker", EmitDefaultValue = false)]
        public Actor Checker { get; set; }

        /// <summary>
        /// Gets or Sets CargousedTemplate
        /// </summary>
        [DataMember(Name = "cargo:usedTemplate", EmitDefaultValue = false)]
        public CheckTemplate UsedTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Check {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Cargochecks: ").Append(Checks).Append("\n");
            sb.Append("  Cargoevents: ").Append(Events).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(ExternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(CompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(SkeletonIndicator).Append("\n");
            sb.Append("  CargocontactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  CargocontactPersons: ").Append(ContactPersons).Append("\n");
            sb.Append("  CargolocationOfPerformance: ").Append(LocationOfPerformance).Append("\n");
            sb.Append("  CargoservedActivity: ").Append(ServedActivity).Append("\n");
            sb.Append("  CargoactionEndTime: ").Append(ActionEndTime).Append("\n");
            sb.Append("  CargoactionStartTime: ").Append(ActionStartTime).Append("\n");
            sb.Append("  CargoactionTimeType: ").Append(ActionTimeType).Append("\n");
            sb.Append("  CargocheckTotalResult: ").Append(CheckTotalResult).Append("\n");
            sb.Append("  CargocheckedObject: ").Append(CheckedObject).Append("\n");
            sb.Append("  Cargochecker: ").Append(Checker).Append("\n");
            sb.Append("  CargousedTemplate: ").Append(UsedTemplate).Append("\n");
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
            return this.Equals(httpsInput as Check);
        }

        /// <summary>
        /// Returns true if Check instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Check to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Check httpsInput)
        {
            if (httpsInput == null)
            {
                return false;
            }
            return 
                (
                    this.Id == httpsInput.Id ||
                    (this.Id != null &&
                    this.Id.Equals(httpsInput.Id))
                ) && 
                (
                    this.Type == httpsInput.Type ||
                    this.Type != null &&
                    httpsInput.Type != null &&
                    this.Type.SequenceEqual(httpsInput.Type)
                ) && 
                (
                    this.Checks == httpsInput.Checks ||
                    this.Checks != null &&
                    httpsInput.Checks != null &&
                    this.Checks.SequenceEqual(httpsInput.Checks)
                ) && 
                (
                    this.Events == httpsInput.Events ||
                    this.Events != null &&
                    httpsInput.Events != null &&
                    this.Events.SequenceEqual(httpsInput.Events)
                ) && 
                (
                    this.ExternalReferences == httpsInput.ExternalReferences ||
                    this.ExternalReferences != null &&
                    httpsInput.ExternalReferences != null &&
                    this.ExternalReferences.SequenceEqual(httpsInput.ExternalReferences)
                ) && 
                (
                    this.CompanyIdentifier == httpsInput.CompanyIdentifier ||
                    (this.CompanyIdentifier != null &&
                    this.CompanyIdentifier.Equals(httpsInput.CompanyIdentifier))
                ) && 
                (
                    this.SkeletonIndicator == httpsInput.SkeletonIndicator ||
                    this.SkeletonIndicator.Equals(httpsInput.SkeletonIndicator)
                ) && 
                (
                    this.ContactDetails == httpsInput.ContactDetails ||
                    this.ContactDetails != null &&
                    httpsInput.ContactDetails != null &&
                    this.ContactDetails.SequenceEqual(httpsInput.ContactDetails)
                ) && 
                (
                    this.ContactPersons == httpsInput.ContactPersons ||
                    this.ContactPersons != null &&
                    httpsInput.ContactPersons != null &&
                    this.ContactPersons.SequenceEqual(httpsInput.ContactPersons)
                ) && 
                (
                    this.LocationOfPerformance == httpsInput.LocationOfPerformance ||
                    (this.LocationOfPerformance != null &&
                    this.LocationOfPerformance.Equals(httpsInput.LocationOfPerformance))
                ) && 
                (
                    this.ServedActivity == httpsInput.ServedActivity ||
                    (this.ServedActivity != null &&
                    this.ServedActivity.Equals(httpsInput.ServedActivity))
                ) && 
                (
                    this.ActionEndTime == httpsInput.ActionEndTime ||
                    (this.ActionEndTime != null &&
                    this.ActionEndTime.Equals(httpsInput.ActionEndTime))
                ) && 
                (
                    this.ActionStartTime == httpsInput.ActionStartTime ||
                    (this.ActionStartTime != null &&
                    this.ActionStartTime.Equals(httpsInput.ActionStartTime))
                ) && 
                (
                    this.ActionTimeType == httpsInput.ActionTimeType ||
                    (this.ActionTimeType != null &&
                    this.ActionTimeType.Equals(httpsInput.ActionTimeType))
                ) && 
                (
                    this.CheckTotalResult == httpsInput.CheckTotalResult ||
                    (this.CheckTotalResult != null &&
                    this.CheckTotalResult.Equals(httpsInput.CheckTotalResult))
                ) && 
                (
                    this.CheckedObject == httpsInput.CheckedObject ||
                    (this.CheckedObject != null &&
                    this.CheckedObject.Equals(httpsInput.CheckedObject))
                ) && 
                (
                    this.Checker == httpsInput.Checker ||
                    (this.Checker != null &&
                    this.Checker.Equals(httpsInput.Checker))
                ) && 
                (
                    this.UsedTemplate == httpsInput.UsedTemplate ||
                    (this.UsedTemplate != null &&
                    this.UsedTemplate.Equals(httpsInput.UsedTemplate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Checks != null)
                {
                    hashCode = (hashCode * 59) + this.Checks.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.ExternalReferences != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalReferences.GetHashCode();
                }
                if (this.CompanyIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SkeletonIndicator.GetHashCode();
                if (this.ContactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ContactDetails.GetHashCode();
                }
                if (this.ContactPersons != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPersons.GetHashCode();
                }
                if (this.LocationOfPerformance != null)
                {
                    hashCode = (hashCode * 59) + this.LocationOfPerformance.GetHashCode();
                }
                if (this.ServedActivity != null)
                {
                    hashCode = (hashCode * 59) + this.ServedActivity.GetHashCode();
                }
                if (this.ActionEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActionEndTime.GetHashCode();
                }
                if (this.ActionStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActionStartTime.GetHashCode();
                }
                if (this.ActionTimeType != null)
                {
                    hashCode = (hashCode * 59) + this.ActionTimeType.GetHashCode();
                }
                if (this.CheckTotalResult != null)
                {
                    hashCode = (hashCode * 59) + this.CheckTotalResult.GetHashCode();
                }
                if (this.CheckedObject != null)
                {
                    hashCode = (hashCode * 59) + this.CheckedObject.GetHashCode();
                }
                if (this.Checker != null)
                {
                    hashCode = (hashCode * 59) + this.Checker.GetHashCode();
                }
                if (this.UsedTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UsedTemplate.GetHashCode();
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
