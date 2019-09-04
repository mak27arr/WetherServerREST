using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WetherServer.Database.Interfaces
{
    public interface ISensorMeasurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long SensorMeasurementID{get;set;}
        IStation StationID { get; set; }
        iSensorType SensorTypeID { get; set; }
        DateTime MeasurementTime { get; set; }
        Double value { get; set; }
    }
}
