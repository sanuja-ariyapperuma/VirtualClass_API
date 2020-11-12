using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ans_VC_UserVirtualClass")]
    public class ClassChapter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ChapterId { get; set; }
        public Int64 VirtualClassId { get; set; }
        [StringLength(100, ErrorMessage = "Class name can't be longer than 100 characters")]
        public string ChapterName { get; set; }
        public VitualClass VitualClasse { get; set; }
    }
}
