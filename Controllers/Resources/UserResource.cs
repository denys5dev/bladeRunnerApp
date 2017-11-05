using System;   
using BladeRunnerApp.Models;

namespace BladeRunnerApp.Controllers.Resources
{
    public class UserResource
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StatusTitle { get; set; }
        public DateTime SessionTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastVisit { get; set; }
        public string Password { get; set; }
        public string ProfileImageUrl { get; set; }
        public int UserRoleId { get; set; }
    }
}