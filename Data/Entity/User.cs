﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Court4U_PRN.Data.Entity
{
    [Table("Users")]
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public string? AvatarUrl { get; set; }
        public Enums.Status Status { get; set; }
        public StaffProfile StaffProfile { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<StaffRole> StaffRoles { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<MemberSubscription> MemberSubscriptions { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Cancellation> Cancellations { get; set; }
    }
}
