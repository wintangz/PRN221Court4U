﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Court4U_PRN.Data.Entity
{
    [Table("UserRole")]
    public class UserRole
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Role")]
        public string RoleId { get; set; }
        public Role Role { get; set; }
    }
}
