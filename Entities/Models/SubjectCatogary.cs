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
        public long SubjectId { get; set; }
        public long CatogaryId { get; set; }
        public Subject Subject { get; set; }
        public Category Category { get; set; }

    }
}
