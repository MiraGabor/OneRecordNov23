using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OneRecord.Api.SDK.Model
{
    [DataContract(Name = "ULD")]
    public class ULD : LoadingUnit
    {
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "@context", EmitDefaultValue = true)]
        public Context Context = new Context
        {
            Cargo = "https://onerecord.iata.org/ns/cargo#"
        };

        [DataMember(Name = "cargo:uldSerialNumber", EmitDefaultValue = false)]
        public string UldSerialNumber { get; set; }
    }
}
