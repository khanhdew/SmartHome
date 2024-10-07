using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            ActionHistories = new HashSet<ActionHistory>();
            Devices = new HashSet<Device>();
            HouseMembers = new HashSet<HouseMember>();
            UserPreferences = new HashSet<UserPreference>();
        }

        [Key]
        public int ID { get; set; }
        [StringLength(255)]
        public string Username { get; set; } = null!;
        [StringLength(255)]
        public string Email { get; set; } = null!;
        [StringLength(255)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        public string? Role { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<ActionHistory> ActionHistories { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Device> Devices { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<HouseMember> HouseMembers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserPreference> UserPreferences { get; set; }
    }
}
