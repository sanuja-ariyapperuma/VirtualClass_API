using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Chapter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ChapterId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Chapter name can't be longer than 100 characters")]
        public string ChapterName { get; set; }

        public long VirtualClassId { get; set; }
        public ICollection<StudyMaterial> StudyMaterials { get; set; }

        public VirtualClass VitualClass { get; set; }
    }
}
