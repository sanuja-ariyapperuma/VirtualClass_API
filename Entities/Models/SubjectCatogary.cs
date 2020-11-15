using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ans_VC_SubjectCatogary")]
    public class SubjectCatogary
    {
        [Key,Column(Order =1)]
        public long SubjectId { get; set; }
        [Key, Column(Order = 2)]
        public long CatogaryId { get; set; }
        public Subject Subject { get; set; }
        public Category Category { get; set; }

    }
}
