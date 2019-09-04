using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WetherServer.Database.Interfaces;

namespace WetherServer.Database.Clases
{
    public class Station : IStation
    {
        public ulong StationID { get; set; }
        public IUser UserID { get; set; }
        public double Altitude { get; set; }
        public double Latitude { get; set; }
        public double Height { get; set; }
        public ICity CityID { get; set; }
        public string AuthorizationKey { get; set; }
        public short FirmwareVersion { get; set; }
        public short HardwareVersion { get; set; }
    }
}
