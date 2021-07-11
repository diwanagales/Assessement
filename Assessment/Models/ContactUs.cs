﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Models
{
    public class ContactUs
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required.")]
        public string SenderName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid format.")]
        [Required(ErrorMessage = "Required.")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
