using System.ComponentModel.DataAnnotations;

namespace BladeRunnerApp.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserRoleName { get; set; }
        [Required]
        public byte UserRoleType { get; set; }
    }
}