using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models
{
    [Table("House")]
    public partial class House
    {
        public House()
        {
            HouseMembers = new HashSet<HouseMember>();
            Rooms = new HashSet<Room>();
        }

        [Key]
        public int ID { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Location { get; set; }

        [InverseProperty("House")]
        public virtual ICollection<HouseMember> HouseMembers { get; set; }
        [InverseProperty("House")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
