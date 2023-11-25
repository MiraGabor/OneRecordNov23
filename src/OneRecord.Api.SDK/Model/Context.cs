using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

/// <summary>
/// 
/// </summary>
public class Context
{
    /// <summary>
    /// 
    /// </summary>
    [DataMember(Name = "cargo")]
    public string Cargo { get; set; }

    [DataMember(Name = "api")]
    public string Api { get; set; }
}