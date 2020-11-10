using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        [StringLength(20, MinimumLength = 6)]
        public string Name { get; set; }

        [Required, MaxLength(200)]
        [StringLength(16, MinimumLength = 8)]
        public string Password { get; set; }

        [Required, MaxLength(200), EmailAddress]
        public string Email { get; set; }

        [MaxLength(200)]
        public string RememberToken { get; set; }

        [Required, MaxLength(50)]
        [StringLength(50, MinimumLength = 1)]
        public string Firstname { get; set; }

        [Required, MaxLength(50)]
        [StringLength(50, MinimumLength = 1)]
        public string Lastname { get; set; }
        
        public DateTime LastLogin { get; set; }
    }
}