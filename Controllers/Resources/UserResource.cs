using System;
using System.ComponentModel.DataAnnotations;
using BladeRunnerApp.Models;

namespace BladeRunnerApp.Controllers.Resources
{
    public class UserResource
    {
        public int UserId { get; set; }
        public ContactResource Contact { get; set; }
        [StringLength(50)]
        public string StatusTitle { get; set; }
        public string Password { get; set; }
        public string ProfileImageUrl { get; set; }
        public int UserRoleId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

//   public int UserRoleId { get; set; }
    //  public DateTime SessionTime { get; set; }
    //     public DateTime CreatedAt { get; set; }
    //     public DateTime LastVisit { get; set; }
}