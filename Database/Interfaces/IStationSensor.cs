using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WetherServer.Database.Interfaces
{
    interface IStationSensor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        IStation StationID { get; set; }
        iSensorType SensorTypeID { get; set; }
        string Model { get; set; }
    }
}
