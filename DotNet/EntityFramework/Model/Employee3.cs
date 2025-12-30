using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    [Table("Employee3")]
    internal class Employee3
    {
        [Key]
        [Column("EId",TypeName ="int")]
        public int EId { get; set; }

        [Column("EName",TypeName ="varchar(50)")]
        public string? Ename {  get; set; }

        [Column("EAddress",TypeName ="varchar(50)")]
        public string? EAddress {  get; set; }
    }
}
