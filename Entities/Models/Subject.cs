using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ans_VC_Subject")]
    public class Subject
    {
        public string SubjectId { get; set; }
        [StringLength(100, ErrorMessage = "Subject name can't be longer than 100 characters")]
        public string SubjectName { get; set; }
        public ICollection<VitualClass> Students { get; set; }
    }
}
