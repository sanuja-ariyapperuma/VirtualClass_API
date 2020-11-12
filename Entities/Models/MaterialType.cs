using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class MaterialType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MaterialTypeId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Material type can't be longer than 100 characters")]
        public string MaterialTypeName { get; set; }

        public ICollection<StudyMaterial> StudyMaterials { get; set; }
    }
}
