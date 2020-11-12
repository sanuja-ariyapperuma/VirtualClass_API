using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models
{
    [Table("Ans_VC_Catogary")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CatogaryId { get; set; }
        
        [StringLength(100, ErrorMessage = "Catogary name can't be longer than 100 characters")]
        public string CatogaryName { get; set; }

        [ForeignKey("CatogaryId")]
        public long ParentCatogaryId { get; set; }
        public ICollection<SubjectCatogary> SubjectCatogaries { get; set; }
    }
}
