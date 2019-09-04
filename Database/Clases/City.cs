using System.ComponentModel.DataAnnotations;
using WetherServer.Database.Interfaces;

namespace WetherServer.Database.Clases
{
    public class City : ICity
    {
        [Key]
        public uint CityID { get; set; }
        public string CityName { get; set; }
    }
}
