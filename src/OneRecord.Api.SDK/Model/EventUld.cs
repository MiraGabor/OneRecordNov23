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
    /// EventUld
    /// </summary>
    [DataContract(Name = "EventUld")]
    public partial class EventUld : IEquatable<EventUld>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventUld" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargolinkedObject">CargolinkedObject.</param>
        /// <param name="httpsCargorecordedAtLocation">CargorecordedAtLocation.</param>
        /// <param name="httpsCargorecordedBy">CargorecordedBy.</param>
        /// <param name="httpsCargorecordedByActor">CargorecordedByActor.</param>
        /// <param name="httpsCargocreationDate">CargocreationDate.</param>
        /// <param name="httpsCargoeventCode">CargoeventCode.</param>
        /// <param name="httpsCargoeventDate">CargoeventDate.</param>
        /// <param name="httpsCargoeventName">CargoeventName.</param>
        /// <param name="httpsCargoeventTimeType">CargoeventTimeType.</param>
        /// <param name="httpsCargoloadingPosition">CargoloadingPosition.</param>
        public EventUld(string httpsId = default(string), List<string> httpsType = default(List<string>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), LogisticsObject httpsCargolinkedObject = default(LogisticsObject), Location httpsCargorecordedAtLocation = default(Location), Organization httpsCargorecordedBy = default(Organization), Actor httpsCargorecordedByActor = default(Actor), DateTime httpsCargocreationDate = default(DateTime), string httpsCargoeventCode = default(string), DateTime httpsCargoeventDate = default(DateTime), string httpsCargoeventName = default(string), string httpsCargoeventTimeType = default(string), string httpsCargoloadingPosition = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargolinkedObject = httpsCargolinkedObject;
            this.HttpsCargorecordedAtLocation = httpsCargorecordedAtLocation;
            this.HttpsCargorecordedBy = httpsCargorecordedBy;
            this.HttpsCargorecordedByActor = httpsCargorecordedByActor;
            this.HttpsCargocreationDate = httpsCargocreationDate;
            this.HttpsCargoeventCode = httpsCargoeventCode;
            this.HttpsCargoeventDate = httpsCargoeventDate;
            this.HttpsCargoeventName = httpsCargoeventName;
            this.HttpsCargoeventTimeType = httpsCargoeventTimeType;
            this.HttpsCargoloadingPosition = httpsCargoloadingPosition;
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
        /// Gets or Sets CargoexternalReferences
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#externalReferences", EmitDefaultValue = false)]
        public List<ExternalReference> HttpsCargoexternalReferences { get; set; }

        /// <summary>
        /// Gets or Sets CargolinkedObject
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#linkedObject", EmitDefaultValue = false)]
        public LogisticsObject HttpsCargolinkedObject { get; set; }

        /// <summary>
        /// Gets or Sets CargorecordedAtLocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#recordedAtLocation", EmitDefaultValue = false)]
        public Location HttpsCargorecordedAtLocation { get; set; }

        /// <summary>
        /// Gets or Sets CargorecordedBy
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#recordedBy", EmitDefaultValue = false)]
        public Organization HttpsCargorecordedBy { get; set; }

        /// <summary>
        /// Gets or Sets CargorecordedByActor
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#recordedByActor", EmitDefaultValue = false)]
        public Actor HttpsCargorecordedByActor { get; set; }

        /// <summary>
        /// Gets or Sets CargocreationDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#creationDate", EmitDefaultValue = false)]
        public DateTime HttpsCargocreationDate { get; set; }

        /// <summary>
        /// Gets or Sets CargoeventCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#eventCode", EmitDefaultValue = false)]
        public string HttpsCargoeventCode { get; set; }

        /// <summary>
        /// Gets or Sets CargoeventDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#eventDate", EmitDefaultValue = false)]
        public DateTime HttpsCargoeventDate { get; set; }

        /// <summary>
        /// Gets or Sets CargoeventName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#eventName", EmitDefaultValue = false)]
        public string HttpsCargoeventName { get; set; }

        /// <summary>
        /// Gets or Sets CargoeventTimeType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#eventTimeType", EmitDefaultValue = false)]
        public string HttpsCargoeventTimeType { get; set; }

        /// <summary>
        /// Gets or Sets CargoloadingPosition
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#loadingPosition", EmitDefaultValue = false)]
        public string HttpsCargoloadingPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventUld {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargolinkedObject: ").Append(HttpsCargolinkedObject).Append("\n");
            sb.Append("  CargorecordedAtLocation: ").Append(HttpsCargorecordedAtLocation).Append("\n");
            sb.Append("  CargorecordedBy: ").Append(HttpsCargorecordedBy).Append("\n");
            sb.Append("  CargorecordedByActor: ").Append(HttpsCargorecordedByActor).Append("\n");
            sb.Append("  CargocreationDate: ").Append(HttpsCargocreationDate).Append("\n");
            sb.Append("  CargoeventCode: ").Append(HttpsCargoeventCode).Append("\n");
            sb.Append("  CargoeventDate: ").Append(HttpsCargoeventDate).Append("\n");
            sb.Append("  CargoeventName: ").Append(HttpsCargoeventName).Append("\n");
            sb.Append("  CargoeventTimeType: ").Append(HttpsCargoeventTimeType).Append("\n");
            sb.Append("  CargoloadingPosition: ").Append(HttpsCargoloadingPosition).Append("\n");
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
            return this.Equals(httpsInput as EventUld);
        }

        /// <summary>
        /// Returns true if EventUld instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of EventUld to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventUld httpsInput)
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
                    this.HttpsCargoexternalReferences == httpsInput.HttpsCargoexternalReferences ||
                    this.HttpsCargoexternalReferences != null &&
                    httpsInput.HttpsCargoexternalReferences != null &&
                    this.HttpsCargoexternalReferences.SequenceEqual(httpsInput.HttpsCargoexternalReferences)
                ) && 
                (
                    this.HttpsCargolinkedObject == httpsInput.HttpsCargolinkedObject ||
                    (this.HttpsCargolinkedObject != null &&
                    this.HttpsCargolinkedObject.Equals(httpsInput.HttpsCargolinkedObject))
                ) && 
                (
                    this.HttpsCargorecordedAtLocation == httpsInput.HttpsCargorecordedAtLocation ||
                    (this.HttpsCargorecordedAtLocation != null &&
                    this.HttpsCargorecordedAtLocation.Equals(httpsInput.HttpsCargorecordedAtLocation))
                ) && 
                (
                    this.HttpsCargorecordedBy == httpsInput.HttpsCargorecordedBy ||
                    (this.HttpsCargorecordedBy != null &&
                    this.HttpsCargorecordedBy.Equals(httpsInput.HttpsCargorecordedBy))
                ) && 
                (
                    this.HttpsCargorecordedByActor == httpsInput.HttpsCargorecordedByActor ||
                    (this.HttpsCargorecordedByActor != null &&
                    this.HttpsCargorecordedByActor.Equals(httpsInput.HttpsCargorecordedByActor))
                ) && 
                (
                    this.HttpsCargocreationDate == httpsInput.HttpsCargocreationDate ||
                    (this.HttpsCargocreationDate != null &&
                    this.HttpsCargocreationDate.Equals(httpsInput.HttpsCargocreationDate))
                ) && 
                (
                    this.HttpsCargoeventCode == httpsInput.HttpsCargoeventCode ||
                    (this.HttpsCargoeventCode != null &&
                    this.HttpsCargoeventCode.Equals(httpsInput.HttpsCargoeventCode))
                ) && 
                (
                    this.HttpsCargoeventDate == httpsInput.HttpsCargoeventDate ||
                    (this.HttpsCargoeventDate != null &&
                    this.HttpsCargoeventDate.Equals(httpsInput.HttpsCargoeventDate))
                ) && 
                (
                    this.HttpsCargoeventName == httpsInput.HttpsCargoeventName ||
                    (this.HttpsCargoeventName != null &&
                    this.HttpsCargoeventName.Equals(httpsInput.HttpsCargoeventName))
                ) && 
                (
                    this.HttpsCargoeventTimeType == httpsInput.HttpsCargoeventTimeType ||
                    (this.HttpsCargoeventTimeType != null &&
                    this.HttpsCargoeventTimeType.Equals(httpsInput.HttpsCargoeventTimeType))
                ) && 
                (
                    this.HttpsCargoloadingPosition == httpsInput.HttpsCargoloadingPosition ||
                    (this.HttpsCargoloadingPosition != null &&
                    this.HttpsCargoloadingPosition.Equals(httpsInput.HttpsCargoloadingPosition))
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
                if (this.HttpsCargoexternalReferences != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoexternalReferences.GetHashCode();
                }
                if (this.HttpsCargolinkedObject != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargolinkedObject.GetHashCode();
                }
                if (this.HttpsCargorecordedAtLocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorecordedAtLocation.GetHashCode();
                }
                if (this.HttpsCargorecordedBy != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorecordedBy.GetHashCode();
                }
                if (this.HttpsCargorecordedByActor != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorecordedByActor.GetHashCode();
                }
                if (this.HttpsCargocreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocreationDate.GetHashCode();
                }
                if (this.HttpsCargoeventCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoeventCode.GetHashCode();
                }
                if (this.HttpsCargoeventDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoeventDate.GetHashCode();
                }
                if (this.HttpsCargoeventName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoeventName.GetHashCode();
                }
                if (this.HttpsCargoeventTimeType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoeventTimeType.GetHashCode();
                }
                if (this.HttpsCargoloadingPosition != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoloadingPosition.GetHashCode();
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
