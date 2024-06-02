﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Court4U_PRN.Data.Entity
{
    [Table("Reviews")]
    public class Review
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Content {  get; set; }
        public int ParentId { get; set; }
        public string CommentLeft { get; set; }
        public string CommentRight { get; set; }

        [ForeignKey("Clubs")]
        public string ClubId { get; set; }
        public Club Club { get; set; }

        [ForeignKey("Users")]
        public string ReviewerId { get; set; }
        public User Reviewer { get; set; }
    }
}
