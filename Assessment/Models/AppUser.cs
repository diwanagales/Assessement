using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Assessment.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int userId { get; set; }
        public string FullName { get; set; }

        public string ContactNum { get; set; }





    }
}
