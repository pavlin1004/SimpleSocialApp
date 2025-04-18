﻿using Microsoft.AspNetCore.Identity;
using SimpleSocialApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleSocialApp.Data.Models
{
    public class AppUser : IdentityUser
    {
    #pragma warning disable CS8618
        public AppUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Friendships = new HashSet<Friendship>();
            this.Chats = new HashSet<Chat>();
            this.Posts = new HashSet<Post>();
        }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(40, ErrorMessage = "Last Name can't be longer than 40 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(40, ErrorMessage = "Last Name can't be longer than 40 characters")]
        public string LastName { get; set; }
        public GenderType Gender { get; set; }

        public string? MediaId { get; set; } // profile pic
        public virtual Media? Media { get; set; }
        public virtual ICollection<Friendship> Friendships { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
