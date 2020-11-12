using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models
{
    [Table("Ans_VC_User")]
    public class VitualClass
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VirtualClassId { get; set; }
        [StringLength(100, ErrorMessage = "Class name can't be longer than 100 characters")]
        public string VirtualClassName { get; set; }
        public long SubjectId { get; set; }
        public long StudentCount { get; set; }
        public decimal ClassFee { get; set; }
        public decimal Duration { get; set; }
        public DateTime ClassRegularDate { get; set; }
        public DateTime ClassAlternativeDate { get; set; }
        public Subject Subject { get; set; }
        public Package Package { get; set; }
        public ICollection<UserVirtualClass> UserVirtualClasses { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<StudyMaterial> StudyMaterials { get; set; }

    }
}
