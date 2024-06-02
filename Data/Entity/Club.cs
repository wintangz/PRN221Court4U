﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Court4U_PRN.Data.Entity
{
    [Table("Clubs")]
    public class Club
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address {  get; set; }
        public string CityOfProvince { get; set; }
        public string District { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<ClubRole> ClubRoles { get; set; }
        public ICollection<StaffProfile> StaffProfiles { get; set; }
        public ICollection<Pricing> Pricings { get; set; }
        public ICollection<ClubImage> ClubImages { get; set; }
        public ICollection<SubscriptionOption> SubscriptionOptions { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Court> Courts { get; set; }
        public ICollection<Slot> Slots { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
