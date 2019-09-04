using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WetherServer.Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace WetherServer.Database.Clases
{
    public class User : IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint UserID { get; set; }
        public string PasswordHash { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
