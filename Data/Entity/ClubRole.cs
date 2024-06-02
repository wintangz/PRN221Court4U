﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Court4U_PRN.Data.Entity
{
    [Table("ClubRole")]
    public class ClubRole
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string RoleName { get; set; }
        public ICollection<StaffRole> StaffRoles { get; set; }

        [ForeignKey("Clubs")]
        public string ClubId { get; set; }
        public Club Club { get; set; }

        [ForeignKey("Permission")]
        public string PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
