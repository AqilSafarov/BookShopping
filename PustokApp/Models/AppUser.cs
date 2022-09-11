using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class AppUser:IdentityUser
    {
        [MaxLength(50)]
        public string Fullname { get; set; }
    }
}
