using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Photo { get; set; }
        [MaxLength(100)]

        public string Title { get; set; }
        [MaxLength(500)]

        public string Desc { get; set; }
        [MaxLength(20)]

        public string Price { get; set; }
        [MaxLength(250)]

        public string RedirectUrl { get; set; }
        public int Order { get; set; }


    }
}
