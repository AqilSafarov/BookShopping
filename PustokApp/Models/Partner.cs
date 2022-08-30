using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Partner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Phote { get; set; }
        public int Order { get; set; }
    }
}
