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
    /// Ratings
    /// </summary>
    [DataContract(Name = "Ratings")]
    public partial class Ratings : IEquatable<Ratings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ratings" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargoforPrices">CargoforPrices.</param>
        /// <param name="httpsCargopreferenceOfRequests">CargopreferenceOfRequests.</param>
        /// <param name="httpsCargoranges">Cargoranges.</param>
        /// <param name="httpsCargobillingChargeIdentifier">CargobillingChargeIdentifier.</param>
        /// <param name="httpsCargochargeCode">CargochargeCode.</param>
        /// <param name="httpsCargochargeDescription">CargochargeDescription.</param>
        /// <param name="httpsCargochargePaymentType">CargochargePaymentType.</param>
        /// <param name="httpsCargochargeType">CargochargeType.</param>
        /// <param name="httpsCargoentitlement">Cargoentitlement.</param>
        /// <param name="httpsCargootherChargeCode">CargootherChargeCode.</param>
        /// <param name="httpsCargopriceSpecification">CargopriceSpecification.</param>
        /// <param name="httpsCargopriceSpecificationRef">CargopriceSpecificationRef.</param>
        /// <param name="httpsCargorateQuantity">CargorateQuantity.</param>
        /// <param name="httpsCargoratingsType">CargoratingsType.</param>
        /// <param name="httpsCargorcp">Cargorcp.</param>
        /// <param name="httpsCargosubTotal">CargosubTotal.</param>
        public Ratings(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<Price> httpsCargoforPrices = default(List<Price>), List<BookingOptionRequest> httpsCargopreferenceOfRequests = default(List<BookingOptionRequest>), List<Ranges> httpsCargoranges = default(List<Ranges>), double httpsCargobillingChargeIdentifier = default(double), string httpsCargochargeCode = default(string), string httpsCargochargeDescription = default(string), string httpsCargochargePaymentType = default(string), string httpsCargochargeType = default(string), string httpsCargoentitlement = default(string), string httpsCargootherChargeCode = default(string), string httpsCargopriceSpecification = default(string), string httpsCargopriceSpecificationRef = default(string), string httpsCargorateQuantity = default(string), string httpsCargoratingsType = default(string), string httpsCargorcp = default(string), double httpsCargosubTotal = default(double))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargoforPrices = httpsCargoforPrices;
            this.HttpsCargopreferenceOfRequests = httpsCargopreferenceOfRequests;
            this.HttpsCargoranges = httpsCargoranges;
            this.HttpsCargobillingChargeIdentifier = httpsCargobillingChargeIdentifier;
            this.HttpsCargochargeCode = httpsCargochargeCode;
            this.HttpsCargochargeDescription = httpsCargochargeDescription;
            this.HttpsCargochargePaymentType = httpsCargochargePaymentType;
            this.HttpsCargochargeType = httpsCargochargeType;
            this.HttpsCargoentitlement = httpsCargoentitlement;
            this.HttpsCargootherChargeCode = httpsCargootherChargeCode;
            this.HttpsCargopriceSpecification = httpsCargopriceSpecification;
            this.HttpsCargopriceSpecificationRef = httpsCargopriceSpecificationRef;
            this.HttpsCargorateQuantity = httpsCargorateQuantity;
            this.HttpsCargoratingsType = httpsCargoratingsType;
            this.HttpsCargorcp = httpsCargorcp;
            this.HttpsCargosubTotal = httpsCargosubTotal;
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
        /// Gets or Sets CargoforPrices
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#forPrices", EmitDefaultValue = false)]
        public List<Price> HttpsCargoforPrices { get; set; }

        /// <summary>
        /// Gets or Sets CargopreferenceOfRequests
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#preferenceOfRequests", EmitDefaultValue = false)]
        public List<BookingOptionRequest> HttpsCargopreferenceOfRequests { get; set; }

        /// <summary>
        /// Gets or Sets Cargoranges
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#ranges", EmitDefaultValue = false)]
        public List<Ranges> HttpsCargoranges { get; set; }

        /// <summary>
        /// Gets or Sets CargobillingChargeIdentifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#billingChargeIdentifier", EmitDefaultValue = false)]
        public double HttpsCargobillingChargeIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CargochargeCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#chargeCode", EmitDefaultValue = false)]
        public string HttpsCargochargeCode { get; set; }

        /// <summary>
        /// Gets or Sets CargochargeDescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#chargeDescription", EmitDefaultValue = false)]
        public string HttpsCargochargeDescription { get; set; }

        /// <summary>
        /// Gets or Sets CargochargePaymentType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#chargePaymentType", EmitDefaultValue = false)]
        public string HttpsCargochargePaymentType { get; set; }

        /// <summary>
        /// Gets or Sets CargochargeType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#chargeType", EmitDefaultValue = false)]
        public string HttpsCargochargeType { get; set; }

        /// <summary>
        /// Gets or Sets Cargoentitlement
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#entitlement", EmitDefaultValue = false)]
        public string HttpsCargoentitlement { get; set; }

        /// <summary>
        /// Gets or Sets CargootherChargeCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#otherChargeCode", EmitDefaultValue = false)]
        public string HttpsCargootherChargeCode { get; set; }

        /// <summary>
        /// Gets or Sets CargopriceSpecification
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#priceSpecification", EmitDefaultValue = false)]
        public string HttpsCargopriceSpecification { get; set; }

        /// <summary>
        /// Gets or Sets CargopriceSpecificationRef
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#priceSpecificationRef", EmitDefaultValue = false)]
        public string HttpsCargopriceSpecificationRef { get; set; }

        /// <summary>
        /// Gets or Sets CargorateQuantity
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#rateQuantity", EmitDefaultValue = false)]
        public string HttpsCargorateQuantity { get; set; }

        /// <summary>
        /// Gets or Sets CargoratingsType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#ratingsType", EmitDefaultValue = false)]
        public string HttpsCargoratingsType { get; set; }

        /// <summary>
        /// Gets or Sets Cargorcp
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#rcp", EmitDefaultValue = false)]
        public string HttpsCargorcp { get; set; }

        /// <summary>
        /// Gets or Sets CargosubTotal
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#subTotal", EmitDefaultValue = false)]
        public double HttpsCargosubTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Ratings {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargoforPrices: ").Append(HttpsCargoforPrices).Append("\n");
            sb.Append("  CargopreferenceOfRequests: ").Append(HttpsCargopreferenceOfRequests).Append("\n");
            sb.Append("  Cargoranges: ").Append(HttpsCargoranges).Append("\n");
            sb.Append("  CargobillingChargeIdentifier: ").Append(HttpsCargobillingChargeIdentifier).Append("\n");
            sb.Append("  CargochargeCode: ").Append(HttpsCargochargeCode).Append("\n");
            sb.Append("  CargochargeDescription: ").Append(HttpsCargochargeDescription).Append("\n");
            sb.Append("  CargochargePaymentType: ").Append(HttpsCargochargePaymentType).Append("\n");
            sb.Append("  CargochargeType: ").Append(HttpsCargochargeType).Append("\n");
            sb.Append("  Cargoentitlement: ").Append(HttpsCargoentitlement).Append("\n");
            sb.Append("  CargootherChargeCode: ").Append(HttpsCargootherChargeCode).Append("\n");
            sb.Append("  CargopriceSpecification: ").Append(HttpsCargopriceSpecification).Append("\n");
            sb.Append("  CargopriceSpecificationRef: ").Append(HttpsCargopriceSpecificationRef).Append("\n");
            sb.Append("  CargorateQuantity: ").Append(HttpsCargorateQuantity).Append("\n");
            sb.Append("  CargoratingsType: ").Append(HttpsCargoratingsType).Append("\n");
            sb.Append("  Cargorcp: ").Append(HttpsCargorcp).Append("\n");
            sb.Append("  CargosubTotal: ").Append(HttpsCargosubTotal).Append("\n");
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
            return this.Equals(httpsInput as Ratings);
        }

        /// <summary>
        /// Returns true if Ratings instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Ratings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ratings httpsInput)
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
                    this.HttpsCargoforPrices == httpsInput.HttpsCargoforPrices ||
                    this.HttpsCargoforPrices != null &&
                    httpsInput.HttpsCargoforPrices != null &&
                    this.HttpsCargoforPrices.SequenceEqual(httpsInput.HttpsCargoforPrices)
                ) && 
                (
                    this.HttpsCargopreferenceOfRequests == httpsInput.HttpsCargopreferenceOfRequests ||
                    this.HttpsCargopreferenceOfRequests != null &&
                    httpsInput.HttpsCargopreferenceOfRequests != null &&
                    this.HttpsCargopreferenceOfRequests.SequenceEqual(httpsInput.HttpsCargopreferenceOfRequests)
                ) && 
                (
                    this.HttpsCargoranges == httpsInput.HttpsCargoranges ||
                    this.HttpsCargoranges != null &&
                    httpsInput.HttpsCargoranges != null &&
                    this.HttpsCargoranges.SequenceEqual(httpsInput.HttpsCargoranges)
                ) && 
                (
                    this.HttpsCargobillingChargeIdentifier == httpsInput.HttpsCargobillingChargeIdentifier ||
                    this.HttpsCargobillingChargeIdentifier.Equals(httpsInput.HttpsCargobillingChargeIdentifier)
                ) && 
                (
                    this.HttpsCargochargeCode == httpsInput.HttpsCargochargeCode ||
                    (this.HttpsCargochargeCode != null &&
                    this.HttpsCargochargeCode.Equals(httpsInput.HttpsCargochargeCode))
                ) && 
                (
                    this.HttpsCargochargeDescription == httpsInput.HttpsCargochargeDescription ||
                    (this.HttpsCargochargeDescription != null &&
                    this.HttpsCargochargeDescription.Equals(httpsInput.HttpsCargochargeDescription))
                ) && 
                (
                    this.HttpsCargochargePaymentType == httpsInput.HttpsCargochargePaymentType ||
                    (this.HttpsCargochargePaymentType != null &&
                    this.HttpsCargochargePaymentType.Equals(httpsInput.HttpsCargochargePaymentType))
                ) && 
                (
                    this.HttpsCargochargeType == httpsInput.HttpsCargochargeType ||
                    (this.HttpsCargochargeType != null &&
                    this.HttpsCargochargeType.Equals(httpsInput.HttpsCargochargeType))
                ) && 
                (
                    this.HttpsCargoentitlement == httpsInput.HttpsCargoentitlement ||
                    (this.HttpsCargoentitlement != null &&
                    this.HttpsCargoentitlement.Equals(httpsInput.HttpsCargoentitlement))
                ) && 
                (
                    this.HttpsCargootherChargeCode == httpsInput.HttpsCargootherChargeCode ||
                    (this.HttpsCargootherChargeCode != null &&
                    this.HttpsCargootherChargeCode.Equals(httpsInput.HttpsCargootherChargeCode))
                ) && 
                (
                    this.HttpsCargopriceSpecification == httpsInput.HttpsCargopriceSpecification ||
                    (this.HttpsCargopriceSpecification != null &&
                    this.HttpsCargopriceSpecification.Equals(httpsInput.HttpsCargopriceSpecification))
                ) && 
                (
                    this.HttpsCargopriceSpecificationRef == httpsInput.HttpsCargopriceSpecificationRef ||
                    (this.HttpsCargopriceSpecificationRef != null &&
                    this.HttpsCargopriceSpecificationRef.Equals(httpsInput.HttpsCargopriceSpecificationRef))
                ) && 
                (
                    this.HttpsCargorateQuantity == httpsInput.HttpsCargorateQuantity ||
                    (this.HttpsCargorateQuantity != null &&
                    this.HttpsCargorateQuantity.Equals(httpsInput.HttpsCargorateQuantity))
                ) && 
                (
                    this.HttpsCargoratingsType == httpsInput.HttpsCargoratingsType ||
                    (this.HttpsCargoratingsType != null &&
                    this.HttpsCargoratingsType.Equals(httpsInput.HttpsCargoratingsType))
                ) && 
                (
                    this.HttpsCargorcp == httpsInput.HttpsCargorcp ||
                    (this.HttpsCargorcp != null &&
                    this.HttpsCargorcp.Equals(httpsInput.HttpsCargorcp))
                ) && 
                (
                    this.HttpsCargosubTotal == httpsInput.HttpsCargosubTotal ||
                    this.HttpsCargosubTotal.Equals(httpsInput.HttpsCargosubTotal)
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
                if (this.HttpsCargoforPrices != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoforPrices.GetHashCode();
                }
                if (this.HttpsCargopreferenceOfRequests != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargopreferenceOfRequests.GetHashCode();
                }
                if (this.HttpsCargoranges != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoranges.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargobillingChargeIdentifier.GetHashCode();
                if (this.HttpsCargochargeCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargochargeCode.GetHashCode();
                }
                if (this.HttpsCargochargeDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargochargeDescription.GetHashCode();
                }
                if (this.HttpsCargochargePaymentType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargochargePaymentType.GetHashCode();
                }
                if (this.HttpsCargochargeType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargochargeType.GetHashCode();
                }
                if (this.HttpsCargoentitlement != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoentitlement.GetHashCode();
                }
                if (this.HttpsCargootherChargeCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargootherChargeCode.GetHashCode();
                }
                if (this.HttpsCargopriceSpecification != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargopriceSpecification.GetHashCode();
                }
                if (this.HttpsCargopriceSpecificationRef != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargopriceSpecificationRef.GetHashCode();
                }
                if (this.HttpsCargorateQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorateQuantity.GetHashCode();
                }
                if (this.HttpsCargoratingsType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoratingsType.GetHashCode();
                }
                if (this.HttpsCargorcp != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargorcp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargosubTotal.GetHashCode();
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
