/*
 * ONE Record API Documentation
 *
 * This OpenAPI specification describes the API endpoint structure of an ONE Record API implementation.<br/><br/><b>Note:</b><br/>The included schemas can only be used to generate JSON-LD in the extended document form.<br/>However, to be fully ONE Record compliant, any ONE Record API (and any compliant ONE Record client)<br/><b>MUST</b> support at least the expanded, compacted, and flattened document forms.<br/><br/>More information about the ONE Record specification are available on [IATA Github repository](://github.com/IATA-Cargo/ONE-Record) and on the [ONE Record Developer Portal](://onerecord.iata.org).
 *
 * The version of the OpenAPI document: 2.0.0-dev
 * Contact: onerecord@iata.org
 * Generated by: ://github.com/openapitools/openapi-generator.git
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
    /// Shipment
    /// </summary>
    [DataContract(Name = "Shipment")]
    public partial class Shipment : LogisticsObject, IEquatable<Shipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="Type">type.</param>
        /// <param name="Cargochecks">Cargochecks.</param>
        /// <param name="Cargoevents">Cargoevents.</param>
        /// <param name="CargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="CargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="CargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="CargoattachedIotDevices">CargoattachedIotDevices.</param>
        /// <param name="CargoinvolvedInActions">CargoinvolvedInActions.</param>
        /// <param name="CargodeliveryLocation">CargodeliveryLocation.</param>
        /// <param name="Cargoinsurance">Cargoinsurance.</param>
        /// <param name="CargoinvolvedParties">CargoinvolvedParties.</param>
        /// <param name="CargoshipmentOfPieces">CargoshipmentOfPieces.</param>
        /// <param name="CargototalDimensions">CargototalDimensions.</param>
        /// <param name="CargototalGrossWeight">CargototalGrossWeight.</param>
        /// <param name="CargototalVolumetricWeight">CargototalVolumetricWeight.</param>
        /// <param name="Cargowaybill">Cargowaybill.</param>
        /// <param name="CargodeliveryDate">CargodeliveryDate.</param>
        /// <param name="CargogoodsDescription">CargogoodsDescription.</param>
        /// <param name="Cargoincoterms">Cargoincoterms.</param>
        /// <param name="CargootherChargesIndicator">CargootherChargesIndicator.</param>
        /// <param name="CargototalSlac">CargototalSLAC.</param>
        /// <param name="CargoweightValuationIndicator">CargoweightValuationIndicator.</param>
        public Shipment(string Id = default(string), List<string> Type = default(List<string>), List<Check> Cargochecks = default(List<Check>), List<LogisticsEvent> Cargoevents = default(List<LogisticsEvent>), List<ExternalReference> CargoexternalReferences = default(List<ExternalReference>), string CargocompanyIdentifier = default(string), bool CargoskeletonIndicator = default(bool), List<IotDevice> CargoattachedIotDevices = default(List<IotDevice>), List<LogisticsAction> CargoinvolvedInActions = default(List<LogisticsAction>), Location CargodeliveryLocation = default(Location), Insurance Cargoinsurance = default(Insurance), List<Party> CargoinvolvedParties = default(List<Party>), List<Piece> CargoshipmentOfPieces = default(List<Piece>), List<Dimensions> CargototalDimensions = default(List<Dimensions>), Value CargototalGrossWeight = default(Value), VolumetricWeight CargototalVolumetricWeight = default(VolumetricWeight), Waybill Cargowaybill = default(Waybill), DateTime CargodeliveryDate = default(DateTime), string CargogoodsDescription = default(string), string Cargoincoterms = default(string), string CargootherChargesIndicator = default(string), int CargototalSlac = default(int), string CargoweightValuationIndicator = default(string))
        {
            this.Id = Id;
            this.Type = Type;
            this.Checks = Cargochecks;
            this.Events = Cargoevents;
            this.ExternalReferences = CargoexternalReferences;
            this.CompanyIdentifier = CargocompanyIdentifier;
            this.SkeletonIndicator = CargoskeletonIndicator;
            this.AttachedIotDevices = CargoattachedIotDevices;
            this.InvolvedInActions = CargoinvolvedInActions;
            this.DeliveryLocation = CargodeliveryLocation;
            this.Insurance = Cargoinsurance;
            this.InvolvedParties = CargoinvolvedParties;
            this.ShipmentOfPieces = CargoshipmentOfPieces;
            this.TotalDimensions = CargototalDimensions;
            this.TotalGrossWeight = CargototalGrossWeight;
            this.TotalVolumetricWeight = CargototalVolumetricWeight;
            this.Waybill = Cargowaybill;
            this.DeliveryDate = CargodeliveryDate;
            this.GoodsDescription = CargogoodsDescription;
            this.Incoterms = Cargoincoterms;
            this.OtherChargesIndicator = CargootherChargesIndicator;
            this.TotalSlac = CargototalSlac;
            this.WeightValuationIndicator = CargoweightValuationIndicator;
        }

        ///// <summary>
        ///// Gets or Sets Id
        ///// </summary>
        //[DataMember(Name = "@id", EmitDefaultValue = false)]
        //public string Id { get; set; }

        ///// <summary>
        ///// Gets or Sets Type
        ///// </summary>
        //[DataMember(Name = "@type", EmitDefaultValue = false)]
        //public List<string> Type { get; set; }

        ///// <summary>
        ///// Gets or Sets Checks
        ///// </summary>
        //[DataMember(Name = "cargo:checks", EmitDefaultValue = false)]
        //public List<Check> Checks { get; set; }

        ///// <summary>
        ///// Gets or Sets Events
        ///// </summary>
        //[DataMember(Name = "cargo:events", EmitDefaultValue = false)]
        //public List<LogisticsEvent> Events { get; set; }

        ///// <summary>
        ///// Gets or Sets ExternalReferences
        ///// </summary>
        //[DataMember(Name = "cargo:externalReferences", EmitDefaultValue = false)]
        //public List<ExternalReference> ExternalReferences { get; set; }

        ///// <summary>
        ///// Gets or Sets CargocompanyIdentifier
        ///// </summary>
        //[DataMember(Name = "cargo:companyIdentifier", EmitDefaultValue = false)]
        //public string CompanyIdentifier { get; set; }

        ///// <summary>
        ///// Gets or Sets SkeletonIndicator
        ///// </summary>
        //[DataMember(Name = "cargo:skeletonIndicator", EmitDefaultValue = true)]
        //public bool SkeletonIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "@context", EmitDefaultValue = true)]
        public Context Context = new Context
        {
            Cargo = "https://onerecord.iata.org/ns/cargo#"
        };


        /// <summary>
        /// Gets or Sets AttachedIotDevices
        /// </summary>
        [DataMember(Name = "cargo:attachedIotDevices", EmitDefaultValue = false)]
        public List<IotDevice> AttachedIotDevices { get; set; }

        /// <summary>
        /// Gets or Sets InvolvedInActions
        /// </summary>
        [DataMember(Name = "cargo:involvedInActions", EmitDefaultValue = false)]
        public List<LogisticsAction> InvolvedInActions { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryLocation
        /// </summary>
        [DataMember(Name = "cargo:deliveryLocation", EmitDefaultValue = false)]
        public Location DeliveryLocation { get; set; }

        /// <summary>
        /// Gets or Sets Insurance
        /// </summary>
        [DataMember(Name = "cargo:insurance", EmitDefaultValue = false)]
        public Insurance Insurance { get; set; }

        /// <summary>
        /// Gets or Sets InvolvedParties
        /// </summary>
        [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
        public List<Party> InvolvedParties { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentOfPieces
        /// </summary>
        [DataMember(Name = "cargo:shipmentOfPieces", EmitDefaultValue = false)]
        public List<Piece> ShipmentOfPieces { get; set; }

        /// <summary>
        /// Gets or Sets TotalDimensions
        /// </summary>
        [DataMember(Name = "cargo:totalDimensions", EmitDefaultValue = false)]
        public List<Dimensions> TotalDimensions { get; set; }

        /// <summary>
        /// Gets or Sets TotalGrossWeight
        /// </summary>
        [DataMember(Name = "cargo:totalGrossWeight", EmitDefaultValue = false)]
        public Value TotalGrossWeight { get; set; }

        /// <summary>
        /// Gets or Sets CargototalVolumetricWeight
        /// </summary>
        [DataMember(Name = "cargo:totalVolumetricWeight", EmitDefaultValue = false)]
        public VolumetricWeight TotalVolumetricWeight { get; set; }

        /// <summary>
        /// Gets or Sets Waybill
        /// </summary>
        [DataMember(Name = "cargo:waybill", EmitDefaultValue = false)]
        public Waybill Waybill { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryDate
        /// </summary>
        [DataMember(Name = "cargo:deliveryDate", EmitDefaultValue = false)]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets GoodsDescription
        /// </summary>
        [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
        public string GoodsDescription { get; set; }

        /// <summary>
        /// Gets or Sets Incoterms
        /// </summary>
        [DataMember(Name = "cargo:incoterms", EmitDefaultValue = false)]
        public string Incoterms { get; set; }

        /// <summary>
        /// Gets or Sets OtherChargesIndicator
        /// </summary>
        [DataMember(Name = "cargo:otherChargesIndicator", EmitDefaultValue = false)]
        public string OtherChargesIndicator { get; set; }

        /// <summary>
        /// Gets or Sets TotalSlac
        /// </summary>
        [DataMember(Name = "cargo:totalSLAC", EmitDefaultValue = false)]
        public int TotalSlac { get; set; }

        /// <summary>
        /// Gets or Sets WeightValuationIndicator
        /// </summary>
        [DataMember(Name = "cargo:weightValuationIndicator", EmitDefaultValue = false)]
        public string WeightValuationIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Shipment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  ExternalReferences: ").Append(ExternalReferences).Append("\n");
            sb.Append("  CompanyIdentifier: ").Append(CompanyIdentifier).Append("\n");
            sb.Append("  SkeletonIndicator: ").Append(SkeletonIndicator).Append("\n");
            sb.Append("  AttachedIotDevices: ").Append(AttachedIotDevices).Append("\n");
            sb.Append("  InvolvedInActions: ").Append(InvolvedInActions).Append("\n");
            sb.Append("  DeliveryLocation: ").Append(DeliveryLocation).Append("\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  InvolvedParties: ").Append(InvolvedParties).Append("\n");
            sb.Append("  ShipmentOfPieces: ").Append(ShipmentOfPieces).Append("\n");
            sb.Append("  TotalDimensions: ").Append(TotalDimensions).Append("\n");
            sb.Append("  TotalGrossWeight: ").Append(TotalGrossWeight).Append("\n");
            sb.Append("  TotalVolumetricWeight: ").Append(TotalVolumetricWeight).Append("\n");
            sb.Append("  Waybill: ").Append(Waybill).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  GoodsDescription: ").Append(GoodsDescription).Append("\n");
            sb.Append("  Incoterms: ").Append(Incoterms).Append("\n");
            sb.Append("  OtherChargesIndicator: ").Append(OtherChargesIndicator).Append("\n");
            sb.Append("  TotalSLAC: ").Append(TotalSlac).Append("\n");
            sb.Append("  WeightValuationIndicator: ").Append(WeightValuationIndicator).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Shipment);
        }

        /// <summary>
        /// Returns true if Shipment instances are equal
        /// </summary>
        /// <param name="input">Instance of Shipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    input.Type != null &&
                    this.Type.SequenceEqual(input.Type)
                ) && 
                (
                    this.Checks == input.Checks ||
                    this.Checks != null &&
                    input.Checks != null &&
                    this.Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.ExternalReferences == input.ExternalReferences ||
                    this.ExternalReferences != null &&
                    input.ExternalReferences != null &&
                    this.ExternalReferences.SequenceEqual(input.ExternalReferences)
                ) && 
                (
                    this.CompanyIdentifier == input.CompanyIdentifier ||
                    (this.CompanyIdentifier != null &&
                    this.CompanyIdentifier.Equals(input.CompanyIdentifier))
                ) && 
                (
                    this.SkeletonIndicator == input.SkeletonIndicator ||
                    this.SkeletonIndicator.Equals(input.SkeletonIndicator)
                ) && 
                (
                    this.AttachedIotDevices == input.AttachedIotDevices ||
                    this.AttachedIotDevices != null &&
                    input.AttachedIotDevices != null &&
                    this.AttachedIotDevices.SequenceEqual(input.AttachedIotDevices)
                ) && 
                (
                    this.InvolvedInActions == input.InvolvedInActions ||
                    this.InvolvedInActions != null &&
                    input.InvolvedInActions != null &&
                    this.InvolvedInActions.SequenceEqual(input.InvolvedInActions)
                ) && 
                (
                    this.DeliveryLocation == input.DeliveryLocation ||
                    (this.DeliveryLocation != null &&
                    this.DeliveryLocation.Equals(input.DeliveryLocation))
                ) && 
                (
                    this.Insurance == input.Insurance ||
                    (this.Insurance != null &&
                    this.Insurance.Equals(input.Insurance))
                ) && 
                (
                    this.InvolvedParties == input.InvolvedParties ||
                    this.InvolvedParties != null &&
                    input.InvolvedParties != null &&
                    this.InvolvedParties.SequenceEqual(input.InvolvedParties)
                ) && 
                (
                    this.ShipmentOfPieces == input.ShipmentOfPieces ||
                    this.ShipmentOfPieces != null &&
                    input.ShipmentOfPieces != null &&
                    this.ShipmentOfPieces.SequenceEqual(input.ShipmentOfPieces)
                ) && 
                (
                    this.TotalDimensions == input.TotalDimensions ||
                    this.TotalDimensions != null &&
                    input.TotalDimensions != null &&
                    this.TotalDimensions.SequenceEqual(input.TotalDimensions)
                ) && 
                (
                    this.TotalGrossWeight == input.TotalGrossWeight ||
                    (this.TotalGrossWeight != null &&
                    this.TotalGrossWeight.Equals(input.TotalGrossWeight))
                ) && 
                (
                    this.TotalVolumetricWeight == input.TotalVolumetricWeight ||
                    (this.TotalVolumetricWeight != null &&
                    this.TotalVolumetricWeight.Equals(input.TotalVolumetricWeight))
                ) && 
                (
                    this.Waybill == input.Waybill ||
                    (this.Waybill != null &&
                    this.Waybill.Equals(input.Waybill))
                ) && 
                (
                    this.DeliveryDate == input.DeliveryDate ||
                    (this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate))
                ) && 
                (
                    this.GoodsDescription == input.GoodsDescription ||
                    (this.GoodsDescription != null &&
                    this.GoodsDescription.Equals(input.GoodsDescription))
                ) && 
                (
                    this.Incoterms == input.Incoterms ||
                    (this.Incoterms != null &&
                    this.Incoterms.Equals(input.Incoterms))
                ) && 
                (
                    this.OtherChargesIndicator == input.OtherChargesIndicator ||
                    (this.OtherChargesIndicator != null &&
                    this.OtherChargesIndicator.Equals(input.OtherChargesIndicator))
                ) && 
                (
                    this.TotalSlac == input.TotalSlac ||
                    this.TotalSlac.Equals(input.TotalSlac)
                ) && 
                (
                    this.WeightValuationIndicator == input.WeightValuationIndicator ||
                    (this.WeightValuationIndicator != null &&
                    this.WeightValuationIndicator.Equals(input.WeightValuationIndicator))
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
                if (this.AttachedIotDevices != null)
                {
                    hashCode = (hashCode * 59) + this.AttachedIotDevices.GetHashCode();
                }
                if (this.InvolvedInActions != null)
                {
                    hashCode = (hashCode * 59) + this.InvolvedInActions.GetHashCode();
                }
                if (this.DeliveryLocation != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryLocation.GetHashCode();
                }
                if (this.Insurance != null)
                {
                    hashCode = (hashCode * 59) + this.Insurance.GetHashCode();
                }
                if (this.InvolvedParties != null)
                {
                    hashCode = (hashCode * 59) + this.InvolvedParties.GetHashCode();
                }
                if (this.ShipmentOfPieces != null)
                {
                    hashCode = (hashCode * 59) + this.ShipmentOfPieces.GetHashCode();
                }
                if (this.TotalDimensions != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDimensions.GetHashCode();
                }
                if (this.TotalGrossWeight != null)
                {
                    hashCode = (hashCode * 59) + this.TotalGrossWeight.GetHashCode();
                }
                if (this.TotalVolumetricWeight != null)
                {
                    hashCode = (hashCode * 59) + this.TotalVolumetricWeight.GetHashCode();
                }
                if (this.Waybill != null)
                {
                    hashCode = (hashCode * 59) + this.Waybill.GetHashCode();
                }
                if (this.DeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryDate.GetHashCode();
                }
                if (this.GoodsDescription != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDescription.GetHashCode();
                }
                if (this.Incoterms != null)
                {
                    hashCode = (hashCode * 59) + this.Incoterms.GetHashCode();
                }
                if (this.OtherChargesIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.OtherChargesIndicator.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalSlac.GetHashCode();
                if (this.WeightValuationIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.WeightValuationIndicator.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="httpsValidationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext ValidationContext)
        {
            yield break;
        }
    }

}