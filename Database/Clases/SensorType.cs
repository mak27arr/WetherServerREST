using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WetherServer.Database.Interfaces;

namespace WetherServer.Database.Clases
{
    public class SensorType : iSensorType
    {
        public int SensorTipeID { get; set; }
        public string SensorName { get; set; }
    }
}
