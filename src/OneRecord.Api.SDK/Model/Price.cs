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
    /// Price
    /// </summary>
    [DataContract(Name = "Price")]
    public partial class Price : IEquatable<Price>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargoforBookingOptionRequest">CargoforBookingOptionRequest.</param>
        /// <param name="httpsCargoforBookingOptions">CargoforBookingOptions.</param>
        /// <param name="httpsCargoratings">Cargoratings.</param>
        /// <param name="httpsCargocarrierChargeCode">CargocarrierChargeCode.</param>
        /// <param name="httpsCargograndTotal">CargograndTotal.</param>
        /// <param name="httpsCargovalidUntil">CargovalidUntil.</param>
        public Price(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), BookingOptionRequest httpsCargoforBookingOptionRequest = default(BookingOptionRequest), BookingOption httpsCargoforBookingOptions = default(BookingOption), List<Ratings> httpsCargoratings = default(List<Ratings>), string httpsCargocarrierChargeCode = default(string), double httpsCargograndTotal = default(double), List<DateTime> httpsCargovalidUntil = default(List<DateTime>))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargoforBookingOptionRequest = httpsCargoforBookingOptionRequest;
            this.HttpsCargoforBookingOptions = httpsCargoforBookingOptions;
            this.HttpsCargoratings = httpsCargoratings;
            this.HttpsCargocarrierChargeCode = httpsCargocarrierChargeCode;
            this.HttpsCargograndTotal = httpsCargograndTotal;
            this.HttpsCargovalidUntil = httpsCargovalidUntil;
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
        /// Gets or Sets CargoforBookingOptionRequest
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#forBookingOptionRequest", EmitDefaultValue = false)]
        public BookingOptionRequest HttpsCargoforBookingOptionRequest { get; set; }

        /// <summary>
        /// Gets or Sets CargoforBookingOptions
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#forBookingOptions", EmitDefaultValue = false)]
        public BookingOption HttpsCargoforBookingOptions { get; set; }

        /// <summary>
        /// Gets or Sets Cargoratings
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#ratings", EmitDefaultValue = false)]
        public List<Ratings> HttpsCargoratings { get; set; }

        /// <summary>
        /// Gets or Sets CargocarrierChargeCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#carrierChargeCode", EmitDefaultValue = false)]
        public string HttpsCargocarrierChargeCode { get; set; }

        /// <summary>
        /// Gets or Sets CargograndTotal
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#grandTotal", EmitDefaultValue = false)]
        public double HttpsCargograndTotal { get; set; }

        /// <summary>
        /// Gets or Sets CargovalidUntil
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#validUntil", EmitDefaultValue = false)]
        public List<DateTime> HttpsCargovalidUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Price {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargoforBookingOptionRequest: ").Append(HttpsCargoforBookingOptionRequest).Append("\n");
            sb.Append("  CargoforBookingOptions: ").Append(HttpsCargoforBookingOptions).Append("\n");
            sb.Append("  Cargoratings: ").Append(HttpsCargoratings).Append("\n");
            sb.Append("  CargocarrierChargeCode: ").Append(HttpsCargocarrierChargeCode).Append("\n");
            sb.Append("  CargograndTotal: ").Append(HttpsCargograndTotal).Append("\n");
            sb.Append("  CargovalidUntil: ").Append(HttpsCargovalidUntil).Append("\n");
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
            return this.Equals(httpsInput as Price);
        }

        /// <summary>
        /// Returns true if Price instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Price to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Price httpsInput)
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
                    this.HttpsCargoforBookingOptionRequest == httpsInput.HttpsCargoforBookingOptionRequest ||
                    (this.HttpsCargoforBookingOptionRequest != null &&
                    this.HttpsCargoforBookingOptionRequest.Equals(httpsInput.HttpsCargoforBookingOptionRequest))
                ) && 
                (
                    this.HttpsCargoforBookingOptions == httpsInput.HttpsCargoforBookingOptions ||
                    (this.HttpsCargoforBookingOptions != null &&
                    this.HttpsCargoforBookingOptions.Equals(httpsInput.HttpsCargoforBookingOptions))
                ) && 
                (
                    this.HttpsCargoratings == httpsInput.HttpsCargoratings ||
                    this.HttpsCargoratings != null &&
                    httpsInput.HttpsCargoratings != null &&
                    this.HttpsCargoratings.SequenceEqual(httpsInput.HttpsCargoratings)
                ) && 
                (
                    this.HttpsCargocarrierChargeCode == httpsInput.HttpsCargocarrierChargeCode ||
                    (this.HttpsCargocarrierChargeCode != null &&
                    this.HttpsCargocarrierChargeCode.Equals(httpsInput.HttpsCargocarrierChargeCode))
                ) && 
                (
                    this.HttpsCargograndTotal == httpsInput.HttpsCargograndTotal ||
                    this.HttpsCargograndTotal.Equals(httpsInput.HttpsCargograndTotal)
                ) && 
                (
                    this.HttpsCargovalidUntil == httpsInput.HttpsCargovalidUntil ||
                    this.HttpsCargovalidUntil != null &&
                    httpsInput.HttpsCargovalidUntil != null &&
                    this.HttpsCargovalidUntil.SequenceEqual(httpsInput.HttpsCargovalidUntil)
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
                if (this.HttpsCargoforBookingOptionRequest != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoforBookingOptionRequest.GetHashCode();
                }
                if (this.HttpsCargoforBookingOptions != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoforBookingOptions.GetHashCode();
                }
                if (this.HttpsCargoratings != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoratings.GetHashCode();
                }
                if (this.HttpsCargocarrierChargeCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocarrierChargeCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargograndTotal.GetHashCode();
                if (this.HttpsCargovalidUntil != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargovalidUntil.GetHashCode();
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
