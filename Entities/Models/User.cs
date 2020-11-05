using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("ans_vc_users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id;

        [StringLength(50, ErrorMessage = "First name can't be longer than 50 characters")]
        public String First_Name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name can't be longer than 50 characters")]
        public String Last_Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, ErrorMessage = "Email can't be longer than 50 characters")]
        public String Email { get; set; }

        public String Profile_Picture_URL { get; set; }


        [StringLength(10, MinimumLength = 10, ErrorMessage = "Telephone number must be a 10 digit number")]
        public String Contact_Number { get; set; }



    }
}
