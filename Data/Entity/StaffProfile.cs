﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Court4U_PRN.Data.Entity
{
    [Table("StaffProfile")]
    public class StaffProfile
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public User User { get; set; }

        [ForeignKey("Club")]
        public string ClubId { get; set; }
        public Club Club { get; set; }

    }
}
