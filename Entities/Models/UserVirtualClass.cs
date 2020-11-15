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
        public long UserId { get; set; }
        public long VirtualClassId { get; set; }
        public bool IsLecturer { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }
        public VirtualClass VitualClass { get; set; }
    }
}
