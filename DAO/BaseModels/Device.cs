﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DAO.Models;

namespace DAO.BaseModels
{
    [Table("Device")]
    public partial class Device 
    {
        public Device()
        {
            DeviceConfigs = new HashSet<DeviceConfig>();
            TelemetryData = new HashSet<TelemetryDatum>();
        }
        

        [Key]
        public int ID { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Type { get; set; }
        [StringLength(255)]
        public string? DeviceToken { get; set; }
        public string? UserID { get; set; }
        public int? RoomID { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }

        [ForeignKey("RoomID")]
        [InverseProperty("Devices")]
        public virtual Room? Room { get; set; }
        [ForeignKey("UserID")]
        [InverseProperty("Devices")]
        public virtual User? User { get; set; }
        [InverseProperty("Device")]
        public virtual ICollection<DeviceConfig> DeviceConfigs { get; set; }
        [InverseProperty("Device")]
        public virtual ICollection<TelemetryDatum> TelemetryData { get; set; }
    }
}