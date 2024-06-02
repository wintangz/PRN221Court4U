﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Court4U_PRN.Data.Entity
{
    [Table("StaffRole")]
    public class StaffRole
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("ClubRole")]
        public string ClubRoleId { get; set; }
        public ClubRole ClubRole { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
