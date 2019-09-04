using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WetherServer.Database.Interfaces
{
    public interface iSensorType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int SensorTipeID { get; set; }
        string SensorName { get; set; }
    }
}
