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
    /// Characteristic
    /// </summary>
    [DataContract(Name = "Characteristic")]
    public partial class Characteristic : IEquatable<Characteristic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Characteristic" /> class.
        /// </summary>
        /// <param name="httpsId">id.</param>
        /// <param name="httpsType">type.</param>
        /// <param name="httpsCargoofProduct">CargoofProduct.</param>
        /// <param name="httpsCargocharacteristicType">CargocharacteristicType.</param>
        /// <param name="httpsCargotextualValue">CargotextualValue.</param>
        public Characteristic(string httpsId = default(string), List<string> httpsType = default(List<string>), Product httpsCargoofProduct = default(Product), string httpsCargocharacteristicType = default(string), string httpsCargotextualValue = default(string))
        {
            this.HttpsId = httpsId;
            this.HttpsType = httpsType;
            this.HttpsCargoofProduct = httpsCargoofProduct;
            this.HttpsCargocharacteristicType = httpsCargocharacteristicType;
            this.HttpsCargotextualValue = httpsCargotextualValue;
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
        /// Gets or Sets CargoofProduct
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#ofProduct", EmitDefaultValue = false)]
        public Product HttpsCargoofProduct { get; set; }

        /// <summary>
        /// Gets or Sets CargocharacteristicType
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#characteristicType", EmitDefaultValue = false)]
        public string HttpsCargocharacteristicType { get; set; }

        /// <summary>
        /// Gets or Sets CargotextualValue
        /// </summary>
        [DataMember(Name = "https://onerecord.iata.org/ns/cargo#textualValue", EmitDefaultValue = false)]
        public string HttpsCargotextualValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Characteristic {\n");
            sb.Append("  Id: ").Append(HttpsId).Append("\n");
            sb.Append("  Type: ").Append(HttpsType).Append("\n");
            sb.Append("  CargoofProduct: ").Append(HttpsCargoofProduct).Append("\n");
            sb.Append("  CargocharacteristicType: ").Append(HttpsCargocharacteristicType).Append("\n");
            sb.Append("  CargotextualValue: ").Append(HttpsCargotextualValue).Append("\n");
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
            return this.Equals(httpsInput as Characteristic);
        }

        /// <summary>
        /// Returns true if Characteristic instances are equal
        /// </summary>
        /// <param name="httpsInput">Instance of Characteristic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Characteristic httpsInput)
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
                    this.HttpsCargoofProduct == httpsInput.HttpsCargoofProduct ||
                    (this.HttpsCargoofProduct != null &&
                    this.HttpsCargoofProduct.Equals(httpsInput.HttpsCargoofProduct))
                ) && 
                (
                    this.HttpsCargocharacteristicType == httpsInput.HttpsCargocharacteristicType ||
                    (this.HttpsCargocharacteristicType != null &&
                    this.HttpsCargocharacteristicType.Equals(httpsInput.HttpsCargocharacteristicType))
                ) && 
                (
                    this.HttpsCargotextualValue == httpsInput.HttpsCargotextualValue ||
                    (this.HttpsCargotextualValue != null &&
                    this.HttpsCargotextualValue.Equals(httpsInput.HttpsCargotextualValue))
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
                if (this.HttpsCargoofProduct != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargoofProduct.GetHashCode();
                }
                if (this.HttpsCargocharacteristicType != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargocharacteristicType.GetHashCode();
                }
                if (this.HttpsCargotextualValue != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsCargotextualValue.GetHashCode();
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
