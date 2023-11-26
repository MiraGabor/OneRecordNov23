using System.ComponentModel.DataAnnotations;

namespace OneCheck.Repository.Model;
public class CorrespondenceULDShipmentModel
{
    [Key]
    public int Id {  get; set; }
    public string UldID { get; set; }
    public string ShipmentId { get; set; }
    public string NeoneGuid { get; set; }
}
