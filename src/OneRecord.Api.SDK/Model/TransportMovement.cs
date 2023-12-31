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
    /// TransportMovement
    /// </summary>
    [DataContract(Name = "TransportMovement")]
    public partial class TransportMovement : IEquatable<TransportMovement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportMovement" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargocheckActions">CargocheckActions.</param>
        /// <param name="httpsCargocontactDetails">CargocontactDetails.</param>
        /// <param name="httpsCargocontactPersons">CargocontactPersons.</param>
        /// <param name="httpsCargoservedServices">CargoservedServices.</param>
        /// <param name="httpsCargoexecutionStatus">CargoexecutionStatus.</param>
        /// <param name="httpsCargoactions">Cargoactions.</param>
        /// <param name="httpsCargoarrivalLocation">CargoarrivalLocation.</param>
        /// <param name="httpsCargoco2Emissions">Cargoco2Emissions.</param>
        /// <param name="httpsCargodepartureLocation">CargodepartureLocation.</param>
        /// <param name="httpsCargodistanceCalculated">CargodistanceCalculated.</param>
        /// <param name="httpsCargodistanceMeasured">CargodistanceMeasured.</param>
        /// <param name="httpsCargofuelAmountCalculated">CargofuelAmountCalculated.</param>
        /// <param name="httpsCargofuelAmountMeasured">CargofuelAmountMeasured.</param>
        /// <param name="httpsCargomovementTimes">CargomovementTimes.</param>
        /// <param name="httpsCargooperatingTransportMeans">CargooperatingTransportMeans.</param>
        /// <param name="httpsCargofuelType">CargofuelType.</param>
        /// <param name="httpsCargomodeCode">CargomodeCode.</param>
        /// <param name="httpsCargomodeQualifier">CargomodeQualifier.</param>
        /// <param name="httpsCargoseal">Cargoseal.</param>
        /// <param name="httpsCargotransportIdentifier">CargotransportIdentifier.</param>
        public TransportMovement(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<Check> httpsCargocheckActions = default(List<Check>), List<ContactDetail> httpsCargocontactDetails = default(List<ContactDetail>), List<Person> httpsCargocontactPersons = default(List<Person>), List<LogisticsService> httpsCargoservedServices = default(List<LogisticsService>), string httpsCargoexecutionStatus = default(string), List<LogisticsAction> httpsCargoactions = default(List<LogisticsAction>), Location httpsCargoarrivalLocation = default(Location), List<Co2Emissions> httpsCargoco2Emissions = default(List<Co2Emissions>), Location httpsCargodepartureLocation = default(Location), Value httpsCargodistanceCalculated = default(Value), Value httpsCargodistanceMeasured = default(Value), Value httpsCargofuelAmountCalculated = default(Value), Value httpsCargofuelAmountMeasured = default(Value), List<MovementTimes> httpsCargomovementTimes = default(List<MovementTimes>), TransportMeans httpsCargooperatingTransportMeans = default(TransportMeans), string httpsCargofuelType = default(string), string httpsCargomodeCode = default(string), string httpsCargomodeQualifier = default(string), string httpsCargoseal = default(string), string httpsCargotransportIdentifier = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargocheckActions = httpsCargocheckActions;
            this.HttpsCargocontactDetails = httpsCargocontactDetails;
            this.HttpsCargocontactPersons = httpsCargocontactPersons;
            this.HttpsCargoservedServices = httpsCargoservedServices;
            this.HttpsCargoexecutionStatus = httpsCargoexecutionStatus;
            this.HttpsCargoactions = httpsCargoactions;
            this.HttpsCargoarrivalLocation = httpsCargoarrivalLocation;
            this.HttpsCargoco2Emissions = httpsCargoco2Emissions;
            this.HttpsCargodepartureLocation = httpsCargodepartureLocation;
            this.HttpsCargodistanceCalculated = httpsCargodistanceCalculated;
            this.HttpsCargodistanceMeasured = httpsCargodistanceMeasured;
            this.HttpsCargofuelAmountCalculated = httpsCargofuelAmountCalculated;
            this.HttpsCargofuelAmountMeasured = httpsCargofuelAmountMeasured;
            this.HttpsCargomovementTimes = httpsCargomovementTimes;
            this.HttpsCargooperatingTransportMeans = httpsCargooperatingTransportMeans;
            this.HttpsCargofuelType = httpsCargofuelType;
            this.HttpsCargomodeCode = httpsCargomodeCode;
            this.HttpsCargomodeQualifier = httpsCargomodeQualifier;
            this.HttpsCargoseal = httpsCargoseal;
            this.HttpsCargotransportIdentifier = httpsCargotransportIdentifier;
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
        /// Gets or Sets CargocheckActions
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#checkActions", EmitDefaultValue = false)]
        public List<Check> HttpsCargocheckActions { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactDetails
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactDetails", EmitDefaultValue = false)]
        public List<ContactDetail> HttpsCargocontactDetails { get; set; }

        /// <summary>
        /// Gets or Sets CargocontactPersons
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#contactPersons", EmitDefaultValue = false)]
        public List<Person> HttpsCargocontactPersons { get; set; }

        /// <summary>
        /// Gets or Sets CargoservedServices
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#servedServices", EmitDefaultValue = false)]
        public List<LogisticsService> HttpsCargoservedServices { get; set; }

        /// <summary>
        /// Gets or Sets CargoexecutionStatus
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#executionStatus", EmitDefaultValue = false)]
        public string HttpsCargoexecutionStatus { get; set; }

        /// <summary>
        /// Gets or Sets Cargoactions
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#actions", EmitDefaultValue = false)]
        public List<LogisticsAction> HttpsCargoactions { get; set; }

        /// <summary>
        /// Gets or Sets CargoarrivalLocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#arrivalLocation", EmitDefaultValue = false)]
        public Location HttpsCargoarrivalLocation { get; set; }

        /// <summary>
        /// Gets or Sets Cargoco2Emissions
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#co2Emissions", EmitDefaultValue = false)]
        public List<Co2Emissions> HttpsCargoco2Emissions { get; set; }

        /// <summary>
        /// Gets or Sets CargodepartureLocation
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#departureLocation", EmitDefaultValue = false)]
        public Location HttpsCargodepartureLocation { get; set; }

        /// <summary>
        /// Gets or Sets CargodistanceCalculated
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#distanceCalculated", EmitDefaultValue = false)]
        public Value HttpsCargodistanceCalculated { get; set; }

        /// <summary>
        /// Gets or Sets CargodistanceMeasured
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#distanceMeasured", EmitDefaultValue = false)]
        public Value HttpsCargodistanceMeasured { get; set; }

        /// <summary>
        /// Gets or Sets CargofuelAmountCalculated
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#fuelAmountCalculated", EmitDefaultValue = false)]
        public Value HttpsCargofuelAmountCalculated { get; set; }

        /// <summary>
        /// Gets or Sets CargofuelAmountMeasured
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#fuelAmountMeasured", EmitDefaultValue = false)]
        public Value HttpsCargofuelAmountMeasured { get; set; }

        /// <summary>
        /// Gets or Sets CargomovementTimes
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#movementTimes", EmitDefaultValue = false)]
        public List<MovementTimes> HttpsCargomovementTimes { get; set; }

        /// <summary>
        /// Gets or Sets CargooperatingTransportMeans
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#operatingTransportMeans", EmitDefaultValue = false)]
        public TransportMeans HttpsCargooperatingTransportMeans { get; set; }

        /// <summary>
        /// Gets or Sets CargofuelType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#fuelType", EmitDefaultValue = false)]
        public string HttpsCargofuelType { get; set; }

        /// <summary>
        /// Gets or Sets CargomodeCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#modeCode", EmitDefaultValue = false)]
        public string HttpsCargomodeCode { get; set; }

        /// <summary>
        /// Gets or Sets CargomodeQualifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#modeQualifier", EmitDefaultValue = false)]
        public string HttpsCargomodeQualifier { get; set; }

        /// <summary>
        /// Gets or Sets Cargoseal
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#seal", EmitDefaultValue = false)]
        public string HttpsCargoseal { get; set; }

        /// <summary>
        /// Gets or Sets CargotransportIdentifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#transportIdentifier", EmitDefaultValue = false)]
        public string HttpsCargotransportIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportMovement {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargocheckActions: ").Append(HttpsCargocheckActions).Append("\n");
            sb.Append("  CargocontactDetails: ").Append(HttpsCargocontactDetails).Append("\n");
            sb.Append("  CargocontactPersons: ").Append(HttpsCargocontactPersons).Append("\n");
            sb.Append("  CargoservedServices: ").Append(HttpsCargoservedServices).Append("\n");
            sb.Append("  CargoexecutionStatus: ").Append(HttpsCargoexecutionStatus).Append("\n");
            sb.Append("  Cargoactions: ").Append(HttpsCargoactions).Append("\n");
            sb.Append("  CargoarrivalLocation: ").Append(HttpsCargoarrivalLocation).Append("\n");
            sb.Append("  Cargoco2Emissions: ").Append(HttpsCargoco2Emissions).Append("\n");
            sb.Append("  CargodepartureLocation: ").Append(HttpsCargodepartureLocation).Append("\n");
            sb.Append("  CargodistanceCalculated: ").Append(HttpsCargodistanceCalculated).Append("\n");
            sb.Append("  CargodistanceMeasured: ").Append(HttpsCargodistanceMeasured).Append("\n");
            sb.Append("  CargofuelAmountCalculated: ").Append(HttpsCargofuelAmountCalculated).Append("\n");
            sb.Append("  CargofuelAmountMeasured: ").Append(HttpsCargofuelAmountMeasured).Append("\n");
            sb.Append("  CargomovementTimes: ").Append(HttpsCargomovementTimes).Append("\n");
            sb.Append("  CargooperatingTransportMeans: ").Append(HttpsCargooperatingTransportMeans).Append("\n");
            sb.Append("  CargofuelType: ").Append(HttpsCargofuelType).Append("\n");
            sb.Append("  CargomodeCode: ").Append(HttpsCargomodeCode).Append("\n");
            sb.Append("  CargomodeQualifier: ").Append(HttpsCargomodeQualifier).Append("\n");
            sb.Append("  Cargoseal: ").Append(HttpsCargoseal).Append("\n");
            sb.Append("  CargotransportIdentifier: ").Append(HttpsCargotransportIdentifier).Append("\n");
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
            return this.Equals(httpsInput as TransportMovement);
        }

        /// <summary>
        /// Returns true if TransportMovement instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of TransportMovement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportMovement httpsInput)
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
                    this.HttpsCargocheckActions == httpsInput.HttpsCargocheckActions ||
                    this.HttpsCargocheckActions != null &&
                    httpsInput.HttpsCargocheckActions != null &&
                    this.HttpsCargocheckActions.SequenceEqual(httpsInput.HttpsCargocheckActions)
                ) && 
                (
                    this.HttpsCargocontactDetails == httpsInput.HttpsCargocontactDetails ||
                    this.HttpsCargocontactDetails != null &&
                    httpsInput.HttpsCargocontactDetails != null &&
                    this.HttpsCargocontactDetails.SequenceEqual(httpsInput.HttpsCargocontactDetails)
                ) && 
                (
                    this.HttpsCargocontactPersons == httpsInput.HttpsCargocontactPersons ||
                    this.HttpsCargocontactPersons != null &&
                    httpsInput.HttpsCargocontactPersons != null &&
                    this.HttpsCargocontactPersons.SequenceEqual(httpsInput.HttpsCargocontactPersons)
                ) && 
                (
                    this.HttpsCargoservedServices == httpsInput.HttpsCargoservedServices ||
                    this.HttpsCargoservedServices != null &&
                    httpsInput.HttpsCargoservedServices != null &&
                    this.HttpsCargoservedServices.SequenceEqual(httpsInput.HttpsCargoservedServices)
                ) && 
                (
                    this.HttpsCargoexecutionStatus == httpsInput.HttpsCargoexecutionStatus ||
                    (this.HttpsCargoexecutionStatus != null &&
                    this.HttpsCargoexecutionStatus.Equals(httpsInput.HttpsCargoexecutionStatus))
                ) && 
                (
                    this.HttpsCargoactions == httpsInput.HttpsCargoactions ||
                    this.HttpsCargoactions != null &&
                    httpsInput.HttpsCargoactions != null &&
                    this.HttpsCargoactions.SequenceEqual(httpsInput.HttpsCargoactions)
                ) && 
                (
                    this.HttpsCargoarrivalLocation == httpsInput.HttpsCargoarrivalLocation ||
                    (this.HttpsCargoarrivalLocation != null &&
                    this.HttpsCargoarrivalLocation.Equals(httpsInput.HttpsCargoarrivalLocation))
                ) && 
                (
                    this.HttpsCargoco2Emissions == httpsInput.HttpsCargoco2Emissions ||
                    this.HttpsCargoco2Emissions != null &&
                    httpsInput.HttpsCargoco2Emissions != null &&
                    this.HttpsCargoco2Emissions.SequenceEqual(httpsInput.HttpsCargoco2Emissions)
                ) && 
                (
                    this.HttpsCargodepartureLocation == httpsInput.HttpsCargodepartureLocation ||
                    (this.HttpsCargodepartureLocation != null &&
                    this.HttpsCargodepartureLocation.Equals(httpsInput.HttpsCargodepartureLocation))
                ) && 
                (
                    this.HttpsCargodistanceCalculated == httpsInput.HttpsCargodistanceCalculated ||
                    (this.HttpsCargodistanceCalculated != null &&
                    this.HttpsCargodistanceCalculated.Equals(httpsInput.HttpsCargodistanceCalculated))
                ) && 
                (
                    this.HttpsCargodistanceMeasured == httpsInput.HttpsCargodistanceMeasured ||
                    (this.HttpsCargodistanceMeasured != null &&
                    this.HttpsCargodistanceMeasured.Equals(httpsInput.HttpsCargodistanceMeasured))
                ) && 
                (
                    this.HttpsCargofuelAmountCalculated == httpsInput.HttpsCargofuelAmountCalculated ||
                    (this.HttpsCargofuelAmountCalculated != null &&
                    this.HttpsCargofuelAmountCalculated.Equals(httpsInput.HttpsCargofuelAmountCalculated))
                ) && 
                (
                    this.HttpsCargofuelAmountMeasured == httpsInput.HttpsCargofuelAmountMeasured ||
                    (this.HttpsCargofuelAmountMeasured != null &&
                    this.HttpsCargofuelAmountMeasured.Equals(httpsInput.HttpsCargofuelAmountMeasured))
                ) && 
                (
                    this.HttpsCargomovementTimes == httpsInput.HttpsCargomovementTimes ||
                    this.HttpsCargomovementTimes != null &&
                    httpsInput.HttpsCargomovementTimes != null &&
                    this.HttpsCargomovementTimes.SequenceEqual(httpsInput.HttpsCargomovementTimes)
                ) && 
                (
                    this.HttpsCargooperatingTransportMeans == httpsInput.HttpsCargooperatingTransportMeans ||
                    (this.HttpsCargooperatingTransportMeans != null &&
                    this.HttpsCargooperatingTransportMeans.Equals(httpsInput.HttpsCargooperatingTransportMeans))
                ) && 
                (
                    this.HttpsCargofuelType == httpsInput.HttpsCargofuelType ||
                    (this.HttpsCargofuelType != null &&
                    this.HttpsCargofuelType.Equals(httpsInput.HttpsCargofuelType))
                ) && 
                (
                    this.HttpsCargomodeCode == httpsInput.HttpsCargomodeCode ||
                    (this.HttpsCargomodeCode != null &&
                    this.HttpsCargomodeCode.Equals(httpsInput.HttpsCargomodeCode))
                ) && 
                (
                    this.HttpsCargomodeQualifier == httpsInput.HttpsCargomodeQualifier ||
                    (this.HttpsCargomodeQualifier != null &&
                    this.HttpsCargomodeQualifier.Equals(httpsInput.HttpsCargomodeQualifier))
                ) && 
                (
                    this.HttpsCargoseal == httpsInput.HttpsCargoseal ||
                    (this.HttpsCargoseal != null &&
                    this.HttpsCargoseal.Equals(httpsInput.HttpsCargoseal))
                ) && 
                (
                    this.HttpsCargotransportIdentifier == httpsInput.HttpsCargotransportIdentifier ||
                    (this.HttpsCargotransportIdentifier != null &&
                    this.HttpsCargotransportIdentifier.Equals(httpsInput.HttpsCargotransportIdentifier))
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
                if (this.HttpsCargocheckActions != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocheckActions.GetHashCode();
                }
                if (this.HttpsCargocontactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactDetails.GetHashCode();
                }
                if (this.HttpsCargocontactPersons != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocontactPersons.GetHashCode();
                }
                if (this.HttpsCargoservedServices != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoservedServices.GetHashCode();
                }
                if (this.HttpsCargoexecutionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoexecutionStatus.GetHashCode();
                }
                if (this.HttpsCargoactions != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoactions.GetHashCode();
                }
                if (this.HttpsCargoarrivalLocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoarrivalLocation.GetHashCode();
                }
                if (this.HttpsCargoco2Emissions != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoco2Emissions.GetHashCode();
                }
                if (this.HttpsCargodepartureLocation != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodepartureLocation.GetHashCode();
                }
                if (this.HttpsCargodistanceCalculated != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodistanceCalculated.GetHashCode();
                }
                if (this.HttpsCargodistanceMeasured != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodistanceMeasured.GetHashCode();
                }
                if (this.HttpsCargofuelAmountCalculated != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargofuelAmountCalculated.GetHashCode();
                }
                if (this.HttpsCargofuelAmountMeasured != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargofuelAmountMeasured.GetHashCode();
                }
                if (this.HttpsCargomovementTimes != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomovementTimes.GetHashCode();
                }
                if (this.HttpsCargooperatingTransportMeans != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargooperatingTransportMeans.GetHashCode();
                }
                if (this.HttpsCargofuelType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargofuelType.GetHashCode();
                }
                if (this.HttpsCargomodeCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomodeCode.GetHashCode();
                }
                if (this.HttpsCargomodeQualifier != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomodeQualifier.GetHashCode();
                }
                if (this.HttpsCargoseal != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoseal.GetHashCode();
                }
                if (this.HttpsCargotransportIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargotransportIdentifier.GetHashCode();
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
