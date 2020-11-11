using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ans_VC_Payment")]
    public class Payment
    {
        public long PaymentId { get; set; }
        [StringLength(15, ErrorMessage = "PaymentReference can't be longer than 15 characters")]
        public string PaymentReference { get; set; }
        public long UserId  { get; set; }
        public long VirtualClassId { get; set; }
        public decimal Price { get; set; }
        public int Period { get; set; }
        public DateTime PaymentDate { get; set; }
        public User User { get; set; }
        public UserVirtualClass UserVirtualClass { get; set; }

}
    
}
