using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WetherServer.Database.Interfaces;

namespace WetherServer.Database.Clases
{
    public class SensorMeasurement : ISensorMeasurement
    {
        public long SensorMeasurementID { get; set; }
        public IStation StationID { get; set; }
        public iSensorType SensorTypeID { get; set; }
        public DateTime MeasurementTime { get; set; }
        public double value { get; set; }
    }
}
