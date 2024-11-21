using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.BaseModels
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

        public override string ToString()
        {
            Console.WriteLine("Name: " + Name, "Location: " + Location);
            return base.ToString();
        }
    }
}
