using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Agency.Web.Models
{
    public class Model
    {
        public int ModelId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public IdentityUser User { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Suffix { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
