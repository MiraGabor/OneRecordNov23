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
    /// BookingRequest
    /// </summary>
    [DataContract(Name = "BookingRequest")]
    public partial class BookingRequest : LogisticsObject, IEquatable<BookingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingRequest" /> class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="Type">type.</param>
        /// <param name="Checks">Cargochecks.</param>
        /// <param name="Events">Cargoevents.</param>
        /// <param name="ExternalReferences">CargoexternalReferences.</param>
        /// <param name="CompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="SkeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargobooking">Cargobooking.</param>
        /// <param name="httpsCargobookingOption">CargobookingOption.</param>
        public BookingRequest(string Id = default(string), List<string> Type = default(List<string>), List<Check> Checks = default(List<Check>), List<LogisticsEvent> Events = default(List<LogisticsEvent>), List<ExternalReference> ExternalReferences = default(List<ExternalReference>), string CompanyIdentifier = default(string), bool SkeletonIndicator = default(bool), Booking httpsCargobooking = default(Booking), BookingOption httpsCargobookingOption = default(BookingOption))
        {
            this.Id = Id;
            this.Type = Type;
            this.Checks = Checks;
            this.Events = Events;
            this.ExternalReferences = ExternalReferences;
            this.CompanyIdentifier = CompanyIdentifier;
            this.SkeletonIndicator = SkeletonIndicator;
            this.HttpsCargobooking = httpsCargobooking;
            this.HttpsCargobookingOption = httpsCargobookingOption;
        }

     
        /// <summary>
        /// Gets or Sets Cargobooking
        /// </summary>
        [DataMember(Name = "cargo:booking", EmitDefaultValue = false)]
        public Booking HttpsCargobooking { get; set; }

        /// <summary>
        /// Gets or Sets CargobookingOption
        /// </summary>
        [DataMember(Name = "cargo:bookingOption", EmitDefaultValue = false)]
        public BookingOption HttpsCargobookingOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BookingRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Cargochecks: ").Append(Checks).Append("\n");
            sb.Append("  Cargoevents: ").Append(Events).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(ExternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(CompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(SkeletonIndicator).Append("\n");
            sb.Append("  Cargobooking: ").Append(HttpsCargobooking).Append("\n");
            sb.Append("  CargobookingOption: ").Append(HttpsCargobookingOption).Append("\n");
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
            return this.Equals(httpsInput as BookingRequest);
        }

        /// <summary>
        /// Returns true if BookingRequest instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of BookingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookingRequest httpsInput)
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
                    this.HttpsCargobooking == httpsInput.HttpsCargobooking ||
                    (this.HttpsCargobooking != null &&
                    this.HttpsCargobooking.Equals(httpsInput.HttpsCargobooking))
                ) && 
                (
                    this.HttpsCargobookingOption == httpsInput.HttpsCargobookingOption ||
                    (this.HttpsCargobookingOption != null &&
                    this.HttpsCargobookingOption.Equals(httpsInput.HttpsCargobookingOption))
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
                if (this.HttpsCargobooking != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargobooking.GetHashCode();
                }
                if (this.HttpsCargobookingOption != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargobookingOption.GetHashCode();
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
