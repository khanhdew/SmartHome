﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models
{
    [Table("UserPreference")]
    public partial class UserPreference
    {
        [Key]
        public int ID { get; set; }
        public int? UserID { get; set; }
        public string? Detail { get; set; }

        [ForeignKey("UserID")]
        [InverseProperty("UserPreferences")]
        public virtual User? User { get; set; }
    }
}
