using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("ans_vc_contactnumber")]
    public class ContactNumber
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(User))]
        public Int64 UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(
            10,
            MinimumLength = 10,
            ErrorMessage = "Telephone number must be a 10 digit number"
            )]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public String Number { get; set; }
    }
}
