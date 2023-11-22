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
    /// BillingDetails
    /// </summary>
    [DataContract(Name = "BillingDetails")]
    public partial class BillingDetails : IEquatable<BillingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingDetails" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargoadjustments">Cargoadjustments.</param>
        /// <param name="httpsCargodetailedWaybill">CargodetailedWaybill.</param>
        /// <param name="httpsCargotaxDueAgent">CargotaxDueAgent.</param>
        /// <param name="httpsCargotaxDueAirline">CargotaxDueAirline.</param>
        /// <param name="httpsCargoawbAcceptanceDate">CargoawbAcceptanceDate.</param>
        /// <param name="httpsCargoawbDeliveryDate">CargoawbDeliveryDate.</param>
        /// <param name="httpsCargoawbExecutionDate">CargoawbExecutionDate.</param>
        /// <param name="httpsCargoawbUseIndicator">CargoawbUseIndicator.</param>
        /// <param name="httpsCargocommission">Cargocommission.</param>
        /// <param name="httpsCargocommissionIndicator">CargocommissionIndicator.</param>
        /// <param name="httpsCargocommissionPercentage">CargocommissionPercentage.</param>
        /// <param name="httpsCargodiscount">Cargodiscount.</param>
        /// <param name="httpsCargoexchangeRate">CargoexchangeRate.</param>
        /// <param name="httpsCargonbCorrections">CargonbCorrections.</param>
        /// <param name="httpsCargovatIndicator">CargovatIndicator.</param>
        public BillingDetails(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<Adjustments> httpsCargoadjustments = default(List<Adjustments>), Waybill httpsCargodetailedWaybill = default(Waybill), Value httpsCargotaxDueAgent = default(Value), Value httpsCargotaxDueAirline = default(Value), DateTime httpsCargoawbAcceptanceDate = default(DateTime), DateTime httpsCargoawbDeliveryDate = default(DateTime), DateTime httpsCargoawbExecutionDate = default(DateTime), bool httpsCargoawbUseIndicator = default(bool), double httpsCargocommission = default(double), bool httpsCargocommissionIndicator = default(bool), double httpsCargocommissionPercentage = default(double), double httpsCargodiscount = default(double), double httpsCargoexchangeRate = default(double), int httpsCargonbCorrections = default(int), bool httpsCargovatIndicator = default(bool))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargoadjustments = httpsCargoadjustments;
            this.HttpsCargodetailedWaybill = httpsCargodetailedWaybill;
            this.HttpsCargotaxDueAgent = httpsCargotaxDueAgent;
            this.HttpsCargotaxDueAirline = httpsCargotaxDueAirline;
            this.HttpsCargoawbAcceptanceDate = httpsCargoawbAcceptanceDate;
            this.HttpsCargoawbDeliveryDate = httpsCargoawbDeliveryDate;
            this.HttpsCargoawbExecutionDate = httpsCargoawbExecutionDate;
            this.HttpsCargoawbUseIndicator = httpsCargoawbUseIndicator;
            this.HttpsCargocommission = httpsCargocommission;
            this.HttpsCargocommissionIndicator = httpsCargocommissionIndicator;
            this.HttpsCargocommissionPercentage = httpsCargocommissionPercentage;
            this.HttpsCargodiscount = httpsCargodiscount;
            this.HttpsCargoexchangeRate = httpsCargoexchangeRate;
            this.HttpsCargonbCorrections = httpsCargonbCorrections;
            this.HttpsCargovatIndicator = httpsCargovatIndicator;
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
        /// Gets or Sets Cargoadjustments
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#adjustments", EmitDefaultValue = false)]
        public List<Adjustments> HttpsCargoadjustments { get; set; }

        /// <summary>
        /// Gets or Sets CargodetailedWaybill
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#detailedWaybill", EmitDefaultValue = false)]
        public Waybill HttpsCargodetailedWaybill { get; set; }

        /// <summary>
        /// Gets or Sets CargotaxDueAgent
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#taxDueAgent", EmitDefaultValue = false)]
        public Value HttpsCargotaxDueAgent { get; set; }

        /// <summary>
        /// Gets or Sets CargotaxDueAirline
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#taxDueAirline", EmitDefaultValue = false)]
        public Value HttpsCargotaxDueAirline { get; set; }

        /// <summary>
        /// Gets or Sets CargoawbAcceptanceDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#awbAcceptanceDate", EmitDefaultValue = false)]
        public DateTime HttpsCargoawbAcceptanceDate { get; set; }

        /// <summary>
        /// Gets or Sets CargoawbDeliveryDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#awbDeliveryDate", EmitDefaultValue = false)]
        public DateTime HttpsCargoawbDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets CargoawbExecutionDate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#awbExecutionDate", EmitDefaultValue = false)]
        public DateTime HttpsCargoawbExecutionDate { get; set; }

        /// <summary>
        /// Gets or Sets CargoawbUseIndicator
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#awbUseIndicator", EmitDefaultValue = true)]
        public bool HttpsCargoawbUseIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Cargocommission
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#commission", EmitDefaultValue = false)]
        public double HttpsCargocommission { get; set; }

        /// <summary>
        /// Gets or Sets CargocommissionIndicator
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#commissionIndicator", EmitDefaultValue = true)]
        public bool HttpsCargocommissionIndicator { get; set; }

        /// <summary>
        /// Gets or Sets CargocommissionPercentage
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#commissionPercentage", EmitDefaultValue = false)]
        public double HttpsCargocommissionPercentage { get; set; }

        /// <summary>
        /// Gets or Sets Cargodiscount
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#discount", EmitDefaultValue = false)]
        public double HttpsCargodiscount { get; set; }

        /// <summary>
        /// Gets or Sets CargoexchangeRate
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#exchangeRate", EmitDefaultValue = false)]
        public double HttpsCargoexchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets CargonbCorrections
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#nbCorrections", EmitDefaultValue = false)]
        public int HttpsCargonbCorrections { get; set; }

        /// <summary>
        /// Gets or Sets CargovatIndicator
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#vatIndicator", EmitDefaultValue = true)]
        public bool HttpsCargovatIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingDetails {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  Cargoadjustments: ").Append(HttpsCargoadjustments).Append("\n");
            sb.Append("  CargodetailedWaybill: ").Append(HttpsCargodetailedWaybill).Append("\n");
            sb.Append("  CargotaxDueAgent: ").Append(HttpsCargotaxDueAgent).Append("\n");
            sb.Append("  CargotaxDueAirline: ").Append(HttpsCargotaxDueAirline).Append("\n");
            sb.Append("  CargoawbAcceptanceDate: ").Append(HttpsCargoawbAcceptanceDate).Append("\n");
            sb.Append("  CargoawbDeliveryDate: ").Append(HttpsCargoawbDeliveryDate).Append("\n");
            sb.Append("  CargoawbExecutionDate: ").Append(HttpsCargoawbExecutionDate).Append("\n");
            sb.Append("  CargoawbUseIndicator: ").Append(HttpsCargoawbUseIndicator).Append("\n");
            sb.Append("  Cargocommission: ").Append(HttpsCargocommission).Append("\n");
            sb.Append("  CargocommissionIndicator: ").Append(HttpsCargocommissionIndicator).Append("\n");
            sb.Append("  CargocommissionPercentage: ").Append(HttpsCargocommissionPercentage).Append("\n");
            sb.Append("  Cargodiscount: ").Append(HttpsCargodiscount).Append("\n");
            sb.Append("  CargoexchangeRate: ").Append(HttpsCargoexchangeRate).Append("\n");
            sb.Append("  CargonbCorrections: ").Append(HttpsCargonbCorrections).Append("\n");
            sb.Append("  CargovatIndicator: ").Append(HttpsCargovatIndicator).Append("\n");
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
            return this.Equals(httpsInput as BillingDetails);
        }

        /// <summary>
        /// Returns true if BillingDetails instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of BillingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingDetails httpsInput)
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
                    this.HttpsCargoadjustments == httpsInput.HttpsCargoadjustments ||
                    this.HttpsCargoadjustments != null &&
                    httpsInput.HttpsCargoadjustments != null &&
                    this.HttpsCargoadjustments.SequenceEqual(httpsInput.HttpsCargoadjustments)
                ) && 
                (
                    this.HttpsCargodetailedWaybill == httpsInput.HttpsCargodetailedWaybill ||
                    (this.HttpsCargodetailedWaybill != null &&
                    this.HttpsCargodetailedWaybill.Equals(httpsInput.HttpsCargodetailedWaybill))
                ) && 
                (
                    this.HttpsCargotaxDueAgent == httpsInput.HttpsCargotaxDueAgent ||
                    (this.HttpsCargotaxDueAgent != null &&
                    this.HttpsCargotaxDueAgent.Equals(httpsInput.HttpsCargotaxDueAgent))
                ) && 
                (
                    this.HttpsCargotaxDueAirline == httpsInput.HttpsCargotaxDueAirline ||
                    (this.HttpsCargotaxDueAirline != null &&
                    this.HttpsCargotaxDueAirline.Equals(httpsInput.HttpsCargotaxDueAirline))
                ) && 
                (
                    this.HttpsCargoawbAcceptanceDate == httpsInput.HttpsCargoawbAcceptanceDate ||
                    (this.HttpsCargoawbAcceptanceDate != null &&
                    this.HttpsCargoawbAcceptanceDate.Equals(httpsInput.HttpsCargoawbAcceptanceDate))
                ) && 
                (
                    this.HttpsCargoawbDeliveryDate == httpsInput.HttpsCargoawbDeliveryDate ||
                    (this.HttpsCargoawbDeliveryDate != null &&
                    this.HttpsCargoawbDeliveryDate.Equals(httpsInput.HttpsCargoawbDeliveryDate))
                ) && 
                (
                    this.HttpsCargoawbExecutionDate == httpsInput.HttpsCargoawbExecutionDate ||
                    (this.HttpsCargoawbExecutionDate != null &&
                    this.HttpsCargoawbExecutionDate.Equals(httpsInput.HttpsCargoawbExecutionDate))
                ) && 
                (
                    this.HttpsCargoawbUseIndicator == httpsInput.HttpsCargoawbUseIndicator ||
                    this.HttpsCargoawbUseIndicator.Equals(httpsInput.HttpsCargoawbUseIndicator)
                ) && 
                (
                    this.HttpsCargocommission == httpsInput.HttpsCargocommission ||
                    this.HttpsCargocommission.Equals(httpsInput.HttpsCargocommission)
                ) && 
                (
                    this.HttpsCargocommissionIndicator == httpsInput.HttpsCargocommissionIndicator ||
                    this.HttpsCargocommissionIndicator.Equals(httpsInput.HttpsCargocommissionIndicator)
                ) && 
                (
                    this.HttpsCargocommissionPercentage == httpsInput.HttpsCargocommissionPercentage ||
                    this.HttpsCargocommissionPercentage.Equals(httpsInput.HttpsCargocommissionPercentage)
                ) && 
                (
                    this.HttpsCargodiscount == httpsInput.HttpsCargodiscount ||
                    this.HttpsCargodiscount.Equals(httpsInput.HttpsCargodiscount)
                ) && 
                (
                    this.HttpsCargoexchangeRate == httpsInput.HttpsCargoexchangeRate ||
                    this.HttpsCargoexchangeRate.Equals(httpsInput.HttpsCargoexchangeRate)
                ) && 
                (
                    this.HttpsCargonbCorrections == httpsInput.HttpsCargonbCorrections ||
                    this.HttpsCargonbCorrections.Equals(httpsInput.HttpsCargonbCorrections)
                ) && 
                (
                    this.HttpsCargovatIndicator == httpsInput.HttpsCargovatIndicator ||
                    this.HttpsCargovatIndicator.Equals(httpsInput.HttpsCargovatIndicator)
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
                if (this.HttpsCargoadjustments != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoadjustments.GetHashCode();
                }
                if (this.HttpsCargodetailedWaybill != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodetailedWaybill.GetHashCode();
                }
                if (this.HttpsCargotaxDueAgent != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargotaxDueAgent.GetHashCode();
                }
                if (this.HttpsCargotaxDueAirline != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargotaxDueAirline.GetHashCode();
                }
                if (this.HttpsCargoawbAcceptanceDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoawbAcceptanceDate.GetHashCode();
                }
                if (this.HttpsCargoawbDeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoawbDeliveryDate.GetHashCode();
                }
                if (this.HttpsCargoawbExecutionDate != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoawbExecutionDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsCargoawbUseIndicator.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargocommission.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargocommissionIndicator.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargocommissionPercentage.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargodiscount.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargoexchangeRate.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargonbCorrections.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpsCargovatIndicator.GetHashCode();
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