using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WetherServer.Database.Interfaces
{
    public interface ICity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        uint CityID { get; set; }
        string CityName { get; set; }
    }
}
