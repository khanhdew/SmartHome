using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models
{
    [Table("HouseMember")]
    public partial class HouseMember
    {
        [Key]
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int? HouseID { get; set; }
        [StringLength(50)]
        public string? Role { get; set; }

        [ForeignKey("HouseID")]
        [InverseProperty("HouseMembers")]
        public virtual House? House { get; set; }
        [ForeignKey("UserID")]
        [InverseProperty("HouseMembers")]
        public virtual User? User { get; set; }
    }
}
