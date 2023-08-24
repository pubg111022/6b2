using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [DefaultValue(true)]
        public Boolean Status { get; set; }

        public ICollection<Mark> Mark { get; set; }
    }
}
