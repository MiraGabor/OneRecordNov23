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
    /// Product
    /// </summary>
    [DataContract(Name = "Product")]
    public partial class Product : IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargochecks">Cargochecks.</param>
        /// <param name="httpsCargoevents">Cargoevents.</param>
        /// <param name="httpsCargoexternalReferences">CargoexternalReferences.</param>
        /// <param name="httpsCargocompanyIdentifier">CargocompanyIdentifier.</param>
        /// <param name="httpsCargoskeletonIndicator">CargoskeletonIndicator.</param>
        /// <param name="httpsCargodescriptionForContentOfPieces">CargodescriptionForContentOfPieces.</param>
        /// <param name="httpsCargodescriptionForItems">CargodescriptionForItems.</param>
        /// <param name="httpsCargomanufacturer">Cargomanufacturer.</param>
        /// <param name="httpsCargootherCharacteristics">CargootherCharacteristics.</param>
        /// <param name="httpsCargootherIdentifiers">CargootherIdentifiers.</param>
        /// <param name="httpsCargocommodityItemNumber">CargocommodityItemNumber.</param>
        /// <param name="httpsCargodescription">Cargodescription.</param>
        /// <param name="httpsCargohsCode">CargohsCode.</param>
        /// <param name="httpsCargohsCommodityDescription">CargohsCommodityDescription.</param>
        /// <param name="httpsCargohsCommodityName">CargohsCommodityName.</param>
        /// <param name="httpsCargohsType">CargohsType.</param>
        /// <param name="httpsCargouniqueIdentifier">CargouniqueIdentifier.</param>
        public Product(string httpsId = default(string), List<string> httpsType = default(List<string>), List<Check> httpsCargochecks = default(List<Check>), List<LogisticsEvent> httpsCargoevents = default(List<LogisticsEvent>), List<ExternalReference> httpsCargoexternalReferences = default(List<ExternalReference>), string httpsCargocompanyIdentifier = default(string), bool httpsCargoskeletonIndicator = default(bool), List<Piece> httpsCargodescriptionForContentOfPieces = default(List<Piece>), List<Item> httpsCargodescriptionForItems = default(List<Item>), Company httpsCargomanufacturer = default(Company), List<Characteristic> httpsCargootherCharacteristics = default(List<Characteristic>), List<OtherIdentifier> httpsCargootherIdentifiers = default(List<OtherIdentifier>), string httpsCargocommodityItemNumber = default(string), string httpsCargodescription = default(string), string httpsCargohsCode = default(string), string httpsCargohsCommodityDescription = default(string), string httpsCargohsCommodityName = default(string), string httpsCargohsType = default(string), string httpsCargouniqueIdentifier = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargochecks = httpsCargochecks;
            this.HttpsCargoevents = httpsCargoevents;
            this.HttpsCargoexternalReferences = httpsCargoexternalReferences;
            this.HttpsCargocompanyIdentifier = httpsCargocompanyIdentifier;
            this.HttpsCargoskeletonIndicator = httpsCargoskeletonIndicator;
            this.HttpsCargodescriptionForContentOfPieces = httpsCargodescriptionForContentOfPieces;
            this.HttpsCargodescriptionForItems = httpsCargodescriptionForItems;
            this.HttpsCargomanufacturer = httpsCargomanufacturer;
            this.HttpsCargootherCharacteristics = httpsCargootherCharacteristics;
            this.HttpsCargootherIdentifiers = httpsCargootherIdentifiers;
            this.HttpsCargocommodityItemNumber = httpsCargocommodityItemNumber;
            this.HttpsCargodescription = httpsCargodescription;
            this.HttpsCargohsCode = httpsCargohsCode;
            this.HttpsCargohsCommodityDescription = httpsCargohsCommodityDescription;
            this.HttpsCargohsCommodityName = httpsCargohsCommodityName;
            this.HttpsCargohsType = httpsCargohsType;
            this.HttpsCargouniqueIdentifier = httpsCargouniqueIdentifier;
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
        /// Gets or Sets CargodescriptionForContentOfPieces
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#descriptionForContentOfPieces", EmitDefaultValue = false)]
        public List<Piece> HttpsCargodescriptionForContentOfPieces { get; set; }

        /// <summary>
        /// Gets or Sets CargodescriptionForItems
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#descriptionForItems", EmitDefaultValue = false)]
        public List<Item> HttpsCargodescriptionForItems { get; set; }

        /// <summary>
        /// Gets or Sets Cargomanufacturer
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#manufacturer", EmitDefaultValue = false)]
        public Company HttpsCargomanufacturer { get; set; }

        /// <summary>
        /// Gets or Sets CargootherCharacteristics
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#otherCharacteristics", EmitDefaultValue = false)]
        public List<Characteristic> HttpsCargootherCharacteristics { get; set; }

        /// <summary>
        /// Gets or Sets CargootherIdentifiers
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#otherIdentifiers", EmitDefaultValue = false)]
        public List<OtherIdentifier> HttpsCargootherIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets CargocommodityItemNumber
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#commodityItemNumber", EmitDefaultValue = false)]
        public string HttpsCargocommodityItemNumber { get; set; }

        /// <summary>
        /// Gets or Sets Cargodescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#description", EmitDefaultValue = false)]
        public string HttpsCargodescription { get; set; }

        /// <summary>
        /// Gets or Sets CargohsCode
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#hsCode", EmitDefaultValue = false)]
        public string HttpsCargohsCode { get; set; }

        /// <summary>
        /// Gets or Sets CargohsCommodityDescription
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#hsCommodityDescription", EmitDefaultValue = false)]
        public string HttpsCargohsCommodityDescription { get; set; }

        /// <summary>
        /// Gets or Sets CargohsCommodityName
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#hsCommodityName", EmitDefaultValue = false)]
        public string HttpsCargohsCommodityName { get; set; }

        /// <summary>
        /// Gets or Sets CargohsType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#hsType", EmitDefaultValue = false)]
        public string HttpsCargohsType { get; set; }

        /// <summary>
        /// Gets or Sets CargouniqueIdentifier
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#uniqueIdentifier", EmitDefaultValue = false)]
        public string HttpsCargouniqueIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  Cargochecks: ").Append(HttpsCargochecks).Append("\n");
            sb.Append("  Cargoevents: ").Append(HttpsCargoevents).Append("\n");
            sb.Append("  CargoexternalReferences: ").Append(HttpsCargoexternalReferences).Append("\n");
            sb.Append("  CargocompanyIdentifier: ").Append(HttpsCargocompanyIdentifier).Append("\n");
            sb.Append("  CargoskeletonIndicator: ").Append(HttpsCargoskeletonIndicator).Append("\n");
            sb.Append("  CargodescriptionForContentOfPieces: ").Append(HttpsCargodescriptionForContentOfPieces).Append("\n");
            sb.Append("  CargodescriptionForItems: ").Append(HttpsCargodescriptionForItems).Append("\n");
            sb.Append("  Cargomanufacturer: ").Append(HttpsCargomanufacturer).Append("\n");
            sb.Append("  CargootherCharacteristics: ").Append(HttpsCargootherCharacteristics).Append("\n");
            sb.Append("  CargootherIdentifiers: ").Append(HttpsCargootherIdentifiers).Append("\n");
            sb.Append("  CargocommodityItemNumber: ").Append(HttpsCargocommodityItemNumber).Append("\n");
            sb.Append("  Cargodescription: ").Append(HttpsCargodescription).Append("\n");
            sb.Append("  CargohsCode: ").Append(HttpsCargohsCode).Append("\n");
            sb.Append("  CargohsCommodityDescription: ").Append(HttpsCargohsCommodityDescription).Append("\n");
            sb.Append("  CargohsCommodityName: ").Append(HttpsCargohsCommodityName).Append("\n");
            sb.Append("  CargohsType: ").Append(HttpsCargohsType).Append("\n");
            sb.Append("  CargouniqueIdentifier: ").Append(HttpsCargouniqueIdentifier).Append("\n");
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
            return this.Equals(httpsInput as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product httpsInput)
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
                    this.HttpsCargodescriptionForContentOfPieces == httpsInput.HttpsCargodescriptionForContentOfPieces ||
                    this.HttpsCargodescriptionForContentOfPieces != null &&
                    httpsInput.HttpsCargodescriptionForContentOfPieces != null &&
                    this.HttpsCargodescriptionForContentOfPieces.SequenceEqual(httpsInput.HttpsCargodescriptionForContentOfPieces)
                ) && 
                (
                    this.HttpsCargodescriptionForItems == httpsInput.HttpsCargodescriptionForItems ||
                    this.HttpsCargodescriptionForItems != null &&
                    httpsInput.HttpsCargodescriptionForItems != null &&
                    this.HttpsCargodescriptionForItems.SequenceEqual(httpsInput.HttpsCargodescriptionForItems)
                ) && 
                (
                    this.HttpsCargomanufacturer == httpsInput.HttpsCargomanufacturer ||
                    (this.HttpsCargomanufacturer != null &&
                    this.HttpsCargomanufacturer.Equals(httpsInput.HttpsCargomanufacturer))
                ) && 
                (
                    this.HttpsCargootherCharacteristics == httpsInput.HttpsCargootherCharacteristics ||
                    this.HttpsCargootherCharacteristics != null &&
                    httpsInput.HttpsCargootherCharacteristics != null &&
                    this.HttpsCargootherCharacteristics.SequenceEqual(httpsInput.HttpsCargootherCharacteristics)
                ) && 
                (
                    this.HttpsCargootherIdentifiers == httpsInput.HttpsCargootherIdentifiers ||
                    this.HttpsCargootherIdentifiers != null &&
                    httpsInput.HttpsCargootherIdentifiers != null &&
                    this.HttpsCargootherIdentifiers.SequenceEqual(httpsInput.HttpsCargootherIdentifiers)
                ) && 
                (
                    this.HttpsCargocommodityItemNumber == httpsInput.HttpsCargocommodityItemNumber ||
                    (this.HttpsCargocommodityItemNumber != null &&
                    this.HttpsCargocommodityItemNumber.Equals(httpsInput.HttpsCargocommodityItemNumber))
                ) && 
                (
                    this.HttpsCargodescription == httpsInput.HttpsCargodescription ||
                    (this.HttpsCargodescription != null &&
                    this.HttpsCargodescription.Equals(httpsInput.HttpsCargodescription))
                ) && 
                (
                    this.HttpsCargohsCode == httpsInput.HttpsCargohsCode ||
                    (this.HttpsCargohsCode != null &&
                    this.HttpsCargohsCode.Equals(httpsInput.HttpsCargohsCode))
                ) && 
                (
                    this.HttpsCargohsCommodityDescription == httpsInput.HttpsCargohsCommodityDescription ||
                    (this.HttpsCargohsCommodityDescription != null &&
                    this.HttpsCargohsCommodityDescription.Equals(httpsInput.HttpsCargohsCommodityDescription))
                ) && 
                (
                    this.HttpsCargohsCommodityName == httpsInput.HttpsCargohsCommodityName ||
                    (this.HttpsCargohsCommodityName != null &&
                    this.HttpsCargohsCommodityName.Equals(httpsInput.HttpsCargohsCommodityName))
                ) && 
                (
                    this.HttpsCargohsType == httpsInput.HttpsCargohsType ||
                    (this.HttpsCargohsType != null &&
                    this.HttpsCargohsType.Equals(httpsInput.HttpsCargohsType))
                ) && 
                (
                    this.HttpsCargouniqueIdentifier == httpsInput.HttpsCargouniqueIdentifier ||
                    (this.HttpsCargouniqueIdentifier != null &&
                    this.HttpsCargouniqueIdentifier.Equals(httpsInput.HttpsCargouniqueIdentifier))
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
                if (this.HttpsCargodescriptionForContentOfPieces != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodescriptionForContentOfPieces.GetHashCode();
                }
                if (this.HttpsCargodescriptionForItems != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodescriptionForItems.GetHashCode();
                }
                if (this.HttpsCargomanufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargomanufacturer.GetHashCode();
                }
                if (this.HttpsCargootherCharacteristics != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargootherCharacteristics.GetHashCode();
                }
                if (this.HttpsCargootherIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargootherIdentifiers.GetHashCode();
                }
                if (this.HttpsCargocommodityItemNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocommodityItemNumber.GetHashCode();
                }
                if (this.HttpsCargodescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargodescription.GetHashCode();
                }
                if (this.HttpsCargohsCode != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargohsCode.GetHashCode();
                }
                if (this.HttpsCargohsCommodityDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargohsCommodityDescription.GetHashCode();
                }
                if (this.HttpsCargohsCommodityName != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargohsCommodityName.GetHashCode();
                }
                if (this.HttpsCargohsType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargohsType.GetHashCode();
                }
                if (this.HttpsCargouniqueIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargouniqueIdentifier.GetHashCode();
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
