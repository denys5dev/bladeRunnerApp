using System;
using System.ComponentModel.DataAnnotations;

namespace BladeRunnerApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string StatusTitle { get; set; }
        public DateTime SessionTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastVisit { get; set; }
        public string Password { get; set; }
        public string ProfileImageUrl { get; set; }
        public UserRole UserRole { get; set; }
        public int UserRoleId { get; set; }
    }
}