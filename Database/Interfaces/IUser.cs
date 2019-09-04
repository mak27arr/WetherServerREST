using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WetherServer.Database.Interfaces
{
    public interface IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        uint UserID { get; set; }
        string PasswordHash { get; set; }
        DateTime RegisterDate { get; set; }
    }
}
