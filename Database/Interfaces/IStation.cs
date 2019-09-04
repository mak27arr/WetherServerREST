using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WetherServer.Database.Interfaces
{
    public interface IStation
    {
        ulong StationID { get; set; }
        [Required]
        IUser UserID { get; set; }
        double Altitude { get; set; }
        double Latitude { get; set; }
        double Height { get; set; }
        ICity CityID { get; set; }
        string AuthorizationKey { get; set; }
        short FirmwareVersion { get; set; }
        short HardwareVersion { get; set; }
    }
}
