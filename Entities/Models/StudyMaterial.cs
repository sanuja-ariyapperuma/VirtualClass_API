using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Text;

namespace Entities.Models
{
    [Table("Ans_VC_StudyMaterial")]
    public class StudyMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MaterialId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Material name can't be longer than 100 characters")]
        public string MaterialName { get; set; }
        [Required]
        [Range(0,double.MaxValue, ErrorMessage = "File size should be greater than 0mb")]
        public double MaterialSize { get; set; }
        [Required]
        public string FilePath { get; set; }
        [Required]
        public DateTime UploadDate { get; set; }
        public long VirtualClassId { get; set; }
        public long MaterialTypeId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public VirtualClass VitualClass { get; set; }
        public MaterialType MaterialType { get; set; }
        public Chapter Chapter { get; set; }



    }
}
