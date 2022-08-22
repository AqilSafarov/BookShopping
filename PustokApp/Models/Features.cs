using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Features
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Icon { get; set; }
        [MaxLength(100)]

        public string Title { get; set; }
        [MaxLength(100)]

        public string Subtitle { get; set; }
    }
}
