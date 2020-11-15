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

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }

        [StringLength(
            10,
            MinimumLength = 10,
            ErrorMessage = "Telephone number must be a 10 digit number"
            )]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public String Number { get; set; }
    }
}
