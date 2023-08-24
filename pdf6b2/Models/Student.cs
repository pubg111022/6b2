using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Gender { get; set; }

        [Required]
        [DefaultValue(true)]
        public Boolean Status { get; set; }
        public ICollection<Mark> Mark { get; set; }
    }
}
