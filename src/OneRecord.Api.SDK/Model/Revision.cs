using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Revision")]
public class Revision
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "@value", EmitDefaultValue = false)]
    public int Value { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "@type", EmitDefaultValue = false)]
    public string Type { get; set; }
}