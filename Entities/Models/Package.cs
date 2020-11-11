using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ans_VC_Package")]
    public class Package
    {
        public long PackageId { get; set; }
        [StringLength(100, ErrorMessage = "Package name can't be longer than 100 characters")]
        public string PackageName { get; set; }
        public int Units { get; set; }
        public bool IsStorage { get; set; }
        public ICollection<VitualClass> VitualClasses { get; set; }
    }
}
