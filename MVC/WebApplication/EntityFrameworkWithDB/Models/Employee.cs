using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkWithDB.Models
{
    [Table("Employee4")]
    public class Employee4
    {
        [Key]
        [Column("id",TypeName = "int")]
        public int Id { get; set; }

        [Column("name",TypeName ="varchar(50)")]
        public string? EName { get; set; }

        [Column("address",TypeName ="varchar(50")]
        public string? EAddress { get; set; }
    }
}
