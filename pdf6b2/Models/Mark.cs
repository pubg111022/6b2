using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Models
{
    [Table("Marks")]
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Students")]
        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Subjects")]
        [Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Scores { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

    }
}
