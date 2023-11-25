using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Repository.Model;
public class CorrespondenceULDShipmentModel
{
    [Key]
    public int Id {  get; set; }
    public string UldID { get; set; }
    public string ShipmentId { get; set; }
    public string NeoneGuid { get; set; }
}
