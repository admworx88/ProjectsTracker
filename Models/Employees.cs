using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectsTracker.Models
{
    public class Employees
    {
        [Key]
        public int RecordID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "varchar(250)")]
        public string Company { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string Project { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        public string Role { get; set; } = string.Empty;
    }
}
