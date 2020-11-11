﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entities.Models
{
    [Table("ans_vc_users")]
    public class User
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 UserId { get; set; }

        [StringLength(
            100, 
            ErrorMessage = "First name can't be longer than 50 characters"
            )]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(
            100, 
            ErrorMessage = "Last name can't be longer than 50 characters"
            )]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(
            200, 
            ErrorMessage = "Email can't be longer than 50 characters"
            )]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String Email { get; set; }

        public String ProfilePictureURL { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public ICollection<ContactNumber> Numbers { get; set; }

    }
}
