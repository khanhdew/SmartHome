using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models
{
    [Table("ActionHistory")]
    public partial class ActionHistory
    {
        [Key]
        public int ID { get; set; }
        public int? UserID { get; set; }
        [StringLength(50)]
        public string? EntityType { get; set; }
        public int? EntityID { get; set; }
        [StringLength(100)]
        public string? Action { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
        public string? Detail { get; set; }

        [ForeignKey("UserID")]
        [InverseProperty("ActionHistories")]
        public virtual User? User { get; set; }
    }
}
