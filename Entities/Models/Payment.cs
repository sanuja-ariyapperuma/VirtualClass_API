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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PaymentId { get; set; }
        [StringLength(10,MinimumLength = 10, ErrorMessage = "Payment reference should be exactly 10 characters")]
        public string PaymentReference { get; set; }
        public long UserId  { get; set; }
        public long VirtualClassId { get; set; }
        public decimal Amount { get; set; }
        public int Period { get; set; }
        public DateTime PaymentDate { get; set; }
        public User User { get; set; }
        public VirtualClass VirtualClass { get; set; }

}
    
}
