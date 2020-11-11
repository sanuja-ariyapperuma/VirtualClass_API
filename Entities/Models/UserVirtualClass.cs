using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ans_VC_UserVirtualClass")]
    public class UserVirtualClass
    {
        [Key, Column(Order = 1)]
        public long UserId { get; set; }
        [Key, Column(Order = 2)]
        public long VirtualClassId { get; set; }
        public bool IsLecturer { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }
        public VitualClass VitualClass { get; set; }
    }
}
